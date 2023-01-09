namespace dotnet_slack.Services
{
    public interface ISendNotification
    {
        Task SendMessage(string text);
    }
}
