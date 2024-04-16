using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace FunctionAppHttpResponseTest
{
    public class Http400Function
    {
        private readonly ILogger _logger;

        public Http400Function(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<Http400Function>();
        }

        [Function("Http400Function")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequestData req)
        {
            _logger.LogInformation("Http400Function processed a request.");

            var response = req.CreateResponse(HttpStatusCode.BadRequest);

            return response;
        }
    }
}
