using System;
using System.Collections;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace laba7
{
    class Program
    {
       
        public static void ExRege1()
        {
            string str = "2003-03-03 zxc tutu ctho to est 2004-04-04 i na posledok 9999-67-98";//FilllString();
            var regex = new Regex(@"(\d{4}-\d{2}-\d{2})+");
            MatchCollection matches = regex.Matches(str);
            var strArr = matches.ToList();
                for (int i = 0; i < strArr.Count; i++)
            {
                string delitel = strArr[i].ToString();
                if ((delitel[2] + delitel[3]) == (delitel[5] + delitel[6])
                    && (delitel[2] + delitel[3]) == (delitel[8] + delitel[9]))
                {
                    Console.WriteLine(delitel);
                }
            }
        }
        public static int Ex2Regex()
        {
            string str = "+375-44-5033291,03.11.2003,13:00,45мин,1200р";
            int count = 0;
            var regex = new Regex(@"\w{1,}").Replace(str, "");
            foreach (var item in regex)
            {
                count++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            ExRege1();
            Console.WriteLine(Ex2Regex());
            Console.ReadKey();
        }
    }
}
