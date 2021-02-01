using System.Threading;
using System.Threading.Tasks;
using Kafka.Consumer.Example.Consumers;
using Microsoft.Extensions.Hosting;

namespace Kafka.Consumer.Example
{
    public class KafkaConsumerService : BackgroundService
    {
        
        private readonly ConsumerExample _consumer;

        public KafkaConsumerService(ConsumerExample consumer)
        {
            _consumer = consumer;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await _consumer.RunAsync(stoppingToken);
        }
    }
}