using System.Threading.Tasks;

namespace SignalR.API
{
    public interface ITypedHubClient
    {
        Task BroadcastMessage(string type, string payload);
    }
}