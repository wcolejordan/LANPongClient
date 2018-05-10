using System;
using System.Linq;
using System.Net.NetworkInformation;

namespace NetworkedGame
{
    public static class Player
    {
        //defining static variables
        public static String IP { get; private set; }
        public static String alias { get; private set; }
        public static String serverIP { get; private set; }

        public static void setIP()
        {
            //Support for different adapter names
            var local = NetworkInterface.GetAllNetworkInterfaces().Where(i => i.Name == "Local Area Connection" || i.Name == "Local Area Connection 2" || i.Name == "Local Area Connection 3" || i.Name == "Ethernet" || i.Name == "Local Area Network").FirstOrDefault();
            if (local.GetIPProperties().UnicastAddresses[0].Address.ToString().Length <= 15)//checks if IPv6
            {
                IP = local.GetIPProperties().UnicastAddresses[0].Address.ToString(); 
            }
            else //If [0] is IPv6 [1] will be IPv4
            {
                IP = local.GetIPProperties().UnicastAddresses[1].Address.ToString();
            }
        }

        public static void setServerIP(String server)
        {
            serverIP = server; //setting server IP
        }

        public static void setAlias(String newAlias)
        {
            alias = newAlias; //setting alias
        }

    }
}
