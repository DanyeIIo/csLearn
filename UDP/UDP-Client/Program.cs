using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UDP_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            const string ip = "127.0.0.1";
            const int port = 8080;

            var udpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);

            var udpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            udpSocket.Bind(udpEndPoint);

            while (true)
            {
                Console.WriteLine("Input message");
                var message = Console.ReadLine();

                var serverEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8087);
                udpSocket.SendTo(Encoding.UTF8.GetBytes(message), serverEndPoint);

                var buffer = new byte[256];
                var size = 0;
                var data = new StringBuilder();
                EndPoint senderEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8087);
                do
                {
                    size = udpSocket.ReceiveFrom(buffer, ref senderEndPoint);
                    data.Append(Encoding.UTF8.GetString(buffer));
                }
                while (udpSocket.Available > 0);

                Console.WriteLine(data);
                Console.ReadLine();
                //udpSocket.Send(Encoding.UTF8.GetBytes(message));
            }
        }
    }
}
