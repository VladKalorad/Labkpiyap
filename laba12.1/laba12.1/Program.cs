using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba12._1
{
    class Program 
    {
        public static double Polyperimetr()
        {
            Console.WriteLine("Введите Сторону А : ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Сторону B : ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Сторону C : ");
            int C = Convert.ToInt32(Console.ReadLine());
            double p = 0;
            if (A <= 0 || B <=0 || C <=0) throw new FunctionExeption(" Стороны A,B,C должен быть больше 0");
            else
            {
                p = (A + B + C) / 2;
            }
            return p;
        }
        public static void SimMatr()
        {
            int[,] m = new int[5, 5];
            int i, j;
            for (i = 0; i < 5; i++)
                for (j = 0; j < 5; j++)
                {
                    Console.WriteLine("Введите a[{0},{1}]:", i, j); 
                        m[i, j] = int.Parse(Console.ReadLine());   
                }
            bool flag = true;
            for (i = 0; i < 5; i++)
                for (j = 0; j < 5; j++)
                    if (m[i, j] != m[j, i])
                        flag = false;
            if (flag)
                Console.WriteLine("Симметрична");
            else
                throw new FunctionExeption(" Не семметрична");
            Console.WriteLine("Вывод матрицы :");
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                    Console.Write(m[i, j].ToString() + "\t");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
           
            try
            {
                Console.WriteLine(Polyperimetr());
                SimMatr();
            }
            catch (FunctionExeption ex)
            {
                Console.WriteLine($"Исключение: {ex.Message} ");
                Console.WriteLine($"Метод: {ex.TargetSite}");
            }
            Console.ReadKey();
        }
    }
}
