﻿using System;

namespace InClassWeek3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isTrue;

            isTrue = true;

            if (isTrue)
            {
                Console.Write("Hello ");
                Console.Write("World!");
            }

            int num1 = 30;

            if (num1 > 30)
            {
                Console.WriteLine("num1 is greater than 30");
            }
            else
            {
                if (num1 < 30)
                {
                    Console.WriteLine("num1 is less than 30");
                }
                else
                {
                    Console.WriteLine("num1 is equal to 30");
                }
            }
            


            int grade = 34;
            if (grade >= 90)
            {
                Console.WriteLine("A");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("B");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("C");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("D");
            }
            else if (grade > 0)
            {
                Console.WriteLine("F");
            }
            else
            {
                Console.WriteLine("Invalid grade");
            }


            int counter = 10;

            while (counter > 0)
            {
                Console.WriteLine(counter);
                counter = counter - 2;
            }
        }
    }
}
