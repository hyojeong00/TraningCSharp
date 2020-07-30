using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClient aTcpClient = new TcpClient("127.0.0.1",7000);
            Console.WriteLine("♡클라이언트가 서버에 접속합니다♡");
            NetworkStream aNetworkStream = aTcpClient.GetStream();
            byte[] Buffer = Encoding.UTF8.GetBytes("나는 클라이언트 룰루");
            aNetworkStream.Write(Buffer, 0, Buffer.Length);
            Console.WriteLine("♡클라이언트가 전송한 DATA의 내용은 " + Encoding.UTF8.GetString(Buffer) + " 입니다♡");

            Buffer = new byte[1024];
            int BufferCount = aNetworkStream.Read(Buffer, 0, Buffer.Length);
            Console.WriteLine("♡서버가 전송한 DATA의 크기는 " + BufferCount + " 입니다♡");
            Console.WriteLine("♡서버가 전송한 DATA의 내용은 " + Encoding.UTF8.GetString(Buffer) + " 입니다♡");
 

            Console.WriteLine("♡클라이언트를 종료합니다♡");
            aNetworkStream.Close();
            aTcpClient.Close();
        }
    }
}
