using System;

namespace laba11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point("A", 10.1, "black");
            Point B = new Point("B", 15.6, "yellow");
            Point C = new Point("C", 13.1, "red");
            Point[] D = { A, B, C };

                
            Array.Sort(D);
            foreach (var obj in D)
            {
                ((IShowInfo)obj).ShowInfo();
            }
            Array.Sort(D, new Point());
            foreach (var obj in D)
            {
                ((IShowInfo)obj).ShowInfo();
            }
            Console.ReadKey();
        }
    }
}
