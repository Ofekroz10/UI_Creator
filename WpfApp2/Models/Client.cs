using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Models
{
    /*
     This class represents a UdpClient
     */ 

    class Client
    {
        private readonly string hostName;
        private readonly int port;
        private UdpClient client;

        public Client(string hostName, int port)
        {
            this.hostName = hostName;
            this.port = port;
            this.client.Connect(this.hostName, this.port);
        }

        public void Send(string message)
        {
            var datagram = Encoding.ASCII.GetBytes(message);
            this.client.Send(datagram, datagram.Length);
        }
    }

}