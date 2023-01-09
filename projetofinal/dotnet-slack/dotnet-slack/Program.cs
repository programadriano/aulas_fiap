// See https://aka.ms/new-console-template for more information


using System.Text.Json;
using System.Text;

HttpClient _client = new HttpClient();


const string _randomChannel = "/services/T04GHTU2Z8V/B04GLTLL23U/Nw8YQBkjsptGvR3PAT1RXKGK";

var contentObject = new { text = "Hello world!" };
var contentObjectJson = JsonSerializer.Serialize(contentObject);
var content = new StringContent(contentObjectJson, Encoding.UTF8, "application/json");

var result = await _client.PostAsync("https://hooks.slack.com" + _randomChannel, content);
var resultContent = await result.Content.ReadAsStringAsync();

if (!result.IsSuccessStatusCode)
{
    throw new Exception("Task failed.");
}

Console.WriteLine("Hello, World!");
