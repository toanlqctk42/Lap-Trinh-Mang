using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BT1_Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao ten mien : ");
            string arg = Console.ReadLine();
           /* foreach (String arg in args)
            {*/
                Console.WriteLine("phan giai ten mien: " + arg);
                GetHostInfo(arg);
            /*}*/
            Console.ReadKey();
        }
        static void GetHostInfo(string host)
        {
            try
            {
                IPHostEntry hostInfo = Dns.GetHostEntry(host);
                Console.WriteLine("Ten mien: " + hostInfo.HostName);
                Console.Write("Dia chi IP : ");
                foreach (IPAddress ipaddr in hostInfo.AddressList)
                {
                    Console.Write(ipaddr.ToString() + "");
                }
                Console.WriteLine();
            }
            catch (Exception)
            {

                Console.WriteLine("khong phan giai duoc ten mien: " + host + "" + "\n");
            }
        }
    }
}
