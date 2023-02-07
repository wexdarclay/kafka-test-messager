using Confluent.Kafka;

var config = new ConsumerConfig
{
	GroupId = "my-consumer-group",
	BootstrapServers = "localhost: 9092",
	AutoOffsetReset = AutoOffsetReset.Earliest
};

var consumer = new ConsumerBuilder<Null, string>(config).Build();

consumer.Subscribe("my-topic-1");

CancellationTokenSource token = new CancellationTokenSource();

try 
{
	while (true)
	{ 
		var response = consumer.Consume(token.Token);
		if (String.IsNullOrEmpty(response.Message.Value))
		{
			break;
		}
		else 
		{
			Console.WriteLine(response.Value);
		}
	}
}
catch(Exception ex) 
{
	Console.WriteLine($"An error occurred during consumation: {ex.Message}");
}
