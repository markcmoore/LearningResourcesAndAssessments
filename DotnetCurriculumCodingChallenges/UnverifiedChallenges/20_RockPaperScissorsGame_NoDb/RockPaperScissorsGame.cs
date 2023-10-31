using System;
using System.Collections.Generic;
using System.Linq;

namespace _20_RockPaperScissorsGame_NoDb
{
  public enum Choice
    {
      ROCK,
      PAPER,
      SCISSORS
    }

  class Program
  {
      static void Main(string[] args)
      {
          //maybe have a "stats method to print out the games????

          // Console.WriteLine("Hello World!");
          //3 lists initialize here.
          List<Player> players = new List<Player>();
          List<Game> games = new List<Game>();
          List<Round> rounds = new List<Round>();
          Random rand = new Random();

          Player computer = new Player()// create the computer
          {
            Name = "computer"
          };
          players.Add(computer);//add the computer as the first player.

          string input;//to get the users unput in the do/while loop
          int numInput = 0;//the number the user chose.
          do
          {
            do//loop to get the correct input
            {
              System.Console.WriteLine("\nPlease enter 1 or 2 to make a choice to Play or quit.\nYou can even enter 3 to check out this compilations stats.");
              System.Console.WriteLine("\t1 - Play\n\t2 - Quit");
              input = Console.ReadLine();
              bool result = int.TryParse(input, out numInput);
              // prompt for the correct input
              if(!result)
              {
                System.Console.WriteLine("\n\tThat input wasn't even a number. Try again...\n");
                continue;
              }

              if(numInput != 1 && numInput != 2)
              {
                Console.BackgroundColor = ConsoleColor.Cyan;
                System.Console.WriteLine($"\n\tYour input, {input}, is not 1 or 2.");
                Console.BackgroundColor = ConsoleColor.Black;
                System.Console.WriteLine();
              }
            }while(numInput != 1 && numInput != 2);

            if (numInput == 2)  { break;  }//quit the game.

            Game game = new Game();//instantiate a game

            System.Console.WriteLine("What is your name?");
            string p1Name = Console.ReadLine();

            Player player1 = new Player();// make the player instance
            foreach (var player in players)// see if this is a returning player to use the same player history.
            {
              if(player.Name.CompareTo(p1Name) == 0)
              {
                player1 = player;
                System.Console.WriteLine("Looks Like you are a returning player! Game on!");
              }
            }

            if(player1.Name == "null")//this is a new player. add him to the List LATER
            {
              player1.Name = p1Name;

            }

            //now run the game rounds till one player has 2 wins.
            do
            {
              Round round = new Round();//instantiate a round

              //get a choice for the computer and add that choice to the round
              round.PlayerChoice = (Choice)rand.Next(3);
              // System.Console.WriteLine($"The rounds PlayerChoice is {round.PlayerChoice}");
              //get a choice for the player and add that choice to the round
              round.ComputerChoice = (Choice)rand.Next(3);
              // System.Console.WriteLine($"The rounds ComputerChoice is {round.ComputerChoice}");

              // compare the choices
              if (round.PlayerChoice == round.ComputerChoice)
              {
                System.Console.WriteLine("This round was a tie");//make sure to
              }
              else if (round.PlayerChoice == Choice.ROCK && round.ComputerChoice == Choice.SCISSORS
                    || round.PlayerChoice == Choice.PAPER && round.ComputerChoice == Choice.ROCK
                    || round.PlayerChoice == Choice.SCISSORS && round.ComputerChoice == Choice.PAPER)
              {
                round.winner = player1;// add winner to the round
              }
              else
                { round.winner = computer;  }// add winner to the round

              // add the round to the round.
              // System.Console.WriteLine("adding a round to rounds");
              game.rounds.Add(round);
              //notify the player of who won
              List<Round> p1Wins = game.rounds.FindAll(x => x.winner == player1);//get a list of players winning rounds
              List<Round> p2Wins = game.rounds.FindAll(x => x.winner == computer);//get a list of computers winning rounds

              if (p1Wins.Count == 2)
              {
                // System.Console.WriteLine("In p1Wins.Count check");
                game.Winner = 1;
                player1.record["wins"]++;
                computer.record["losses"]++;
                game.p1 = player1;
                game.p2 = computer;
                player1.games.Add(game);
                computer.games.Add(game);
                games.Add(game);
              }
//make this an else if later
              if (p2Wins.Count == 2)
              {
                // System.Console.WriteLine("In p2Wins.Count check");
                game.Winner = 2;
                computer.record["wins"]++;
                player1.record["losses"]++;
                game.p1 = player1;
                game.p2 = computer;
                player1.games.Add(game);
                computer.games.Add(game);
                games.Add(game);
              }

              Player foundPlayer = players.Where(player => player.Name == player1.Name).FirstOrDefault();//this is a different way to find if a certain thing is in a list.
              if (foundPlayer == null)
              {
                players.Add(player1);//it would probably be better add the player when originlly searching for it. Then update it here.
              }

            }while (game.Winner == 0);//rounds loop

            //test that everything went ok...
            System.Console.WriteLine($"\n\tThis is the Game printout\n \t\tgame.Winner => {game.Winner}, \n\t\tP1 name =>{game.p1.Name}, \n\t\tComputer name => {game.p2.Name}.\n");
            int roundNum = 0;
            foreach (var item in game.rounds)
            {
              roundNum++;
              if(item.winner == null)
              {
                System.Console.WriteLine($"Round {roundNum} was a tie");
              }
              else{
                System.Console.WriteLine($"For round {roundNum}, Player chose =>{item.PlayerChoice} and Computer chose {item.ComputerChoice}.\nThe winner was {item.winner.Name}");
              }
            }
          }while(numInput !=2 );//gave loop

            foreach (var player in players)
            {
                System.Console.WriteLine($"{player.Name}\t{player.record["wins"]}\t{player.record["losses"]}");
                // foreach (var game in player.games)
                // {
                //     System.Console.WriteLine($"{game.}\t\t{}\t\t{}\t\t{}\t\t{}\t\t");
                // }
            }
        }
    }
}
