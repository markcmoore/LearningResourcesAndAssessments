using System;

namespace _19_DelegatesChallenge
{
    class Program
    {
        public delegate double PerformCalculation(double x, double y);

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            PerformCalculation perfCalc1 = Addition;
            perfCalc1+= Multiplication;
            perfCalc1 +=Subtraction;

            //create an inline method AKA anonymous method
            // perfCalc1 += delegate(double x, double y)
            // {
            //     System.Console.WriteLine($"In the anonymous method x = {x} and y= {y}");
            //     return 1;
            // };

            //use lambda expression form
            perfCalc1 += (double x, double y) => {
                System.Console.WriteLine($"In the anonymous method x = {x} and y= {y}");
                return 1;
            };
            System.Console.WriteLine(perfCalc1.ToString());
            //System.Console.WriteLine(perfCalc1(5.1, 10));

            //use this to get the return from each invoced method and do something with it. 
            foreach(PerformCalculation x in perfCalc1.GetInvocationList())
            {
                System.Console.WriteLine($"Each return => {x(4.5,5.5)}");
            }

            //send the multicast delegate to a method!
            GetADelegate(perfCalc1);


        }
        
        public static double Addition(double x, double y)
        {
            // System.Console.WriteLine($"Addition => {x+y}");
            return x+y;
        }

        public static double Subtraction(double x, double y)
        {
            // System.Console.WriteLine($"Subtraction => {x-y}");
            return x-y;
        }

        public static double Multiplication(double x, double y)
        {
            // System.Console.WriteLine($"Multiplication => {x*y}");
            return x*y;
        }

        public static void GetADelegate(PerformCalculation x)
        {
            foreach (PerformCalculation item in x.GetInvocationList())
            {
                System.Console.WriteLine($"THis is the delegate invoked in a method! => {item(3.3,4.4)}");
            }
        }

    }
}
