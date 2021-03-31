using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.Sockets;


namespace server
{
    

    class funtionserver
    {
        byte[] buff;
        int byteReceive;
        Socket clientSocket;
        TcpClient client;
        TcpListener server;
        IPEndPoint serverEndpoint;
        Socket serverSocket;
        StreamReader sr;
        StreamWriter sw;

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
        public void Listen(object obj)
        {
            server = new TcpListener(IPAddress.Any, 9998);
            server.Start();
            SetTextFunction("Dang cho client ket noi toi ...");
            client = server.AcceptTcpClient();
            SetTextFunction("Client "+client.Client.RemoteEndPoint.ToString()+"da ket noi den")
            NetworkStream ns = client.GetStream();
            sr = new StreamReader(ns);
            sw = new StreamWriter(ns);

            
        }
        public void StartServer()
        {
            serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), serverSocket);
        }

       
    }
    

}
