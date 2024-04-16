using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace FunctionAppHttpResponseTest
{
    public class FastHttpFunctionAnonymous
    {
        private readonly ILogger _logger;

        public FastHttpFunctionAnonymous(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<FastHttpFunctionAnonymous>();
        }

        [Function("FastHttpFunctionAnonymous")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequestData req)
        {
            _logger.LogInformation("FastHttpFunctionAnonymous processed a request.");

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

            response.WriteString("Welcome to Azure Functions!");

            return response;
        }
    }
}
