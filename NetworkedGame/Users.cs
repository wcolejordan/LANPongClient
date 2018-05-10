using System;

namespace NetworkedGame
{
    public class Users
    {
        //User information
        public string IP { get; private set;}
        public string alias { get; private set; }

        public Users(String IP, String alias)
        {
            //user setup
            this.IP = IP;
            this.alias = alias;
        }        
    }
}
