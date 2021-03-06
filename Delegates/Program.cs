﻿using System;
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
            Action<int, int> x = Sum;
            Func<int> cr = Console.Read;


            cw("1");
            cw += r => Console.WriteLine(r + r); //cw += delegate (string r) { Console.WriteLine(r + r); };
            x += (a, b) => Console.WriteLine(a -b);
            x += (a, b) =>
            {
                if (a > 1 && b != 0)
                    Console.WriteLine(a / b);
                if (a % b == 0 )
                    Console.WriteLine("Liczba parzysta");
                if (a % b != 0)
                    Console.WriteLine("Liczba nieparzysta");
            };
            cr = () => Console.Read();


            cw("2");
            cw -= Console.WriteLine;
            cw("3");
            Console.WriteLine();
            x(11, 3);
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
        static void Sum (int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }

    class Roman
    {
        public string Name { get; set; }
    }
}
