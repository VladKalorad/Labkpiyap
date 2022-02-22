using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba15._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Laba15.Trapezoid t1 = new Laba15.Trapezoid(12.1, 14.2, 15.3, 16.4, 12.2);
            t1.Perimetr();
            t1.Square();
            Laba15.Trapezoid t2 = new Laba15.Trapezoid(12, 9, 15.3, 8.2, 11.2);
            t2.Perimetr();
            //try
            //{
            //    t2.Input();
            //}


            //catch (FunctionsExeption ex)
            //{
            //    Console.WriteLine($"Исключение: {ex.Message} ");
            //    Console.WriteLine($"Метод: {ex.TargetSite}");
            //}
        }
    }
}
