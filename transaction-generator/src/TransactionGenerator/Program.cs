using System.Globalization;
using Confluent.Kafka;
using CsvHelper;
using CsvHelper.Configuration;
using Newtonsoft.Json;
using TransactionGenerator.Models;

class Program
{
    static async Task Main(string[] args)
    {
        var config = new ProducerConfig
        {
            BootstrapServers = "localhost:9092"
        };

        using var producer = new ProducerBuilder<Null, string>(config).Build();

        var csvFilePath = "../../../../data/BankChurners.csv";

        var CSVconfig = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            // Ensures that the header is validated.
            // Throws an exception if a header is missing or doesn't match.
            HeaderValidated = null,
            MissingFieldFound = null,
        };

        using var reader = new StreamReader(csvFilePath);
        using var csv = new CsvReader(reader, CSVconfig);

        List<TransactionDTO> transactions = csv.GetRecords<TransactionDTO>().ToList();

        // var records = csv.GetRecords<TransactionDTO>();
        foreach (var record in transactions)
        {
            var json = JsonConvert.SerializeObject(record);
            await producer.ProduceAsync("transactions", new Message<Null, string> { Value = json });
            Console.WriteLine($"Produced: {json}");
            await Task.Delay(500); // slow down stream for demo
        }
    }
}
