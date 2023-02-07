using Confluent.Kafka;

var config = new ProducerConfig
{
	BootstrapServers = "localhost:9092",
	Acks = Acks.None
};

var producer = new ProducerBuilder<Null, string>(config).Build();

try 
{
	while (true)
	{
		Console.WriteLine("type a message to send");
		string? message = Console.ReadLine();
		if (String.IsNullOrEmpty(message))
		{
			break;
		}
		else
		{
			var response = producer.ProduceAsync("my-topic-1", new Message<Null, string> { Value = message });
		}
	}
	
}
catch(ProduceException<Null, string> ex)
{
	Console.WriteLine($"error occurred producing {ex.Message}");
	
}