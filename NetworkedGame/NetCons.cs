using System;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace NetworkedGame
{
    public class NetCons
    {
        //define variables
        private static NetCons instance = null;
        Socket socketUdpRcv;
        Socket socketUdpSnd;
        String ipA { get; set; }
        String ipB { get; set; }

        //Singleton implementation, returns or creates instance
        public static NetCons getInstance() 
        {
            if (instance == null)
            {
                instance = new NetCons();
            }
            return instance;
        }

        private NetCons()
        {
            try
            { 
                IPAddress IP = IPAddress.Parse(Player.IP); //Get and parse player IP
                IPEndPoint ClientEndPointRcv = new IPEndPoint(IP, 10002); //Setting up end points
                IPEndPoint ClientEndPointSnd = new IPEndPoint(IP, 10012); //Setting up end points
                //Initialize sockets
                socketUdpRcv = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                socketUdpSnd = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                socketUdpRcv.Blocking = false;
                socketUdpSnd.Blocking = false;
                socketUdpRcv.Bind(ClientEndPointRcv);
                socketUdpSnd.Bind(ClientEndPointSnd);
            } 
            catch (Exception e)
            {
                //System.Diagnostics.Debug.WriteLine(e.InnerException);
            }
            
        }

        public void sendUDP(byte[] data)
        {
            try
            {
                //set endpoint and send
                EndPoint receiver = new IPEndPoint(IPAddress.Parse(Player.serverIP), 10001);
                socketUdpSnd.SendTo(data, receiver);
            }
            catch (SocketException er)
            {
               // System.Diagnostics.Debug.WriteLine(er.ErrorCode);
            }
        }

        public void broadcastUDP(byte[] data)
        {
            try
            {
                //create broadcast address from current IP
                String[] lastBits = Player.IP.Split('.');
                String broadcastAddress = Player.IP.Remove(Player.IP.Length - lastBits[3].Length);
                broadcastAddress += "255";
                //set broadcast address as endpoint and send message
                IPEndPoint receiver = new IPEndPoint(IPAddress.Parse(broadcastAddress), 10001);
                socketUdpSnd.SendTo(data, receiver);
            }
            catch (Exception er)
            {
               // System.Diagnostics.Debug.WriteLine(er);
            }
        }

        public String rcvUDP()
        {
            try
            {
                IPEndPoint sender = new IPEndPoint(IPAddress.Any, 10011); //Setting sender details
                EndPoint receive = (EndPoint)(sender); //Set endpoint
                byte[] data = new byte[1024]; //Initialize byte array
                int rcv = socketUdpRcv.ReceiveFrom(data, ref receive); //receive message
                String dataString = Encoding.ASCII.GetString(data, 0, rcv); //convert to string
                return dataString; //return
            }
            catch (Exception er)
            {
               // System.Diagnostics.Debug.WriteLine(er);
                return null;
            }
        }


        public void close()
        {
            //close sockets
            socketUdpRcv.Close();
            socketUdpSnd.Close();
        }
    }
}
