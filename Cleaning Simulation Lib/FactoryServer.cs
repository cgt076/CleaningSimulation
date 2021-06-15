using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Cleaning_Simulation_Lib
{
    // public event RecvStsEndPtEventHandler RecvedStsEndPt;
    public class FactoryServer
    {
        public string IP { get; }
        public int Port { get; }
        public FactoryServer(string ip, int port)
        {
            IP = ip;
            Port = port;
        }
        Socket sock;
        delegate void StartDele();
        public void StartAsync()
        {
            StartDele dele = Start;
            dele.BeginInvoke(null, null);
        }

        private void Start()
        {
            sock = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp);
            IPAddress addr = IPAddress.Parse(IP);
            IPEndPoint ep = new IPEndPoint(addr, Port);
            sock.Bind(ep);
            sock.Listen(5);
            AcceptLoop();
        }

        private void AcceptLoop()
        {
            while (true)
            {
                Socket dosock = sock.Accept();
                DoIt(dosock);
            }
        }

        private void DoIt(Socket dosock)
        {
            byte[] packet = new byte[128];
            dosock.Receive(packet);
            MemoryStream ms = new MemoryStream(packet);
            BinaryReader br = new BinaryReader(ms);
            MsgType msgtype = (MsgType)br.ReadInt32();
            switch (msgtype)
            {
                case MsgType.MSG_MF_ADDSI:SetAddressProc(br); break;
            }
            br.Close();
            ms.Close();
            dosock.Close();
        }

        private void SetAddressProc(BinaryReader br)
        {
            string ip = br.ReadString();
            int port = br.ReadInt32();
            IPAddress addr = IPAddress.Parse(ip);
            
        }
    }
}
