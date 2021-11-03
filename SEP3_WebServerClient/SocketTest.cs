using System;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using SEP3_WebServerClient.Models;

namespace SEP3_WebServerClient
{
    public class SocketTest
    {
        
        public static void Main(string[ ] args)
        {
            
            //sending
            TcpClient client = new TcpClient("localhost",1235);

            NetworkStream networkStream = client.GetStream();

            string spikeAsJSON = JsonSerializer.Serialize(new Spike{snor = "SnorSnor"});
            byte[] bytes = Encoding.ASCII.GetBytes(spikeAsJSON);
            
            networkStream.Write(bytes, 0 ,bytes.Length);

            Console.Read();
            
            
            //reading
            byte[] fromServer = new byte[1024];
            int bytesRead = networkStream.Read(fromServer, 0, fromServer.Length);
            string response = Encoding.ASCII.GetString(fromServer, 0, bytesRead);
            Console.WriteLine(response);
            
            
        }
        
    }
}