using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = 0;

            try
            {
                Console.WriteLine("Put in a number!");
                input = double.Parse(Console.ReadLine()); //Parses from string to double
            }
            catch(Exception e) //If string can not be parsed to double
            {
                Console.WriteLine("Input is not a number! " + e);
            }
            finally //Always runs after the try and / or catch
            {
                Console.WriteLine(input + "\n");
            }

            Console.WriteLine("Put in a decimal!");
            double.TryParse(Console.ReadLine(), out input); //Tryparses string to double, doesnt need a try statement
            if ((input % 1) > 0) //Checks if input is a decimal
            {
                Console.WriteLine("Input is a decimal");
            }
            else
                throw new Exception("Input is not a decimal"); //Crashes the program with the specified exception
        }
    }
}
