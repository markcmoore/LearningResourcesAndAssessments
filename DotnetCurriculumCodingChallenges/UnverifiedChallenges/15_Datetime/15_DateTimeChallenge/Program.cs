using System;

namespace _15_DateTimeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            string result = GetTomorrowsDate();
            System.Console.WriteLine($"Tomorrows date is {result}");

            //2
            result = GetTodaysDate();
            System.Console.WriteLine($"Todays date is {result}");

            //3
            DayOfWeek day1 = GetToday();
            System.Console.WriteLine($"Today is {day1}");

            //4
            int numDays = DaysInFeb();
            System.Console.WriteLine($"There are {numDays} in February, 2025");

            //5
            DateTime dob = GetDateOfBirth();
            numDays = DaysSinceBirth(dob);
            System.Console.WriteLine($"There have been {numDays} days since you were born.");


        }

        public static string GetTomorrowsDate()
        {
            //System.Console.WriteLine(DateTime.Now.AddDays(1).ToString("MM/dd/yyyy"));
            return DateTime.Now.AddDays(1).ToString("MM/dd/yyyy");

        }

        public static string GetTodaysDate()
        {
            //System.Console.WriteLine(DateTime.Now.AddDays(1).ToString("dd/MM/yyyy"));
            return DateTime.Now.AddDays(1).ToString("dd/MM/yyyy");
        }

        public static DayOfWeek GetToday()
        {
            //System.Console.WriteLine(DateTime.Now.AddDays(1).ToString("dd/MM/yyyy"));
            DateTime dt = new DateTime();
            System.Console.WriteLine(dt.DayOfWeek);
            
            return dt.DayOfWeek;
        }

        public static int DaysInFeb()
        {
            return DateTime.DaysInMonth(2025, 2);
        }

        public static DateTime GetDateOfBirth()
        {
            int month, day, year;
            bool goodInput;
            do{
                System.Console.WriteLine("Please enter your month of birth as a number 1-12");
                goodInput = int.TryParse(Console.ReadLine(), out month);
            }while(!goodInput || month>12 || month<1);

            do{
                System.Console.WriteLine("Please enter your day of birth as a number 1-31");
                goodInput = int.TryParse(Console.ReadLine(), out day);
            }while(!goodInput || day>31 || day<1);

            do{
                System.Console.WriteLine("Please enter your year of birth as a number 1919-2020");
                goodInput = int.TryParse(Console.ReadLine(), out year);
            }while(!goodInput || year>2020 || year<1919);

            DateTime date = new DateTime(year,month, day);
            return date;
        }

        public static int DaysSinceBirth(DateTime dob)
        {
            System.Console.WriteLine(dob);
            System.Console.WriteLine(DateTime.Today);
            return (DateTime.Today - dob).Days;
        }
    }
}
