using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace assrtionsort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] srtd_aray = { 0, 2, 3, 4, 5, 6, 14, 18, 29, 200 };
            int[] revrest_array = { 200, 29, 18, 14, 6, 5, 4, 3, 2, 0 };
            int[] rnd_array = { 200, 1, 4, 19, 23, 0, 6, 77, 33, 11 };
            int[] dublicates_arrau = { 0, 1, 2, 55, 55, 33, 33, 10, 10, 111 };
            Console.Write(" array before: ");
            PrintArray(srtd_aray);
            InsertionSort(srtd_aray);

            Console.Write(" array after: ");
            PrintArray(srtd_aray);
            Console.WriteLine();


            Console.Write(" array before: ");
            PrintArray(revrest_array);
            InsertionSort(revrest_array);

            Console.Write(" array after: ");
            PrintArray(revrest_array);
            Console.WriteLine();

            Console.Write(" array before: ");
            PrintArray(rnd_array);
            InsertionSort(rnd_array);

            Console.Write(" array after: ");
            PrintArray(rnd_array);
            Console.WriteLine();


            Console.Write(" array before: ");
            PrintArray(dublicates_arrau);
            InsertionSort(dublicates_arrau);

            Console.Write(" array after: ");
            PrintArray(dublicates_arrau);
            Console.WriteLine();

            Console.ReadKey();
        }

        private static void InsertionSort(int[] A)
        {
            int n = A.Length;
            for (int i =1; i <= (n - 1); i++)
            {
                int v = A[i];
                int j = i - 1;
                while(j>=0 && A[j] > v)
                {
                    A[j + 1] = A[j];
                    j = j - 1;

                }
                A[j + 1] = v;
            }
            
        }

        static void PrintArray(int[] A)
        {
            Console.Write("[ " + A[0]);
           for (int i = 1; i < A.Length; i++)
            {
                Console.Write(", " + A[i]);
            }
            Console.WriteLine(" ]");

        }

    }
}
