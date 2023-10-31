using System;
using System.Collections.Generic;

namespace _20_RockPaperScissorsGame_NoDb
{
    public class Game
    {
      public int GameId { get; set; }
      public Player p1 { get; set; }//p1 is the user
      public Player p2 { get; set; }//p2 is the computer
      public Player Winner { get; set; }//changed from NoDb version. it was an int.
      public List<Round> rounds = new List<Round>();
    }
}
