using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** 1-10 arası sayilari dowhile dongusu kullanarak konsola yazdiralim ; ***
            int sayi;
            sayi = 1;

            do
            {
                Console.WriteLine(sayi);
                sayi++;
            }
            while (sayi <= 10);


            Console.Read();
        }
    }
}
