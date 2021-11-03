using System;
using System.Net.Sockets;
using SEP3_WebServerClient.Models;

namespace SEP3_WebServerClient.ServerCommunication.SocketCommunication
{
    public class SocketClient : ISocketClient
    {
        public SocketClientHandler SocketClientHandler;

        public void CreateClientHandler()
        {
        }
        
        public void SendToServer(Spike spike)
        {
            throw new System.NotImplementedException();
        }

        public void GetFromServer()
        {
            throw new System.NotImplementedException();
        }

        
    }
}