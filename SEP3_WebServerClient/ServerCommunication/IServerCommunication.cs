using SEP3_WebServerClient.Models;

namespace SEP3_WebServerClient.ServerCommunication
{
    public interface IServerCommunication
    {
        void SendToServer(Spike spike);

        void GetFromServer();
    }
}