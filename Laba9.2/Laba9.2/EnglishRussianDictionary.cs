using System;
using System.Collections.Generic;
using System.Text;

namespace Laba9._2
{
    class EnglishRussianDictionary
    {
        string word;
        string[] translations;

        public EnglishRussianDictionary(string word)
        {
            this.word = word;
            this.translations = Translations();
        }
        public string[] Translations()
        {
            Console.WriteLine("Введите кол-во переводво слова: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите переводы слов через пробел: ");
            string gg = Convert.ToString(Console.ReadLine());
            string[] array = gg.Split(' ');
            return array;
        }

        public void FindWordWithPrefix()
        {
            Console.WriteLine("Введите префикс: ");
            string prefix = Convert.ToString(Console.ReadLine());
            for (int i = 0; i < translations.Length; i++)
            {
                if (translations[i].Contains(prefix))
                {
                    Console.WriteLine(translations[i]);
                }
            }

        }
    }
}
