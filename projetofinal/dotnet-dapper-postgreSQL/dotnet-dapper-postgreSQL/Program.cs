// See https://aka.ms/new-console-template for more information
using Npgsql;

NpgsqlConnection connection = new NpgsqlConnection("User ID=postgres;Password=102030;Host=127.0.0.1;Port=5432;Database=postgres;Pooling=true;");
connection.Open();

string commandText = $"select * from person";

NpgsqlCommand cmd = new NpgsqlCommand(commandText, connection);
NpgsqlDataReader reader = await cmd.ExecuteReaderAsync();

var result = await reader.ReadAsync();

Console.WriteLine("Hello, World!");
