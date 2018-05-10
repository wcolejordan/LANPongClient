using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace NetworkedGame
{
    class GameCons
    {
        //Define variables
        Socket socketUdpRcv;
        Socket socketUdpSnd;
        String ipA { get; set; }
        String ipB { get; set; }
        int portA;
        int portB;

        public GameCons(int portA, int portB)
        {
            try
            {
                this.portA = portA;
                this.portB = portB;
                IPAddress IP = System.Net.IPAddress.Parse(Player.IP);//Get players IP
                IPEndPoint ClientEndPointRcv = new IPEndPoint(IP, portA); //Setting up end points
                IPEndPoint ClientEndPointSnd = new IPEndPoint(IP, portB); //Setting up end points
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
                System.Diagnostics.Debug.WriteLine(e);
            }

        }

        public void sendUDP(byte[] data)
        {
            try
            {
                //Send message to server
                IPEndPoint receiver = new IPEndPoint(IPAddress.Parse(Player.serverIP), portA);
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
                IPEndPoint sender = new IPEndPoint(IPAddress.Any, portB); //Setting sender details
                EndPoint receive = (EndPoint)(sender);
                byte[] data = new byte[1024]; //Initialize byte array for receive
                int rcv = socketUdpRcv.ReceiveFrom(data, ref receive); //receive data
                String dataString = Encoding.ASCII.GetString(data, 0, rcv); //Convert to string
                return dataString;//return
            }
            catch (Exception er)
            {
                //System.Diagnostics.Debug.WriteLine(er);
                return null;
            }
        }


        public void close() //Close sockets
        {
            socketUdpRcv.Close();
            socketUdpSnd.Close();
        }
    }
}
