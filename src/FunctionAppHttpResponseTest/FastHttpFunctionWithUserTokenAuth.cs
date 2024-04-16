using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace FunctionAppHttpResponseTest
{
    public class FastHttpFunctionWithUserTokenAuth
    {
        private readonly ILogger _logger;

        public FastHttpFunctionWithUserTokenAuth(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<FastHttpFunctionWithUserTokenAuth>();
        }

        [Function("FastHttpFunctionWithUserTokenAuth")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.User, "get", "post")] HttpRequestData req)
        {
            _logger.LogInformation("FastHttpFunctionWithUserTokenAuth processed a request.");

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

            response.WriteString("Welcome to Azure Functions!");

            return response;
        }
    }
}
