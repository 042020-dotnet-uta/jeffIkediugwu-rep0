using System;

namespace DemoProject
{
    class Program
    {
        static void Main(string[] args)

        {
            // variables to track how many sweet, salty and sweet’nSalty
            int threes = 0;
            int fives = 0;
            int threesAndFives = 0;

            // loop starting at 1 thru 100
            for (int i = 1; i <= 100; i++)
            {
                // checking if number is a multiple of three and five 
                if (i % 3 == 0 && i % 5 == 0)
                {
                    // increment variable if it is a multiple of three and five 

                    threesAndFives++;
                    Console.WriteLine(i + " " + "sweet’nSalty");
                }

                // checking if number is a multiple of five 

                else if (i % 5 == 0)
                {
                    // increment variable if it is a multiple of five 

                    fives++;
                    Console.WriteLine(i + " " + "salty");
                }

                // checking if number is a multiple of three 

                else if (i % 3 == 0)
                {
                    // increment variable if it is a multiple of three

                    threes++;
                    Console.WriteLine(i + " " + "sweet");

                }

            else
                    // default case to print numbers not matching the sweet, salty and sweet’nSalty condition
                    Console.WriteLine(i);

            }

            // prints how many sweet, salty and sweet’nSalty
            Console.WriteLine("Number of threes are: " + threes);
            Console.WriteLine("Number of fives are: " + fives);
            Console.WriteLine("Number of threes and fives are: " + threesAndFives);

        }

    }
}