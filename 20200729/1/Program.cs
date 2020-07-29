using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        //Server.Bind(new IPEndPoint(IPAddress.Any, 7000));
        Server.Bind(new IPEndPoint(IPAddress.Parse("192.168.0.106"), 7000)); //아이피 고정 할당
        Server.Listen(100);

        Socket Client = Server.Accept();
        Console.WriteLine("Client Incomming");

        byte[] Buffer = new byte[1024];  //Blocking method 흐름이 막혀있는 상태 

     
        Client.Receive(Buffer); //상대방이 안보내면 블로킹됨 //받은 바이트 수 반환
        int Number = Client.Receive(Buffer);
        Console.WriteLine(Number);
        Encoding.UTF8.GetString(Buffer, 0, Number); //수신된 데이터를 출력할 수 있는 형태로 변환


        Buffer = Encoding.UTF8.GetBytes("행복하자 꼭");
        Client.Send(Buffer); //텔넷이 아스키코드로 해석해서 ABCD로 출력


        Client.Close();
        Server.Close();
    }



}