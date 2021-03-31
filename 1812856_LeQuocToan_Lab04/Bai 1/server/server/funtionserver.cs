using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;


namespace server
{
    

    class funtionserver
    {
        byte[] buff;
        int byteReceive;
        Socket clientSocket;
        IPEndPoint serverEndpoint;
        Socket serverSocket;

        public delegate void SetTextDelegate(string Text);
        public event SetTextDelegate SetTextFunction = null;
        string str;
        public funtionserver()
        {
            serverEndpoint = new IPEndPoint(IPAddress.Any, 9998);
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            serverSocket.Bind(serverEndpoint);
            serverSocket.Listen(10);
        }
        public void StartServer()
        {
            serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), serverSocket);
        }

        void AcceptCallback(IAsyncResult iar)
        {
            serverSocket = (Socket)iar.AsyncState;
            clientSocket = serverSocket.EndAccept(iar);

            str = "Thong tin client ket noi: " + clientSocket.RemoteEndPoint;
            if (SetTextFunction != null)
                SetTextFunction(str);

            str = "Xin chao client";
            buff = Encoding.ASCII.GetBytes(str);

            clientSocket.BeginSend(buff, 0, buff.Length, SocketFlags.None, new AsyncCallback(SendCallback), clientSocket);
        }

        void SendCallback(IAsyncResult iar)
        {
            clientSocket = (Socket)iar.AsyncState;
            clientSocket.EndSend(iar);

            buff = new byte[1024];
            clientSocket.BeginReceive(buff, 0, buff.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), clientSocket);
        }

        void ReceiveCallback(IAsyncResult iar)
        {
            clientSocket = (Socket)iar.AsyncState;
            byteReceive = clientSocket.EndReceive(iar);

            str = Encoding.ASCII.GetString(buff, 0, buff.Length);

            if (SetTextFunction != null)
                SetTextFunction(str);

            clientSocket.BeginSend(buff, 0, buff.Length, SocketFlags.None, new AsyncCallback(SendCallback), clientSocket);
        }
    }
    

}
