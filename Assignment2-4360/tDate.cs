using System;

namespace Assignment2_4360
{
    class tDate
    {
        string earliestDate;
        string latestDate;
        public static int Day;
        public static int Month;
        public static int Year;
        public static int US;
        public static int E;



        static void  askForDate (ref int Day, ref int Month, ref int Year)
        {
            Console.WriteLine("Enter the Date");
            string dateInput = Console.ReadLine();

            string[] askForDate = dateInput.Split('/','/');
            Day = int.Parse(askForDate[0]);
            Month = int.Parse(askForDate[1]);
            Year = int.Parse(askForDate[2]);
        }
        static void dateValidity(ref int Month, ref int Day, ref int Year)
        {
            if(Month < 0)
            {
                Console.WriteLine("Invalid Month");
            }
            if (Day >= 31)
            {
                Console.WriteLine("Invalid Day");
            }
            if (Year > 0)
            {
                Console.WriteLine("Invalid Year");
            }
        }

        static void showDate (ref int Month, ref int Day, ref int Year,ref int US, ref int E)
        {
            Console.WriteLine("Choose date format");

        }

        }


    }

