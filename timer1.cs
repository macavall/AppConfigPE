//using System;
//using Microsoft.Azure.Functions.Worker;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.Logging;

//namespace newappconfig123fa
//{
//    public class timer1
//    {
//        private readonly ILogger _logger;
//        private readonly IConfiguration _configuration;

//        public timer1(ILoggerFactory loggerFactory, IConfiguration configuration)
//        {
//            _logger = loggerFactory.CreateLogger<timer1>();
//            _configuration = configuration;
//        }

//        [Function("timer1")]
//        public void Run([TimerTrigger("*/5 * * * * *")] TimerInfo myTimer)
//        {
//            _logger.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");

//            _logger.LogInformation(_configuration["testkey"]);
//        }
//    }
//}
