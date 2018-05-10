using System;

namespace NetworkedGame
{
    public class CurrentGames
    {
        //Game info
        public String playerA { get; private set;}
        public String playerB { get; private set;}
        public String versus { get; private set; }

        //Set players and make versus string
        public CurrentGames(String playerA, String playerB)
        {
            this.playerA = playerA;
            this.playerB = playerB;
            versus = playerA + " vs " + playerB;
        }
    }
}
