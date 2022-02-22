using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace laba16
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sw1 = new StreamReader("E:\\лабыkpiyap\\laba16\\laba16\\Text.txt");
            string text = File.ReadAllText("E:\\лабыkpiyap\\laba16\\laba16\\Text.txt");
            string[] words = text.Split(' ');
            //foreach (var bb in words)
            //{
            //    Console.WriteLine(bb);
            //}
            int countprakt = 0;
            foreach (var word in words)
            {
                if (word == "лекция")
                {
                    countprakt++;
                }
            }
            Console.WriteLine($"Количество практики: {countprakt}");
            int counlec = 0;
            foreach (var word in words)
            {
                if (word == "практика")
                {
                    counlec++;
                }
            }
            Console.WriteLine($"Количество лекций: {counlec}");
        }
    }
}
