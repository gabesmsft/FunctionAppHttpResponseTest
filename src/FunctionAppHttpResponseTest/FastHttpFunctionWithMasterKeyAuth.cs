using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace FunctionAppHttpResponseTest
{
    public class FastHttpFunctionWithMasterKeyAuth
    {
        private readonly ILogger _logger;

        public FastHttpFunctionWithMasterKeyAuth(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<FastHttpFunctionWithMasterKeyAuth>();
        }

        [Function("FastHttpFunctionWithMasterKeyAuth")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Admin, "get", "post")] HttpRequestData req)
        {
            _logger.LogInformation("FastHttpFunctionWithMasterKeyAuth processed a request.");

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

            response.WriteString("Welcome to Azure Functions!");

            return response;
        }
    }
}
