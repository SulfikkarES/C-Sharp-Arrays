using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoughSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("\n\t\t *** Menu ***\n");
                Console.WriteLine(" \t 1 : Student Details" +
                    "\n\t 2 : Array in Ascending Order " +
                    "\n\t 3 : Disply Four By Four Identity Matrix" +
                    "\n\t 4: Product Of Two 2X2 Matrices " +
                    "\n\t 5 : Numerical Calculations " +
                    "\n\t 6 : Sorting Of Array Using Insertion Sort" +
                    "\n\t 7 : Alphabetically Sort Names" +
                    "\n\t 8 : String Reverse" +
                    "\n\t 9 : Substring Counter" + 
                    "\n\t 10 :Most Frequent Number ");
                Console.WriteLine("\nPleace Select Any Option : ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n 1 : Student Details \n\t*******\n");
                        DisplyStudentNameAndMark();
                        break;
                    case 2:
                        Console.WriteLine("\n 2 : Array in Ascending Order\n\t*****\n");
                        ArrangeArrayInAscendingOrder();
                        break;
                    case 3:
                        Console.WriteLine("\n 3 : Disply Four By Four Identity Matrix\n\t*****\n");
                        DisplyFourByFourIdentityMatrices();
                        break;
                    case 4:
                        Console.WriteLine("\n 4: Product Of Two 2X2 Matrices\n\t******\n");
                        MultiplyMatrix();                       ;
                        break;
                    case 5:
                        Console.WriteLine("\n 5 : Numerical Calculations\n\t******\n");
                        DoMathematicalAnalysis();
                        break;
                    case 6:
                        Console.WriteLine("\n 6 : Sorting Of Array Using Insertion Sort\n\t*****\n");
                        ImplementArraySortUsingInsertionSort();
                        break;
                    case 7:
                        Console.WriteLine("7 : Alphabetically Sort Names\n\t*****\n");
                        SortNamesInAlphabeticallly();
                        break;
                    case 8:
                        Console.WriteLine("\n 8 : String Reverse\n\t*****\n");
                        PrintStringInReverse();
                        break;
                    case 9:
                        Console.WriteLine("\n 9 : Substring Counter\n\t******\n");
                        FindASubstring();
                        break;
                    case 10:
                        Console.WriteLine("\n 10 :Most Frequent Number\n\t*****\n");
                        FindMostFreqentNumber();
                        break;
                    default:
                        Console.WriteLine(" Invalid Option Is Selected ");
                        break;
                }

            } while (choice != 0);
        } //main end here
        //*************************************************************************************
        //*************************************************************************************

        static void DisplyStudentNameAndMark()
        {
            int i;

            string[] student = { "Akhil", "Aravind", "Amal", "Rahul", "Shyam" };
            int[] mark = { 65, 68, 70, 72, 75 };
            
            for (i = 0; i <= 4; i++)
            {
                Console.WriteLine($"{student[i]} : {mark[i]}");
            }
            Console.ReadLine();
        }//End of DisplyStudentNameAndMark()
        //*************************************************************************************
        //*************************************************************************************

        static void ArrangeArrayInAscendingOrder()
        {
            int size, i, j, temp;

           
          
            Console.WriteLine("Enter Size Of An Array");
            size = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[size];
            Console.WriteLine($"\nArray Elements are : {size}");

            for (i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter Elements For Position: {i}");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < size; i++)
            {

                for (j = i + 1; j < size; j++)
                {
                    if (array[j] < array[i])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Console.WriteLine("\nArray Elements In Sorted Form Is");

            for (i = 0; i < size; i++)
            {
                Console.WriteLine($" : {array[i]}");
            }
            Console.ReadLine();
        }//End of ArrangeArrayInAscendingOrder()
         //*************************************************************************************
         //*************************************************************************************

        static void DisplyFourByFourIdentityMatrices()
        {
            int i, j;

            int[,] matrix = new int[4, 4] { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 1, 0 },{ 0, 0, 0, 1 } };
        
            for (i = 0; i < 4; i++)
            {

                for (j =0; j < 4; j++)
                {
                    Console.Write($"{matrix[i,j]}");
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }//End of DisplyFourByFourIdentityMatrices()
        //*************************************************************************************
        //*************************************************************************************

        static void MultiplyMatrix()
        {
            
            int[,] firstarr = new int[2, 2];
            int[,] secondarr = new int[2, 2];
            int[,] resultarr = new int[2, 2];
            int i, j, k;

            Console.WriteLine("\nFirst matrix\n");
            Console.WriteLine("\nEnter the elements for first matrix\n");

            for (i = 0; i < 2; i++)
            {

                for (j = 0; j < 2; j++)
                {
                    firstarr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\nFirst Matrix is:\n");

            for (i = 0; i < 2; i++)
            {

                for (j = 0; j < 2; j++)
                {
                    Console.Write($"{firstarr[i, j]} \t");
                }
                Console.WriteLine(); // First Matrix
            }
            Console.WriteLine("\nSecond matrix\n");
            Console.WriteLine("\nEnter elements for second matrix\n");
            
            for (i = 0; i < 2; i++)
            {

                for (j = 0; j < 2; j++)
                {
                    secondarr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\nSecond Matrix is:\n");

            for (i = 0; i < 2; i++)
            {

                for (j = 0; j < 2; j++)
                {
                    Console.Write($"{secondarr[i, j]} \t");
                }
                Console.WriteLine();
            }//Second Matrix 
                      
            for (i = 0; i < 2; i++)
            {

                for (j = 0; j < 2; j++)
                {
                    resultarr[i, j] = 0;

                    for (k = 0; k < 2; k++)
                    {
                        resultarr[i, j] += firstarr[i, k] * secondarr[k, j];
                    }
                }
            }
            Console.WriteLine("\nThe product of matrix is :\n");

            for (i = 0; i < 2; i++)
            {

                for (j = 0; j < 2; j++)
                {
                    Console.Write($"{resultarr[i, j]}  \t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }//End of MultiplyMatrix()
         //***********************************************************************************************
         //***********************************************************************************************   

        static void ImplementArraySortUsingInsertionSort()
        {
            int[] arr = new int[50];
            int limit,i;
            int j, value;

            Console.WriteLine("Enter the limit of array :");
            limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nThe enter the elements:\n");

            for ( i = 0; i < limit; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\nThe entered array is:\n");

            for (i = 0; i < limit; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine("\nSorted array :\n");

            for (i = 1; i < limit; i++)
            {
                value = arr[i];
                j = i - 1;

                while (j >= 0 && arr[j] > value)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = value ;
            }

            for (i = 0; i < limit; i++)
            {
                Console.Write($"{arr[i]}  \t");
            }
            Console.ReadLine();
        }//End of ImplementArraySortUsingInsertionSort()
         //***********************************************************************************************
         //*********************************************************************************************** 

        static void SortNamesInAlphabeticallly()
         {
            string[] names = new string[10];
            int i;

            Console.WriteLine("Enter the names:");

            for (i = 0; i < 10; i++)
            {
                names[i] = Console.ReadLine();
            }
            Console.WriteLine("\nSorted names are:");
            Array.Sort(names);
            
            foreach (string name in names)
            {
                Console.WriteLine($"{name}");
            }
            Console.ReadLine();
        }//End of SortNamesInAlphabeticallly()
         //***********************************************************************************************
         //*********************************************************************************************** 

        static void PrintStringInReverse()
        {
            string str;
            
            Console.WriteLine("Enter a string :");
            str = Console.ReadLine();
            Console.WriteLine($"Entered string is :  {str}");
            char[] array = str.ToCharArray();
            Array.Reverse(array);
            Console.WriteLine(new string(array));
            Console.ReadLine();
        } //End of PrintStringInReverse()
          //***********************************************************************************************
          //*********************************************************************************************** 

        static void FindASubstring()
        {
            int strlen, substrlen, result, i, j;
            string str;
            string substr;

            Console.WriteLine("Enter the string :");
            str = Console.ReadLine();
            Console.WriteLine("\nEnter the substring :");
            substr = Console.ReadLine();
            strlen = str.Length;
            substrlen = substr.Length;
            result = 0;

            for (i = 0; i <= strlen - substrlen; i++)
            {

                for (j = 0; j < substrlen; j++)
                {
                    if (str[i + j] != substr[j])
                    {
                        break;
                    }
                }
                if (j == substrlen)
                {
                    result++;
                    j = 0;
                }
            }
            Console.WriteLine($"\nThe substring :   {substr}   occurs   {result}   times\n");
            Console.ReadLine();
        }//End of FindASubstring()
         //***********************************************************************************************
         //*********************************************************************************************** 
         static void FindMostFreqentNumber()
         {
            int limit;
            int[] arr = new int[50];
            int maxcount, maxelement;
            int i, j;

            maxcount = 0;
            maxelement = 0;
            Console.WriteLine("Enter the limit of array :");
            limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Enter the Integer Number:\n");
            
            for (i = 0; i < limit; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\nThe entered array is:\n");

            for (i = 0; i < limit; i++)
            {
                Console.Write(arr[i] + "\t");
            }
                        
            for (i = 0; i < limit; i++)
            {
                int count = 1;
                for (j = i + 1; j < limit; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if (maxcount < count)
                {
                    maxcount = count;
                    maxelement = arr[i];
                }
            }
            Console.WriteLine($"\nMaximum element is :{ maxelement}   which occurs  {maxcount}   times \n");
            Console.ReadLine();
        }//End of FindMostFreuqentNumber()
         //***********************************************************************************************
         //*********************************************************************************************** 
         static void DoMathematicalAnalysis()
         {
            Numplay obj = new Numplay();

            obj.ArrayNumbers();
            obj.Display();
            obj.FindSumOfNumber();
            obj.FindAverageOfNumber();
            obj.FindMaximumOfNumber();
            obj.FindMinimumOfNumber();
            Console.ReadKey();

         }

    }

}


 








