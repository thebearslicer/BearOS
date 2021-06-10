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
            //byte byte_seconds = Cosmos.HAL.RTC.Second;
            //byte byte_minutes = Cosmos.HAL.RTC.Minute;
            //byte byte_hours   = Cosmos.HAL.RTC.Hour;
            //byte byte_date    = Cosmos.HAL.RTC.DayOfTheMonth; //Cosmos.HAL.RTC.whatever returns a byte of the time/day or whatever you put into it
            //byte byte_day     = Cosmos.HAL.RTC.DayOfTheWeek;
            //byte byte_month   = Cosmos.HAL.RTC.Month;
            //byte byte_year    = Cosmos.HAL.RTC.Year;

            //string seconds    = byte_seconds.ToString();
            //string minutes    = byte_minutes.ToString();
            //string hours      = byte_hours.ToString();
            //string date       = byte_date.ToString();
            //string day        = byte_day.ToString();
            //string month      = byte_month.ToString();
            //string year       = byte_year.ToString();
            //put strings together to make something nice
            string final_string = "It is " + Cosmos.HAL.RTC.DayOfTheWeek + ", " + Cosmos.HAL.RTC.Month + " " + Cosmos.HAL.RTC.DayOfTheMonth + " "  + Cosmos.HAL.RTC.Year + " at " + Cosmos.HAL.RTC.Hour + ":" + Cosmos.HAL.RTC.Minute + ":" + Cosmos.HAL.RTC.Second;
            return final_string;
                                                                                                                               
        }
    }
    
}
