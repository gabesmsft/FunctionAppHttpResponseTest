using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace FunctionAppHttpResponseTest
{
    public class Http500Function
    {
        private readonly ILogger _logger;

        public Http500Function(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<Http500Function>();
        }

        [Function("Http500Function")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequestData req)
        {
            _logger.LogInformation("Http500Function processed a request.");

            var response = req.CreateResponse(HttpStatusCode.InternalServerError);

            return response;
        }
    }
}
