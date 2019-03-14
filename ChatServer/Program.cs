using System;
using System.Threading.Tasks;

namespace ChatServer
{
    using System.Net.Sockets;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            while (true)
            {
                TcpClient client = Server.AcceptClient().Result;
                ChatRoom.HandShake(client);
            }
        }
    }
}
