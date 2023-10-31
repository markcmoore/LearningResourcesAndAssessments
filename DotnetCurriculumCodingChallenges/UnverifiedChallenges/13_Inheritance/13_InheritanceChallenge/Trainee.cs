using System;

namespace _13_InheritanceChallenge
{
    public class Trainee : Employee
    {
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }

        /// <summary>
        /// constructor that passes inherited property values to the base Class for instantiation.
        /// </summary>
        /// <param name="workingHours"></param>
        /// <param name="schoolHours"></param>
        /// <param name="name"></param>
        /// <param name="firstName"></param>
        /// <param name="salary"></param>
        /// <returns></returns>        
        public Trainee(int WorkingHours, int SchoolHours, string name, string firstName, int salary) : base(name, firstName, salary)
        {
            this.WorkingHours = WorkingHours;
            this.SchoolHours = SchoolHours;
        }

        /// <summary>
        /// This overrides the Work() method from Employee
        /// </summary>
        public override void Work()
        {
            Console.WriteLine($"I'm a trainee and I work for {WorkingHours} hours per week");
        }

        /// <summary>
        /// This is a new method in this derived class.
        /// This method 
        /// </summary>
        public void Study() // tells how many hours they work and study
        {
            Console.WriteLine($"I'm a trainee and I study for {SchoolHours} hours per week!");
        }
        
    }
}