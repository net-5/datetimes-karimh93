using System;
using System.Globalization;


namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {

            //FirstExercise();
            //NYears();
            //HumanFriendly();
            //FiveSeconds();
            //MiliSeconds();
            //SixMonths();
            //LastSecond();
            //DiffInSeconds();
            //Age();
            //Thirty();
            //TwoDays();
            //Print();
            //FiveDays();
            //FirstMonday();
            //TwoDates();
            //Sunday();





        }
        static void FirstExercise()
        {

            //1.Write a program to display the:
            //a) Current date and time
            //b) Current year
            //c) Month of year
            //d) Week number of the year
            //e) Weekday of the week
            //f) Day of year
            //g) Day of the month
            //h) Day of week
            //j) if the current year is a leap year or not


            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.DayOfYear / 7);
            Console.WriteLine((int)DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Today.DayOfYear);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Today.DayOfWeek);
            Console.WriteLine(DateTime.IsLeapYear(2019));

        }



        //2.Write a program to add N year(s) to the current date and display the new date.

        static void NYears()
        {
            Console.WriteLine(DateTime.Now.AddYears(3));

        }

        //3.Write a program to display the date and time in a human-friendly string.
        static void HumanFriendly()
        {

            Console.WriteLine(DateTime.Now.ToString());
        }

        //4.Write a program to add 5 seconds to the current time and print it to the console.

        static void FiveSeconds()
        {

            Console.WriteLine(DateTime.Now.AddSeconds(5));

        }
        //5. Write a program to get current time in milliseconds.
        static void MiliSeconds()
        {

            Console.WriteLine(DateTime.Now.Ticks);
        }
        //6.Write a program that calculates the date six months from the current date.

        static void SixMonths()
        {

            Console.WriteLine(DateTime.Now.AddMonths(6));
        }

        //7.Write a program to get the first and last second of a day.

        static void LastSecond()
        {


            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.Today.AddDays(1).AddSeconds(-1));
        }

        //*8. Write a program to calculate two date difference in seconds.

        static void DiffInSeconds()
        {
            DateTime one = new DateTime(2019, 02, 02);
            DateTime two = new DateTime(2019, 02, 04);
            TimeSpan ts = two - one;
            Console.WriteLine(ts.TotalSeconds);


        }


        //9.Given a date of birth, calculate the age of a person.

        static void Age()
        {
            var bday = new DateTime(1993, 06, 02);
            int age = (int)((DateTime.Now - bday).TotalDays / 365.242199);
            Console.WriteLine(age);

        }


        //10.Write a program to get the dates 30 days before and after from the current date, and display it to the console
        static void Thirty()
        {

            Console.WriteLine(DateTime.Today.AddDays(30));
            Console.WriteLine(DateTime.Today.AddDays(-30));

        }
        //11.Write a program to calculate a number of days between two dates.

        static void TwoDays()
        {

            var date = new DateTime(2019, 02, 03);
            var diff = (int)(DateTime.Now - date).TotalDays;
            Console.WriteLine(diff);
        }

        //12.Write a program to print yesterday, today, tomorrow.
        static void Print()
        {


            Console.WriteLine(DateTime.Today.AddDays(-1));
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.Today.AddDays(1));
        }


        //13.Write program to print next 5 days starting from today.

        static void FiveDays()
        {

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(DateTime.Today.AddDays(i));
            }
        }

        //14.Write a program to find the date of the first Monday of a given week.




        public static void FirstMonday()
        {

            int weeks = 1;

            TimeSpan add = new TimeSpan(7 * weeks, 0, 0, 0);
            DateTime d = new DateTime(2019, 1, 1) + add;

            if (d.DayOfWeek != DayOfWeek.Monday)
            {
                var a=d.Subtract(new TimeSpan((int)d.DayOfWeek));

                Console.WriteLine(a);

            }
        }
        


        //15.Write a program to get days between two dates.
        static void TwoDates()
        {
            var a = DateTime.Today;
            var b = new DateTime(2018, 04, 05);
            var c = (int)(a - b).TotalDays;
            Console.WriteLine(c);
        }


        //16.Write a program to select all the Sundays of a specified year and display their dates

        static void Sunday()
        {

            DateTime beginDate = new DateTime(2018, 01, 01);
            DateTime endDate = new DateTime(2018, 12, 31);
            TimeSpan d = endDate - beginDate;
            int days = d.Days;

            for (var i = 0; i <= days; i++)
            {
                var anotherDate = beginDate.AddDays(i);

                if (anotherDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    Console.WriteLine(anotherDate);
                }

            }
        }
    }
}

