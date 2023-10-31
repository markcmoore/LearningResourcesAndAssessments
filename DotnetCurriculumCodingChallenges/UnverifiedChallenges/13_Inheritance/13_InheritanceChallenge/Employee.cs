using System;

namespace _13_InheritanceChallenge
{
    public class Employee
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }   
        public int Salary { get; set; }

        /// <summary>
        /// This constructor is the default constructor and gives defualt values for the properties
        /// </summary>
        public Employee()
        {
            LastName = "Moore";
            FirstName = "Mark";
            Salary = 25000;
        }
        
        /// <summary>
        /// This constructor has 3 parameters for hte three properties
        /// </summary>
        /// <param name="LastName"></param>
        /// <param name="FirstName"></param>
        /// <param name="Salary"></param>
        public Employee(string LastName, string FirstName, int Salary)
        {
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.Salary = Salary;
        }

        /// <summary>
        /// THis method just prints to the console to identify the class amd method 
        /// </summary>
        public virtual void Work()
        {
            Console.WriteLine("I'm an employee working");
        }

        /// <summary>
        /// This method just prints to the console to identify the class amd method 
        /// </summary>
        public void Break()
        {
            Console.WriteLine("I'm taking a break. The Break() method in Employee is not overridden in dervied classes");
        }
        
    }
}