using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Sockets;
using System.Net;



namespace AsyncTcpServer
{
    public class StateObject
    {
        public Socket state_socket;
        public const int buffer_size = 1024;
        public byte[] buffer = new byte[buffer_size];
    }

    class AsyncTcpServer
    {
        private String m_host;
        private int m_port;
        private int m_client_count;

        private IPAddress m_server_ip;
        private IPEndPoint m_iep;

        private Socket m_server;

        private bool isRunning = true;

        private static int m_count = 0;


        public AsyncTcpServer(string host, int port, int client_count)
        {
            m_host = host;
            m_port = port;
            m_client_count = client_count;

        }

        public void StartListening()
        {
            m_server_ip = IPAddress.Parse(m_host);
            m_iep = new IPEndPoint(m_server_ip, m_port);

            m_server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            m_server.Bind(m_iep);
            m_server.Listen(m_client_count);

            AsyncAccept();
        }

        public void Stop()
        {
            //m_server.Close();
        }

        public void AsyncAccept()
        {

            if (isRunning)
            {
                m_server.BeginAccept(new AsyncCallback(AcceptCallback), m_server);
                m_count++;
            }
            
        }

        private void AcceptCallback(IAsyncResult iar)
        {
            Socket server = (Socket)iar.AsyncState;
            Socket service = server.EndAccept(iar);
            Console.WriteLine("当前线程号: {0}", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("序号：{0} server <-- {1}", m_count, service.RemoteEndPoint.ToString());


            AsyncAccept();//实现循环的关键

            //具体的消息处理过程
            AsyncReceive(service);
            AsyncSend(service, "hello, client");


            
        }

        public void AsyncSend(Socket handler, String data)
        {
            // Convert the string data to byte data using ASCII encoding.     
            byte[] byteData = Encoding.ASCII.GetBytes(data);
            // Begin sending the data to the remote device.     
            handler.BeginSend(byteData, 0, byteData.Length, 0, new AsyncCallback(SendCallback), handler);
        }

        private void SendCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.     
                Socket handler = (Socket)ar.AsyncState;
                // Complete sending the data to the remote device.     
                int bytesSent = handler.EndSend(ar);
                Console.WriteLine("Sent {0} bytes to client.", bytesSent);
                //handler.Shutdown(SocketShutdown.Both);
                //handler.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        
        public void AsyncReceive(Socket client)
        {
            StateObject obj = new StateObject();
            obj.state_socket = client;
            Array.Clear(obj.buffer, 0, obj.buffer.Length);

            try
            {
                client.BeginReceive(obj.buffer, 0, obj.buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), obj);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        private void ReceiveCallback(IAsyncResult ar)
        {

            try
            {
                StateObject obj = (StateObject)ar.AsyncState;
                Socket client = obj.state_socket;

                // Read data from the remote device.     
                int bytesRead = client.EndReceive(ar);
                if (bytesRead > 0)
                {
                    // There might be more data, so store the data received so far.     

                    string msg = Encoding.ASCII.GetString(obj.buffer).TrimEnd('\0');
                    // Get the rest of the data.     
                    Console.WriteLine("收到消息: {0}", msg);
                   
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        
    }
}
