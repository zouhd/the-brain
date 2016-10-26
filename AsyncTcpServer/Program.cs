using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncTcpServer
{
    class Program
    {
        static void Main(string[] args)
        {
            AsyncTcpServer server = new AsyncTcpServer("127.0.0.1", 8888, 5);
            server.StartListening();
            Console.Read();
            server.Stop();
        }
    }
}
