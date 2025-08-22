window.addEventListener('DOMContentLoaded', (event) =>{
    getVisitCount();
})

const functionApiUrl = AZURE_FUNCTION_KEY;
const localfunctionApi = 'http://localhost:7071/api/GetResumeCounterV10';

const getVisitCount = () => {
    let count = 30
    fetch(functionApiUrl).then(response => {
            return response.json()
        }).then(response => {
            console.log("Website called 'functionApiUrl' ");
            count = response.count;
            document.getElementById("counter").innerText = count;
        }).catch(function(error){
            console.log(error);
        });
        return count;

}