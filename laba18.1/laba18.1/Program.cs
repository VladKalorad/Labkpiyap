using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace laba18._1
{
    class Program
    {
        public static void Task1()
        {
            StreamReader sw1 = new StreamReader("E:\\лабыkpiyap\\laba18.1\\laba18.1\\laba.txt");
            string text = File.ReadAllText("E:\\лабыkpiyap\\laba18.1\\laba18.1\\laba.txt");
            Stack<string> of = new Stack<string>();
            string[] words = text.Split(' ');
            string[] glas = new string[100];
            for (int i = 0; i < words.Length; ++i)
            {
                //Console.WriteLine(words[i]);
                int count = 0;
                if (words[i] == "а" || words[i] == "е" || words[i] == "ё" || words[i] == "и" || words[i] == "о" || words[i] == "у" || words[i] == "ы" || words[i] == "э" || words[i] == "ю" || words[i] == "я")
                {
                    glas[i] = words[i];
                    of.Push(glas[i]);
                }
            }
            Console.WriteLine(string.Join(",", of));
        }
        public static void Task2()
        {
            Queue<char> symbols = new Queue<char>();
            Queue<char> digits = new Queue<char>();
            using (StreamReader sr = new StreamReader("E:\\лабыkpiyap\\laba18.1\\laba18.1\\task.txt"))
            {
                while (!sr.EndOfStream)
                {
                    char s = (char)sr.Read();
                    if (char.IsDigit(s))
                    {
                        digits.Enqueue(s);
                    }
                    else symbols.Enqueue(s);
                }
            }
            Console.WriteLine(string.Join("", symbols));
            Console.WriteLine(string.Join("", digits));
        }
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Console.ReadKey();
        }
    }
}
