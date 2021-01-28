using System;
using System.Collections.Generic;

namespace FibInCSharp
{
    class Program
    {
        static List<int> initializeFibs()
        {
            List<int> fibs = new List<int>();
            fibs.Add(0);
            fibs.Add(1);
            fibs.Add(1);
            return fibs;
        }

        static List<int> findFibs(int howMany)
        {
            List<int> fibs = initializeFibs();

            int index = 2;

            while (index < howMany)
            {
                fibs.Add(fibs[index] + fibs[index - 1]);
                index++;
            }
            return fibs;
        }

        public static void printFibs(int howMany)
        {
            List<int> fibs = findFibs(howMany);
            for (int i = 0; i < howMany; i++)
            {
                Console.WriteLine(fibs[i]);
            }
        }
        static void Main(string[] args)
        {
            bool isANum = false;
            int numberOfFibs = 0;
            Console.WriteLine("How many?");
            string stringNums = Console.ReadLine();
            isANum = int.TryParse(stringNums, out numberOfFibs);

            if (isANum)
            {

               printFibs(numberOfFibs);

            }
            else
            {
                Console.WriteLine("That wasn't a number, stupid");
            }
            Console.ReadLine();
        }
    }
}
