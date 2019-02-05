using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> cw = Console.WriteLine;
            Func<int> cr = Console.Read;
            
            cw("1");
            cw += writeNumber;
            cw("2");
            cw -= Console.WriteLine;
            cw("3");

            cr();
        }

        static void writeNumber(string strNumber)
        {
            //logika
            Console.Write($"Podany string jest liczbą {strNumber}");
        }
    }
}
