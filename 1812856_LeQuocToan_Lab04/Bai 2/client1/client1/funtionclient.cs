using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace client1
{
    class funtionclient
    {
        byte[] buff;
        int byteReceive;
        IPEndPoint serverEndpoint;
        Socket serverSocket;

        public delegate void SetTextDelegate(string Text);
        public event SetTextDelegate SetTextFunction = null;
        string str;

        public funtionclient()
        {
            serverEndpoint = new IPEndPoint(IPAddress.Loopback, 9998);
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Connect()
        {
            serverSocket.BeginConnect(serverEndpoint, new AsyncCallback(ConnectCallback), serverSocket);
        }

        void ConnectCallback(IAsyncResult iar)
        {
            serverSocket = (Socket)iar.AsyncState;
            serverSocket.EndConnect(iar);

            buff = new byte[1024];
            serverSocket.BeginReceive(buff, 0, buff.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), serverSocket);
        }

        void ReceiveCallback(IAsyncResult iar)
        {
            serverSocket = (Socket)iar.AsyncState;
            byteReceive = serverSocket.EndReceive(iar);

            str = Encoding.ASCII.GetString(buff, 0, byteReceive);

            if (SetTextFunction != null)
                SetTextFunction(str);
        }

        public void SendToServer(string data)
        {
            buff = Encoding.ASCII.GetBytes(data);
            serverSocket.BeginSend(buff, 0, buff.Length, SocketFlags.None, new AsyncCallback(SendCallback), serverSocket);
        }

        void SendCallback(IAsyncResult iar)
        {
            serverSocket = (Socket)iar.AsyncState;
            serverSocket.EndSend(iar);

            buff = new byte[1024];
            serverSocket.BeginReceive(buff, 0, buff.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), serverSocket);
        }
    }
}
