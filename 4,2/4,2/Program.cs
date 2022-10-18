using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2
{
    class Program
    {
        static void inputarr(int[] arr)
        {
 
            for(int i = 0; i < arr.Length; ++i)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void nullarr(int[] arr)
        {
            Console.WriteLine("Индекс нулевых элементов массива: ");
            for (int i = 0; i < arr.Length; ++i)
            {
                if(arr[i] == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine("Нулевых элементов нет");
                }
            }
        }
        static void task2(int[]arr)
        { 
            int index = Array.FindIndex(arr, item => item == 0);
            for(int i = 0; i < arr.Length; ++i)
            {
                Console.WriteLine($"Нулевые элементы массива:{index} ", index,arr);    
            }
        }
       
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите элемента массива: ");
            int[] arr = new int[size];
            int[] arrtask2 = new int[] { };
            inputarr(arr);
            nullarr(arr);
            task2(arr);
            Console.ReadKey();
        }
    }
}
