using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_12._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Train t1 = new Train("Minsk", 12, 22.12);
            t1.Number = -1;
            Console.WriteLine(t1);
            Train t2 = new Train("Minsk", -1 , 19.54);
            Console.WriteLine(t2);
            Train t3 = new Train("Volgograd", 16, 12.33);
            Console.WriteLine(t3);
            Train[] trs = new Train[3] { t1, t2, t3 };
            Trainstation ttt = new Trainstation(trs);
            ttt.FindCity(trs);
            //ttt.Filltr(trs);
            Console.ReadKey();
            try
            {
                t1.Input();
            }
            catch (FunctionsExeption ex)
            {
                Console.WriteLine($"Исключение: {ex.Message} ");
                Console.WriteLine($"Метод: {ex.TargetSite}");
            }
        }
    }
}
