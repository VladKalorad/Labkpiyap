using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_12._2
{
    class Trainstation
    {
        Train[] tr;
        public Trainstation(Train[]arr)
        {
            tr = arr;
        }
        public void Filltr(Train[]tr)
        {
            Console.WriteLine("Введите индекс");
            int k = Convert.ToInt32(Console.ReadLine());
            for(int i =0; i < tr.Length; ++i )
            {
                if(k < tr[i].Number)
                {
                    Console.WriteLine(tr[i]);
                }
            }
        }
        public void FindCity(Train[] tr)
        {
            Console.WriteLine("Введите город: ");
            string k = Console.ReadLine();
            for (int i = 0; i < tr.Length; ++i)
            {
                if (k == tr[i].City)
                {
                    Console.WriteLine(tr[i]);
                }
                else
                {
                    Console.WriteLine("Такого города нет");
                }
            }
        }
        static void Sortirovka(Train[] tr)
        {
            for (int i = 0; i != tr.Length; i++)
            {
                for (int j = i + 1; j != tr.Length; j++)
                {
                    if (tr[i].Time > tr[j].Time)
                    {
                        Train temp = tr[i];
                        tr[i] = tr[j];
                        tr[j] = temp;
                    }
                }
            }
        }
    }
}
