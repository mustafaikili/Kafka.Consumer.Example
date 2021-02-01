using Kafka.Consumer.Example.Consumers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Trendyol.Confluent.Kafka;

namespace Kafka.Consumer.Example
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHostedService<KafkaConsumerService>();

            services.AddKafkaConsumer<ConsumerExample>(configuration =>
            {
                configuration.Topic = "MyTopic";
                configuration.GroupId = "MyGroup";
                configuration.BootstrapServers = _configuration.GetValue<string>("BootstrapServers");
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
        }
    }
}