using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Threading.Tasks;
using SEP3_WebServerClient.Models;

namespace SEP3_WebServerClient.ServerCommunication.SocketCommunication
{
    public class SocketClient : ISocketClient
    {
        
        public SocketClientHandler SocketClientHandler;

        
        
        
        
        
        
        public void CreateClientHandler()
        {
        }
        
        public Task SendToServer(Spike spike)
        {
            throw new System.NotImplementedException();
        }

        public Task<IList<Spike>> GetFromServer()
        {
            throw new NotImplementedException();
        }
        
        
    }
}