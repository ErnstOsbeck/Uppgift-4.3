﻿using System;

namespace uppgift_4._3
{
    class program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101;  i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.Read();
        }
    }
}