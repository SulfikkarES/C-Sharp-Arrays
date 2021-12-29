using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoughSpace
{
    public class Numeral
    {
        protected int[] array = new int[10]; 

        public void ArrayNumbers()
        {
            int i;

            Console.WriteLine("\nThe enter the elements:");

            for (i = 0; i < 10; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}



   

             