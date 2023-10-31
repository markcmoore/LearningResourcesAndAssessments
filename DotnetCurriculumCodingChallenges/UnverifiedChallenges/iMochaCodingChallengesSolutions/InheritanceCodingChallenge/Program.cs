using System;

namespace InheritanceCodingChallenge
{
    public class Team
    {
        public string teamName { get; set; }
        public int noOfPlayers { get; set; }

        public Team(string teamName, int noOfPlayers)
        {
            this.teamName = teamName;
            this.noOfPlayers;
        }

        public bool AddPlayer(int count)
        {
            noOfPlayers += count;
        }

        public bool RemovePlayer(int count)
        {
            if (noOfPlayers -= count < 0)
            {
                return false;
            }
            else
            {
                noOfPlayers -= count;
                return true;
            }
        }

    }


    public class SubTeam : Team
    {
        public Team(string teamName, int noOfPlayers) : base(teamName, noOfPlayers) { }

        public ChangeTeamName(string name)
        {
            this.teamName = name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

/*
SELECT COUNT(PostId) AS UpVotes FROM Votes WHERE VoteTypeId = 2
GROUP BY PostId
ORDER BY COUNT(PostId) DESC LIMIT 20;
*/ 