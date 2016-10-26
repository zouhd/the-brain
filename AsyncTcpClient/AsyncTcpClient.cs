using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace AsyncTcpClient
{
    public class StateObject
    {
        public Socket state_socket;
        public const int buffer_size = 1024;
        public byte[] buffer = new byte[buffer_size];
    }

    class AsyncTcpClient
    {
        private Socket m_client;
        private IPAddress m_server_ip;
        private IPEndPoint m_iep;

        private String m_server;
        private int m_port;

        public AsyncTcpClient(String remote_ip, int port)
        {
            m_server = remote_ip;
            m_port = port;
        }

        public void AsyncConnect()
        {
            m_client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            m_server_ip = IPAddress.Parse(m_server);
            m_iep = new IPEndPoint(m_server_ip, m_port);

            m_client.BeginConnect(m_iep, new AsyncCallback(ConnectCallback), m_client);
        }

        public void ConnectCallback(IAsyncResult iar)
        {
            Socket client = (Socket)iar.AsyncState;
            try
            {
                client.EndConnect(iar);
                if (client.Connected)
                {
                    Console.WriteLine("{0}-->client", client.RemoteEndPoint.ToString());
                    AsyncSend(client, "i AM ON LINE");
                    AsyncReceive(client);
                
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
            }
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
