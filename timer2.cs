using System;
using Azure.Data.AppConfiguration;
using System.Threading.Tasks;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace newappconfig123fa
{
    public class timer2
    {
        private readonly ILogger _logger;

        public timer2(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<timer2>();
        }

        [Function("timer2")]
        public async Task Run([TimerTrigger("*/5 * * * * *")] TimerInfo myTimer)
        {
            _logger.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");

            _logger.LogInformation(
                await GetAppConfigValueAsync(Environment.GetEnvironmentVariable("ConnectionString"))
                );

        }

        public async Task<string> GetAppConfigValueAsync(string connectionString)
        {
            try
            {
                // Initialize the Configuration Client using the connection string
                var client = new ConfigurationClient(connectionString);

                // Retrieve a setting (for example, "MySetting") from Azure App Configuration
                ConfigurationSetting setting = await client.GetConfigurationSettingAsync("testkey");

                // Print out the value of the setting
                return $"Key: {setting.Key}, Value: {setting.Value}";
            }
            catch (Exception exc)
            {
                return exc.Message;
            }

        }
    }
}
