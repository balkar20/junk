using System.Text;
using Confluent.Kafka;
using ZooKeeperNet;
using KafkaFlow;
using Microsoft.Extensions.Hosting;
using AutoOffsetReset = KafkaFlow.AutoOffsetReset;

namespace ASP.NETCoreWebConsumer1.Extensions;

public static class KafkaConfigurationExtension
{
    public static IServiceCollection AddKafkaWithCurator(this IServiceCollection services, string zooKeeperConnectionString, string brokersPath)
    {
        var zk = new ZooKeeper(zooKeeperConnectionString, new TimeSpan(5000), null);
        services.AddSingleton<ZooKeeper>(provider =>
        {
            return zk;
        });


        services.AddKafkaFlowHostedService(kafka => kafka.AddCluster(cluster =>
        {
            var children = zk.GetChildren(brokersPath, false);
            cluster.WithBrokers(children);
            cluster.AddConsumer(customer =>
                customer.Topic(topicName: "kafkaOrderTopicName")
                    .WithName($"order-manager-{Guid.NewGuid()}")
                    .WithGroupId("order-manager")
                    .WithBufferSize(100)
                    .WithAutoOffsetReset(AutoOffsetReset.Earliest)
            );
        }));
        // services.AddSingleton<IKafkaConfiguration>(provider =>
        // {
        //     var zkClient = provider.GetRequiredService<ZooKeeper>();
        //     var brokerIds = zkClient.GetChildren(brokersPath, false);
        //
        //     var bootstrapServers = brokerIds
        //         .Select(brokerId => zkClient.GetData($"{brokersPath}/{brokerId}", false, null))
        //         .Select(data => Encoding.UTF8.GetString(data))
        //         .ToList();
        //
        //     var producerConfig = new ProducerConfig
        //     {
        //         BootstrapServers = string.Join(",", bootstrapServers),
        //         // Additional producer configuration options...
        //     };
        //
        //     var consumerConfig = new ConsumerConfig
        //     {
        //         BootstrapServers = string.Join(",", bootstrapServers),
        //         // Additional consumer configuration options...
        //     };
        //
        //     return new KafkaConfiguration(producerConfig, consumerConfig);
        // });

        return services;
    }
    
    
}

public interface IKafkaConfiguration
{
    ProducerConfig ProducerConfig { get; }
    ConsumerConfig ConsumerConfig { get; }
}

public class KafkaConfiguration : IKafkaConfiguration
{
    public KafkaConfiguration(ProducerConfig producerConfig, ConsumerConfig consumerConfig)
    {
        ProducerConfig = producerConfig;
        ConsumerConfig = consumerConfig;
    }

    public ProducerConfig ProducerConfig { get; }
    public ConsumerConfig ConsumerConfig { get; }
}