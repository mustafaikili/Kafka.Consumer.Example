using System;
using System.Threading.Tasks;
using Confluent.Kafka;
using Trendyol.Confluent.Kafka;

namespace Kafka.Consumer.Example
{
    public class Consumer : KafkaConsumer
    {
        protected override Task OnConsume(ConsumeResult<string, string> result)
        {
            Console.WriteLine(result.Message.Value);
            return Task.CompletedTask;
        }

        protected override Task OnError(Exception exception, ConsumeResult<string, string> result)
        {
            Console.WriteLine(exception.Message);
            return Task.CompletedTask;
        }
    }
}