using System;

namespace _13_InheritanceChallenge
{
    public class Boss : Employee
    {
        public string CompanyCar { get; set; }
        
        /// <summary>
        /// This constructor passes the inherited porperties through to the base class while 
        /// assigning the new property in the body of the constructor.
        /// </summary>
        /// <param name="CompanyCar"></param>
        /// <param name="LastName"></param>
        /// <param name="FirstName"></param>
        /// <param name="Salary"></param>
        /// <returns></returns>
        public Boss(string CompanyCar, string LastName, string FirstName, int Salary)
                :base(LastName, FirstName, Salary)
        {
            this.CompanyCar = CompanyCar;
        }

        /// <summary>
        /// This method just prints to the console what hte job of the person is and what their name is.
        /// </summary>
        public void Lead()
        {
            Console.WriteLine($"I'm the boss! My name is {FirstName} {LastName}");
        }
        
    }
}