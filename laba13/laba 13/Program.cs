using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_13
{
    class Program
    {
        delegate double Function(double a);
         static void Show(Function func)
        {
            for(double i = -5;i < 5; i+=0.03)
            {
                Console.WriteLine(func(i));
            }
        }
        static void Main(string[] args)
        {
            Show(Math.Tan);
            Show(Math.Cos);
            Console.ReadKey();
        }
    }
}
