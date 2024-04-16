using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace FunctionAppHttpResponseTest
{
    public class FastHttpFunctionWithSystemKeyAuth
    {
        private readonly ILogger _logger;

        public FastHttpFunctionWithSystemKeyAuth(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<FastHttpFunctionWithSystemKeyAuth>();
        }

        [Function("FastHttpFunctionWithSystemKeyAuth")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.System, "get", "post")] HttpRequestData req)
        {
            _logger.LogInformation("FastHttpFunctionWithSystemKeyAuth processed a request.");

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

            response.WriteString("Welcome to Azure Functions!");

            return response;
        }
    }
}
