using System.Net;
using System.Text.Json;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Azure.Functions.Worker.Extensions.CosmosDB;
using Microsoft.Extensions.Logging;


namespace Company.Function
{
    public class NewBaseType
    {
        private readonly ILogger<NewBaseType> _logger;
        public NewBaseType(ILogger<NewBaseType> logger) => _logger = logger;

        [Function("GetResumeCounterV10")]
        [CosmosDBOutput(
            databaseName: "AzureResume",
            containerName: "Counter",
            Connection = "AzureResumeConnectionString")]
        public async Task<Counter> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequestData req,

            // Cosmos DB INPUT (reads the doc)
            [CosmosDBInput(
                databaseName:"AzureResume",
                containerName: "Counter",
                Connection   = "AzureResumeConnectionString",
                Id           = "1",
                PartitionKey = "1")]
            Counter counter)
        {
            _logger.LogInformation("C# isolated HTTP trigger function processed a request.");

            counter ??= new Counter { Id = "1", Count = 0 };
            counter.Count += 1;

            // build HTTP response
            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "application/json; charset=utf-8");

            // optional: read query/body
            var query = System.Web.HttpUtility.ParseQueryString(req.Url.Query);
            var name  = query["name"];

            await response.WriteStringAsync(JsonSerializer.Serialize(new {
                message = string.IsNullOrEmpty(name)
                    ? "Counter incremented."
                    : $"Hello, {name}. Counter incremented.",
                counter
            }));

            // Return the updated counter to be written to Cosmos DB
            return counter;
        }
    }
}
