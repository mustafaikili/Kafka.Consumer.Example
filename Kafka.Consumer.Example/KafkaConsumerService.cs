using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace Kafka.Consumer.Example
{
    public class KafkaConsumerService : BackgroundService
    {
        
        private readonly Consumer _consumer;

        public KafkaConsumerService(Consumer consumer)
        {
            _consumer = consumer;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await _consumer.RunAsync(stoppingToken);
        }
    }
}