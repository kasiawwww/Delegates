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
            cw += delegate (string r) { Console.WriteLine(r + r); };
            cw("2");
            cw -= Console.WriteLine;
            cw("3");
            cr();

            List<Roman> romany = new List<Roman>();
            romany.Add(new Roman
            {
                Name = "Prawdziwy Roman" // matody anonimowe - tworzymy obikt w metodzie
            });

            Roman roman = new Roman();
            roman.Name = "ddd";
            romany.Add(roman);
        }

        static void writeNumber(string strNumber)
        {
            //logika
            Console.Write($"Podany string jest liczbą {strNumber}");
        }
    }

    class Roman
    {
        public string Name { get; set; }
    }
}
