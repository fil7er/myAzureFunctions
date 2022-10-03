using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using azureFunctions.Strategy;

namespace azureFunctions.Function
{
    public static class handleDummyFunctions
    {
        [FunctionName("handleDummyFunctions")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequest req)
        {
            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);

            MainEventStrategy eventStrategy = new MainEventStrategy();

            string responseMessage = JsonConvert.SerializeObject(eventStrategy.Run(new DTO.MainEventDTO()));

            return new OkObjectResult(responseMessage);
        }
    }
}
