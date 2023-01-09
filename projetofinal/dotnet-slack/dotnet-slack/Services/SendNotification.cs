using System.Text.Json;
using System.Text;

namespace dotnet_slack.Services
{
    public class SendNotification : ISendNotification
    {
        private readonly HttpClient _client;

        private const string _randomChannel = "/services/TTTSTTV6C/BU7SQBPN1/MPd8qPLTKe83bs2R6EEi5bif";


        public SendNotification(HttpClient client)
        {
            _client = client;
        }

        public async Task SendMessage(string text)
        {
            var contentObject = new { text = text };
            var contentObjectJson = JsonSerializer.Serialize(contentObject);
            var content = new StringContent(contentObjectJson, Encoding.UTF8, "application/json");

            var result = await _client.PostAsync("https://hooks.slack.com" + _randomChannel, content);
            var resultContent = await result.Content.ReadAsStringAsync();

            if (!result.IsSuccessStatusCode)
            {
                throw new Exception("Task failed.");
            }
        }
    }
}
