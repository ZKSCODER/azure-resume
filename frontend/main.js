window.addEventListener('DOMContentLoaded', (event) =>{
    getVisitCount();
})

// Pick the right URL depending on where the site is running
const functionApiUrl = 
        window.location.hostname === "localhost"
        ? "http://localhost:7071/api/GetResumeCounterV10" // local Functions host
        : "/api/GetResumeCounterV10"; // production (Front Door injects key)

// Call the API when the page loads
window.addEventListener("DOMContentLoaded", () => {
  getVisitCount();
});

const getVisitCount = () => {
  let count = 30;
  fetch(functionApiUrl)
    .then((response) => response.json())
    .then((response) => {
      console.log("Website called:", functionApiUrl);
      count = response.count;
      document.getElementById("counter").innerText = count;
    })
    .catch((error) => {
      console.log(error);
    });
  return count;
};
