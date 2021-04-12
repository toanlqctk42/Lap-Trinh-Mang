using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Collections;
using MayTinh;
using NetLib;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;		

namespace ThuBaiThi
{
    class ServerThread
    {
        public List<Socket> ListClient;
        public TcpListener listener;
        private const int Buffersize = 1024 * 1024 * 20;
        private const int port = 1605;
        public Queue InQueue = new Queue();
        public Queue OutQueue = new Queue();
        public Queue CommandQueue = new Queue();
        public Queue inCommandQueue = new Queue();
        MaytinhInfoManager maytinhInfoManager;

        StreamReader sr;
       
        StreamWriter sw;
        Thread mainThread;
        Thread t;

        Thread sendCommand;
        Thread receiveCommand;
        event Action<List<Maytinhinfo>> _onClientListChanged;
        public event Action<List<Maytinhinfo>> OnClientListChanged
        {
            add
            {
                _onClientListChanged += value;
            }
            remove
            {
                _onClientListChanged -= value;
            }
        }
        public ServerThread()
        {
            listener = new TcpListener(port);
            ListClient = new List<Socket>();
            
        }
        public void Start()
        {
            listener = new TcpListener(IPAddress.Any, 1605);
            listener.Start();
            OutQueue.Enqueue("Dang cho ket noi den...");
            mainThread = new Thread(new ThreadStart(Tam));
            mainThread.Start();

            IPEndPoint serverIP = null;

            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    serverIP = new IPEndPoint(ip, port);
                    break;
                }
            }
            sendCommand = new Thread(new ThreadStart(SendCommand));
            sendCommand.Start();

            receiveCommand = new Thread(new ThreadStart(ProcessCommand));
            receiveCommand.Start();
        }

        public void ReceiveCommand(object obj)
        {
            Socket client = obj as Socket;
            string ClientIP = client.RemoteEndPoint.ToString().Split(':')[0];
            Maytinhinfo maytinhinfo = maytinhInfoManager.Find(ClientIP);
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[Buffersize];
                    client.Receive(buffer);
                    ServerResponse response = ServerResponse.Deserialize(buffer);
                    switch (response.Type)
                    {
                        case ServerResponseType.SendFile:
                            break;
                        case ServerResponseType.SendList:
                            break;
                        case ServerResponseType.SendStudent:
                            Student student = response.Data as Student;
                            maytinhinfo.student = student;
                            maytinhinfo.status = ClientinfoStatus.StudentConnected;
                            if (_onClientListChanged != null)
                                _onClientListChanged(maytinhInfoManager.maytinh);
                            break;
                        case ServerResponseType.SendString:
                            break;
                        case ServerResponseType.SendPcName:
                            string pcname = response.Data as string;
                            maytinhinfo.PCName = pcname;
                            maytinhinfo.status = ClientinfoStatus.ClientConnected;
                            if (_onClientListChanged != null)
                                _onClientListChanged(maytinhInfoManager.maytinh);
                            break;
                        case ServerResponseType.DisconnectAll:

                            break;
                        case ServerResponseType.BeginExam:
                            break;
                        case ServerResponseType.FinishExam:
                            break;
                        case ServerResponseType.LockClient:
                            break;
                        case ServerResponseType.Undefined:
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception)
            {

               maytinhinfo.status = ClientinfoStatus.Disconnected;

                if (_onClientListChanged != null)
                    _onClientListChanged(maytinhInfoManager.maytinh);

                ListClient.Remove(client);
                client.Close();
            }

        }

        public void ProcessCommand()
        {
            
        }


      

        public void Close()
        {
           

        }

        public void SendCommand()
        {
            
        }

       

        public void Tam()
        {
            while (true)
            {
                while (!listener.Pending())
                {
                    Thread.Sleep(1000);
                }
               
                Socket clientToHandle = listener.AcceptSocket();
                ListClient.Add(clientToHandle);
                string IP = clientToHandle.RemoteEndPoint.ToString().Split(':')[0];
                Maytinhinfo newmaytinh = new Maytinhinfo()
                {
                    endPoint = clientToHandle.RemoteEndPoint as IPEndPoint,
                    ClientIP = IP,
                    status = ClientinfoStatus.ClientConnected
                };
                maytinhInfoManager.Add(newmaytinh);
                if (_onClientListChanged != null)
                    _onClientListChanged(maytinhInfoManager.maytinh);
                /* serverNS = clientToHandle.GetStream();
                 serverSR = new StreamReader(serverNS);
                 serverSW = new StreamWriter(serverNS);*/
                receiveCommand = new Thread(ReceiveCommand);
                receiveCommand.IsBackground = true;
                receiveCommand.Start(clientToHandle);
            }
        }

    
        public void SetClienttoList(string FirstIP, string LastIP, string SubnetMask)
        {
            maytinhInfoManager = new MaytinhInfoManager(FirstIP, LastIP, SubnetMask);
            if (_onClientListChanged != null)
                _onClientListChanged(maytinhInfoManager.maytinh);   
        }

        /*public  MangMayTinh AddMayTinh(string FirstIP, string LastIP, string SubnetMask)
        {

            MayTinh.MayTinh mt;
            list = new ArrayList();
            list = this.InitIpRange(FirstIP, LastIP, SubnetMask);
            mangMayTinh = new MangMayTinh(list);
            return mangMayTinh;
        }*/
        
        
        public void HandleConnection()
        {

            TcpListener threadListener = listener;
            Socket clientToHandle = listener.AcceptSocket();
            ListClient.Add(clientToHandle);

            IPEndPoint remoteEP = (IPEndPoint) clientToHandle.RemoteEndPoint;
            string IP = remoteEP.Address.ToString();
         
            clientToHandle.Close();

        }



/*        private void ThreadSendMessage(object Data)
        {
            string temp = (string)Data;
            string IP = temp.Split('-')[0];
            string MessageToClient = temp.Split('-')[1];

            MayTinh.MayTinh mt = mangMayTinh.GetMayTinh(IP);

            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(mt.IP), mt.Port);
            TcpClient client = new TcpClient(ep);
            NetworkStream ns = client.GetStream();
            byte[] data = new byte[1024];
            data = Encoding.ASCII.GetBytes(MessageToClient);
            ns.Write(data, 0, data.Length);
            ns.Close();
            client.Close();
        }
*/


        /*public ArrayList InitIpRange(string FirstIP, string LastIP, string SubnetMask)
        {
            ArrayList listIP = new ArrayList();
            try
            {
                string s1 = "", s2 = "";
                int y = 0, x = 0, z = 0, t = 0;
                if (FirstIP != "")
                {
                    s1 = FirstIP.Substring(0, FirstIP.LastIndexOf("."));
                    x = int.Parse(FirstIP.Substring(FirstIP.LastIndexOf(".") + 1));
                }
                if (LastIP != "")
                {
                    s2 = LastIP.Substring(0, LastIP.LastIndexOf("."));
                    y = int.Parse(LastIP.Substring(LastIP.LastIndexOf(".") + 1));
                }
                t = y - x;
                if (SubnetMask != "")
                    z = 256 - int.Parse(SubnetMask.Substring(SubnetMask.LastIndexOf(".") + 1));
                if (x < 255 && y < 255 && s1.CompareTo(s2) == 0)
                    listIP = XuatIP(x, y, z);
                else
                    MessageBox.Show("Nhập sai");
            }
            catch
            {
                MessageBox.Show("Nhập IP sai");
            }
            return listIP;
        }*/

        /*      public ArrayList XuatIP(int batdau, int cuoi, int chieudai)
              {
                  ArrayList tam = new ArrayList();
                  for (int i = batdau; i < chieudai && i <= cuoi; i++)
                  {
                      string ip = "192.168.255." + i.ToString();
                      MayTinh.MayTinh temp = new MayTinh.MayTinh();
                      temp.IP = ip;
                      tam.Add(temp);
                  }
                  return tam;
              }*/
    }
}
