﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoughSpace
{
    class Numplay : Numeral
    {

        public void Display()
        {
            int i;

            for (i = 0; i < 10; i++)
            {
                Console.Write($"{array[i]}\t");
            }
            Console.WriteLine();
        }

        public void FindSumOfNumber()
        {
            Console.WriteLine($"\n The sum of numbers is :{array.Sum()}");
        }

        public void FindAverageOfNumber()
        {
            Console.WriteLine($"The average of numbers is : {array.Average()}");
        }

        public void FindMaximumOfNumber()
        {
            Console.WriteLine($"The maximum of numbers is : {array.Max()}");
        }

        public void FindMinimumOfNumber()
        {
            Console.WriteLine($"The minimum of numbers is : {array.Min()}");
        }

    }
}
