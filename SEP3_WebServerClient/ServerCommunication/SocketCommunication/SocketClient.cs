using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SEP3_WebServerClient.Models;

namespace ServerCommunication.SocketCommunication
{
    public class SocketClient : ISocketClient
    {
        
        public SocketClientHandler SocketClientHandler;

        
        
        
        
        
        
        public void CreateClientHandler()
        {
        }
        
        public Task SendToServer(Spike spike)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Spike>> GetFromServer()
        {
            throw new NotImplementedException();
        }
        
        
    }
}