using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba19._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double[] mas = new double[n];
            fillArray(mas);
            Sort(mas);
            Console.ReadKey();
        }
        static void Sort(double[] arr)
        {
            var per = arr.Where(X => X < 0).Sum();
            var vtoroe = arr.SkipWhile(x => x > arr.Min())
                         .TakeWhile(x => x < arr.Max())
                         .Aggregate(1, (x, y) => (int)(x) + (int)(y));
            Console.WriteLine("sum " + per);
            Console.WriteLine("res " + vtoroe);
        }
        static void fillArray(double[] arr)
        {
            Random rand = new Random();
            for (int x = 0; x < arr.Length; x++)
            {
                arr[x] = rand.Next(-20, 2);
                Console.WriteLine(arr[x]);
            }
        }
    }
}
