using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()   // wires up isolated worker + triggers
    .Build();

host.Run();
