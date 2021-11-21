using System;
using System.Collections.Generic;
namespace CollatzSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me arbitrary positive integer:");
            int startNumber = Convert.ToInt32(Console.ReadLine());
            CollatzClass Test = new CollatzClass(startNumber);
            Test.Collatz(startNumber);
        }

    }
    public class CollatzClass
    {
        public int NumberStart { get; set; }
        public CollatzClass(int startNumber)
        {
            NumberStart = startNumber;
        }
        public void Collatz(int startNumber)
        {
            if (startNumber % 2 == 0)
            {
                int NumberStart = startNumber / 2;
                Console.WriteLine(NumberStart);
                if (NumberStart != 1)
                {
                    Collatz(NumberStart);
                }
            }
            else
            {
                int NumberStart = (startNumber * 3) + 1;
                Console.WriteLine(NumberStart);
                if (NumberStart != 1)
                {
                    Collatz(NumberStart);
                }
            }
        }
    }
}
