using System;
using System.Collections.Generic;
using System.Text;

namespace CosmosOS
{
    class my_console
    {
        public static void input()
        {
            Console.Write(">");
            var input = Console.ReadLine();

            double calcAnswer;


            switch (input)
            {
                case "cls":
                    Console.Clear();
                    break;
                case "time":
                    Console.WriteLine(CreateTimeString());
                    break;
                case "calc":
                    try
                    {
                        calcAnswer = calculator.Calculator();
                        Console.Write("Answer:");                               //switch statement console
                        Console.WriteLine(calcAnswer);
                    }
                    catch
                    {
                        Console.WriteLine("\nError in calculator\n");
                    }
                    break;
                case "shutdown":
                    System.Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Invalid Command");
                    break;
            }
        }
        public static string CreateTimeString()
        {

            string dayOfTheWeek;


            //byte byte_seconds = Cosmos.HAL.RTC.Second;
            //byte byte_minutes = Cosmos.HAL.RTC.Minute;
            //byte byte_hours   = Cosmos.HAL.RTC.Hour;
            byte byte_date    = Cosmos.HAL.RTC.DayOfTheMonth; //Cosmos.HAL.RTC.whatever returns a byte of the time/day or whatever you put into it
            //byte byte_day     = Cosmos.HAL.RTC.DayOfTheWeek;
            byte byte_month   = Cosmos.HAL.RTC.Month;
            byte byte_year    = Cosmos.HAL.RTC.Year;

            int int_date = (int)byte_date;
            int int_month = (int)byte_month;
            int int_year = (int)byte_year;

            dayOfTheWeek = GetDayOfTheWeek(int_month, int_date, int_year);

            //string seconds    = byte_seconds.ToString();
            //string minutes    = byte_minutes.ToString();
            //string hours      = byte_hours.ToString();
            //string date       = byte_date.ToString();
            //string day        = byte_day.ToString();
            //string month      = byte_month.ToString();
            //string year       = byte_year.ToString();
            //put strings together to make something nice
            string final_string = "It is " + dayOfTheWeek + ", " + Cosmos.HAL.RTC.Month + "/" + Cosmos.HAL.RTC.DayOfTheMonth + "/" + Cosmos.HAL.RTC.Year + " at " + Cosmos.HAL.RTC.Hour + ":" + Cosmos.HAL.RTC.Minute + ":" + Cosmos.HAL.RTC.Second;
            return final_string;

        }
        public static string GetDayOfTheWeek(int month, int day, int year)
        {

            string day_string;

            if (month < 3)
            {
                day += year;
                year--;
            }
            else
            {
                day = day + year - 2;
            }

            int day_value = (23 * month / 9) + day + 4 + year / 4 - year / 100 + year / 400;
            day_value = day_value % 7;

            switch(day_value)
            {
                case 0:
                    day_string = "Sunday";
                    break;
                case 1:
                    day_string = "Monday";
                    break;
                case 2:
                    day_string = "Tuesday";
                    break;
                case 3:
                    day_string = "Wednesday";
                    break;
                case 4:
                    day_string = "Thursday";
                    break;
                case 5:
                    day_string = "Friday";
                    break;
                case 6:
                    day_string = "Saturday";
                    break; ;
                default:
                    day_string = "Error";
                    break;
            }
            return day_string;
             
                

           
        }
    }

}