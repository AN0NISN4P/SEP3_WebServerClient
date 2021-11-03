using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using SEP3_WebServerClient.Models;

namespace SEP3_WebServerClient.ServerCommunication
{
    public interface IServerCommunication
    {
        Task SendToServer(Spike spike);

        Task<IList<Spike>> GetFromServer();
    }
}