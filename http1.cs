//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Azure.Functions.Worker;
//using Microsoft.Extensions.Logging;
//using Microsoft.Extensions.Configuration;

//namespace newappconfig123fa
//{
//    public class http1
//    {
//        private readonly ILogger<http1> _logger;
//        private readonly IConfiguration _configuration;

//        public http1(ILogger<http1> logger, IConfiguration configuration)
//        {
//            _logger = logger;
//            _configuration = configuration;
//        }

//        [Function("http1")]
//        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
//        {
//            _logger.LogInformation("C# HTTP trigger function processed a request.");
//            return new OkObjectResult(_configuration["testkey"]);
//        }
//    }
//}
