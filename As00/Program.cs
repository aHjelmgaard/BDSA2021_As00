using System;

namespace As00
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a year to find out if it's a leap year:");
            evaluateInput();
        }

        public static bool isLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 != 0 || year % 400 == 0)
                {
                    return true;
                }
                else 
                {
                    return false;
                }
            }
            else 
            {
                return false;
            }
        }

        public static void evaluateInput()
        {
            try
            {
                var input = Convert.ToInt32(Console.ReadLine());
                
                if (input < 1582)
                {
                    Console.WriteLine("Input year has to be 1582 or greater.");
                }
                else
                {
                    if (isLeapYear(input))
                    {
                        Console.WriteLine("yay");
                    }
                    else 
                    {
                        Console.WriteLine("nay");
                    }
                }
            }
            catch (FormatException FE)
            {
                Console.WriteLine("Invalid input: Input must be an integer greater than 1582.", FE);
            } 
        }
    }
}
