
using System;
using System.Collections.Generic;

namespace _20_RockPaperScissorsGame_NoDb
{
    public class Player
    {
      public string Name { get; set; } = "null";
      public List<Game> games = new List<Game>();
      public Dictionary<string,int> record = new Dictionary<string,int>()
      {
        {"wins", 0},
        {"losses", 0}
      };
    }
}
