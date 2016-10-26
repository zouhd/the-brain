using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncTcpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            AsyncTcpClient client = new AsyncTcpClient("127.0.0.1", 8888);
            client.AsyncConnect();
            
            Console.Read();
        }
    }
}
