using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba9
{
    class Findarr
    {
        int[,] arr;
        public Findarr(int a, int b)
        {
            arr = new int[a, b];
            Random x = new Random();
            for (int i = 0; i < a; ++i)
            {
                for (int j = 0; j < b; j++)
                {
                    arr[i, j] = x.Next(-10, 10);
                }
            }
        }
        public void Negatival(int a, int b)
        {
            int count = 0;
            for (int i = 0; i < a; ++i)
            {
                for (int j = 0; j < b; ++j)
                {
                    if (arr[i, j] < 0)
                    {
                        ++count;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
