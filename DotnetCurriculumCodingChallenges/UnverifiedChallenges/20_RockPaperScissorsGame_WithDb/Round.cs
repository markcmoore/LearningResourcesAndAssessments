using System;

namespace _20_RockPaperScissorsGame_NoDb
{
    public class Round
    {

      public int RoundId { get; set; }
      public Game Game_Id { get; set; }
      public Choice PlayerChoice { get; set; }
      public Choice ComputerChoice { get; set; }
      public Player winner { get; set; } = null;
    }
}
