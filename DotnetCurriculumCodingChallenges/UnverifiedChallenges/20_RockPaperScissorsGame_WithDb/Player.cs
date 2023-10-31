
using System;
using System.Collections.Generic;

namespace _20_RockPaperScissorsGame_NoDb
{
    public class Player
    {
      public int PlayerId { get; set; }
      public string Name { get; set; } = "null";
      public List<Game> games = new List<Game>();

    // Dictionary<> isn't supported in EF so you're going to have to just search the Games
    // table to count wins and losses.... OR change this Dictionary to properties.
    /*      public Dictionary<string,int> record = new Dictionary<string,int>()
          {
            {"wins", 0},
            {"losses", 0}
          };*/

    public int Wins { get; set; } = 0;//instead of the Dictionary above
    public int Losses { get; set; } = 0;
  }
}
