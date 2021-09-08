using System;

namespace As00
{
    public class Program
    {
        public static void Main(string[] args)
        {
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
            var input = Int32.Parse(Console.ReadLine());

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
}
