using System;
using System.Collections.Generic;
using System.Text;

namespace CosmosOS
{
    public class calculator                         //Add exponent function, other than that, don't change anything it works (I swear)
    {
        public static int Calculator()
        {
            int answer = 0;
            string user_Command;

            Console.WriteLine("--------------------\n");
            Console.WriteLine("Welcome to Calculator\n");
            Console.WriteLine("--------------------\n");

            Console.WriteLine("First Number?\n");
            user_Command = Console.ReadLine();
            int num1 = int.Parse(user_Command);
            Console.WriteLine("\nSecond Number?");
            user_Command = Console.ReadLine();
            int num2 = int.Parse(user_Command);
            Console.WriteLine("\nOperator?");
            string op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    answer = num1 + num2;
                    break;

                case "-":
                    answer = num1 - num2;
                    break;

                case "*":
                    answer = num1 * num2;
                    break;

                case "/":
                    answer = Divide(num1, num2);
                    break;

                case "%":
                    answer = num1 % num2;
                    break;

                default:
                    Console.WriteLine("Invalid Operator");
                    break;
            }
            return answer;
        }
        public static int Divide(int num1, int num2)
        {
            int quotient = 0;

            if (num2 == 0)
            {
                Console.WriteLine("Cannot divide by 0");
                return 0;
            }

            int sign = 1;
            if (num1 * num2 < 0)
            {
                sign = -1;
            }

            num1 = Math.Abs(num1); num2 = Math.Abs(num2);

            while (num1 >= num2)
            {
                num1 -= num2;
                quotient++;
            }
            Console.Write("Remainder:");
            Console.WriteLine(num1);

            return sign * quotient;
        }
    }
}
