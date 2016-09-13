using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP_lab1
{
    class Program
    {
        
        static int[] GenerateArray( int ArrayLength)
        {
            int[] RandomArray =  new int[ArrayLength];
            Random random = new Random();
            for (int i = 0; i < ArrayLength; i++)
                RandomArray[i] = random.Next(-100, 100);
            return RandomArray;
        }
        static void InputArray()
        {
            int[] Array;
            try { 
                int ArrayLength;
                ArrayLength= int.Parse(Console.ReadLine());
                Array = GenerateArray(ArrayLength);
                foreach(var elem in Array)
                {
                    Console.Write(elem + " ");
                }
                QuickSort quickSort = new QuickSort();
                Array = quickSort.Sort(Array);
                Console.WriteLine();
                foreach (var elem in Array)
                {
                    Console.Write(elem + " ");
                }
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Ошибка, введите число");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                InputArray();
            }
            catch
            {
                Console.WriteLine("Ошибка, попробуйте заново");
            }
        }
    }
}
