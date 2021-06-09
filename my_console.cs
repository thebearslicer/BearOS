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
            string date_String = "today";

            switch (input)
            {
                case "cls":
                    Console.Clear();
                    break;
                case "time":
                    Console.WriteLine(date_String);
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
                case "exit":
                    System.Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Invalid Command");
                    break;
            }
        }
        public static string CreateTimeString()
        {
            byte byte_seconds = Cosmos.HAL.RTC.Second;
            byte byte_minutes = Cosmos.HAL.RTC.Minute;
            byte byte_hours = Cosmos.HAL.RTC.Hour;
            byte byte_date = Cosmos.HAL.RTC.DayOfTheMonth;          //Cosmos.HAL.RTC.whatever returns a byte of the time/day or whatever you put into it
            byte byte_day = Cosmos.HAL.RTC.DayOfTheWeek;
            byte byte_month = Cosmos.HAL.RTC.Month;
            byte byte_year = Cosmos.HAL.RTC.Year;

            string seconds = Convert.ToString(byte_seconds);       //use Convert.ToString to convert
                                                                    


                                                                   //put strings together to make something nice
        }
    }
    
}
