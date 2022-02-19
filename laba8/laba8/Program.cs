using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba8
{
    class Program
    {
        public static void Task1()
        {
            DateTime date1 = new DateTime(2013, 9, 18, 13, 30, 51); 
            DateTime date2 = new DateTime(2015, 7, 20, 15, 30, 25);
            DateTime[] arr = new DateTime[] { date1, date2};
            DateTime datenow = DateTime.Now;
            for(int i = 0; i < arr.Length; ++i)
            {
                Console.WriteLine(datenow.Subtract(arr[i]));
            }
            
        }

        static void data()
        {
            string[] workers = new string[] { "27.06.2021", "18.08.2020" };
            string nowDate = DateTime.Now.ToString("dd.MM.yyyy");
            for (int i = 0; i < workers.Length; ++i)
            {
                Console.WriteLine($"{Math.Round(((Convert.ToDateTime(nowDate) - Convert.ToDateTime(workers[i])).TotalDays / (365 / 12)))} полных месяца работает работник под номером {i}");
            }

        }
        static void Main(string[] args)
        {
            data();
            //Task1();
            Console.ReadKey();
        }
    }
}
