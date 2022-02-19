using System;

namespace Laba9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            EnglishRussianDictionary[] word = new EnglishRussianDictionary[3];
            Console.WriteLine("Введите индекс");
            int g = Convert.ToInt32(Console.ReadLine());
            switch (g)
            {
                case 0:
                    EnglishRussianDictionary a = new EnglishRussianDictionary("Hello");
                    word[0] = a;
                    Console.WriteLine("Hello");
                    word[0].FindWordWithPrefix();
                    break;
                case 1:
                    EnglishRussianDictionary b = new EnglishRussianDictionary("Car");
                    word[1] = b;
                    Console.WriteLine("Car");
                    word[1].FindWordWithPrefix();
                    break;
                case 2:
                    EnglishRussianDictionary c = new EnglishRussianDictionary("notebook");
                    word[2] = c;
                    Console.WriteLine("notebook");
                    word[2].FindWordWithPrefix();
                    break;
            }
            Console.ReadKey();
        }
    }
}
