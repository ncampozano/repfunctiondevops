using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace TreinamentoDevOps.Functions
{
    public static class FunctionDevOps
    {
        [FunctionName("FunctionDevOps")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "FunctionDevOps")] HttpRequest req,
            ILogger log)
        {
            
            return new OkObjectResult("Hello World");
        }
    }
}
