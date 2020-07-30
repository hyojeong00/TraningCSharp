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
            TcpListener aTcpListener = new TcpListener(IPAddress.Parse("127.0.0.1"), 7000);
            aTcpListener.Start();
            Console.WriteLine("♡서버가 시작되었습니다♡");
            TcpClient aTcpClient = aTcpListener.AcceptTcpClient();
            Console.WriteLine("♡클라이언트가 접속되었습니다♡");
            aTcpListener.Stop();
            NetworkStream aNetworkStream = aTcpClient.GetStream();
            byte[] Buffer=new byte[1024];
         
            
            int BufferCount= aNetworkStream.Read(Buffer,0,Buffer.Length);
            Console.WriteLine("♡클라이언트가 전송한 DATA의 크기는 " +BufferCount+" 입니다♡");
            Console.WriteLine("♡클라이언트가 전송한 DATA의 내용은 " + Encoding.UTF8.GetString(Buffer) + " 입니다♡");
            Buffer = Encoding.UTF8.GetBytes("나는 서버서버 랄라");
            aNetworkStream.Write(Buffer, 0, Buffer.Length);
            Console.WriteLine("♡클라이언트로 회신한 DATA의 내용은" + Encoding.UTF8.GetString(Buffer) + " 입니다♡");

            Console.WriteLine("♡서버를 종료합니다♡");
            aNetworkStream.Close();
            aTcpClient.Close();
        }
    }
}
