using System;
using System.Collections.Generic;

namespace _20_RockPaperScissorsGame_NoDb
{
    public class Game
    {
      public Player p1 { get; set; }
      public Player p2 { get; set; }
      public int Winner { get; set; } = 0;
      public List<Round> rounds = new List<Round>();
    }
}
