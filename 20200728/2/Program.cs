using System;
using System.Net;
using System.Net.Sockets;

class Program
{
    static void Main(string[] args)
    {
        Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Server.Bind(new IPEndPoint(IPAddress.Any, 7000));
        Server.Listen(100);

        Socket Client = Server.Accept();
        Console.WriteLine("Client Incomming");

        byte[] Buffer = new byte[] { 65, 66, 67, 68 };
        Client.Send(Buffer); //텔넷이 아스키코드로 해석해서 ABCD로 출력


        Client.Close();
        Server.Close();
    }



}