﻿#region Copyright EazyLearn
//
// All rights are reserved. Reproduction or transmission in whole or in part, 
// in any form or by any means, electronic, mechanical or otherwise, is
// prohibited without the prior written consent of the copyright owner.
//
// Filename        : Person.cs
// Purpose         : To practice C# Array
// Creation Date   : 24-09-2021
// Author          : Sulfikkar E S
//
// Change History  :
// Changed by      :              
// Date            : 
// Purpose         :
//
#endregion Copyright EazyLearn

#region Included namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion 

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



   

             