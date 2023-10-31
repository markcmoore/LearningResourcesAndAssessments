using System;

namespace _13_InheritanceChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee jimmy = new Employee("Jimmy", "Jones", 40000);

            jimmy.Work();
            jimmy.Break();

            Boss chuckNorris = new Boss("Tesla", "Norris", "Chuck", 999999999);

            chuckNorris.Lead();

            Trainee michelle = new Trainee(32, 8, "Gartner", "Michelle", 10000);
            michelle.Study();
            michelle.Work();
        }
    }
}
