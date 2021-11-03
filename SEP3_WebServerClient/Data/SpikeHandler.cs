using System.Collections.Generic;
using System.Threading.Tasks;
using SEP3_WebServerClient.Models;
using SEP3_WebServerClient.ServerCommunication;
using SEP3_WebServerClient.ServerCommunication.SocketCommunication;

namespace SEP3_WebServerClient.Data
{
    public class SpikeHandler : ISpikeHandler
    {
        public IServerCommunication ServerCommunication;

        public SpikeHandler()
        {
            //TODO: what i do then?
            //den kan jo ikke oprette en instans af IserverCommunication da det er et interface
            //ServerCommunication = new();
        }
        
        public async Task NewSpike(Spike newSpike)
        {
            await ServerCommunication.SendToServer(newSpike);
        }

        public async Task<IList<Spike>> GetSpikes()
        {
            return await ServerCommunication.GetFromServer();
        }
    }
}