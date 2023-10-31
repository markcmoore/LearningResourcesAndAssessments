using System;

namespace _14_MathClassRandomClassChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //test GetRandomNumber()
            int result = GetRandomNumber(6, 2);
            System.Console.WriteLine($"GetRandomNumber returns => {result}");
            // int result1 = GetRandomNumber(2, 2);
            // System.Console.WriteLine($"GetRandomNumber returns => {result}");

            //Test GetCeiling
            double x = 45.67;
            double y = 93.756;
            double z = GetCeiling(x,y);
            System.Console.WriteLine($"The return of GetCeiling() is => {z}");

            //Test GetSquareRoot()
            z = GetSquareRoot((int)x,(int)y);
            System.Console.WriteLine($"The return of GetSquareRoot() is => {z}");

            //Test MagicEightBall()
            string[] questions = new string[] 
                {
                    "Will this program work?",
                    "Must I really test this method?",
                    "Can I drink some whisky now?",
                    "Should I instead drink wine?",
                    "Can I wait till tomorrow?"
                };
            string answer = MagicEightBall(questions);
            System.Console.WriteLine($"Your answer is => {answer}");


        }

        /// <summary>
        /// This method returns a randomly chosen in from a range determined by the inputs.
        /// It throws an ArgumentException if the values are equal.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns type="int"></returns>
        public static int GetRandomNumber(int x, int y)
        {
            Random rand = new Random();//create a Random Class object
            if(x.CompareTo(y) < 0)
                return rand.Next(x,y);
            else if(x.CompareTo(y) > 0)
                return rand.Next(y,x);
            else
                throw new ArgumentException("x", $"The value {x} and {y} cannot be equal.");
        }

        /// <summary>
        /// This method takes two double values and returns the Ceiling of the square root of their sum.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static double GetCeiling(double x, double y)
        {
            return Math.Ceiling(Math.Sqrt(x+y));
        }

        /// <summary>
        /// The method takes two int values and returns the square root or the greater of the two.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static double GetSquareRoot(int x, int y)
        {
            int z = Math.Max(x,y);
            return Math.Sqrt(z);
        }

        /// <summary>
        /// This method simulates the Magic Eight Ball game in which you ask a 
        /// question and the method will respond with "yes", "no", "maybe", or "not yet".
        /// </summary>
        /// <param name="questions"></param>
        /// <returns></returns>
        public static string MagicEightBall(string[] questions)
        {
            int questionNum = GetRandomNumber(0,questions.Length);//get a random index number from 0 to length-1 of the array 
            System.Console.WriteLine(questions[questionNum]);
            int answer = GetRandomNumber(0,4);

            switch(answer)
            {
                case 0: return "YES!";
                case 1: return "NO!";
                case 2: return "...maaaaybe";
                case 3: return "Not yet.";
                default: return "something went wrong in the switch statement.";
            }
        }





    }//end of program
}//end of namespace
