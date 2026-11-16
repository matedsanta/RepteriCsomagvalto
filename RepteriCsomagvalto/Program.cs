using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepteriCsomagvalto
{
    internal class Program
    {
        static int S,M,L = 0;
        static void Main(string[] args)
        {
            Beker();

            Console.WriteLine($"S: {S} M: {M} L: {L}");
        }

        private static void Beker()
        {
            Console.WriteLine("Adja meg a csomag súlyát..");
            var inp = Console.ReadLine();

            try
            {
                var data = float.Parse(inp);
                if (data == 0) return;
                if (data<0) { Console.WriteLine("A súly nem lehet negatív!"); Beker(); return; }
                if (data <= 5.0) { S++; Beker(); return; }
                if (data <= 15.0) { M++; Beker(); return; }
                if (data <= 30.0) { L++;Beker(); return; }

                Console.WriteLine("Maximum súly: 30.0kg.");
                Beker();
            } catch (FormatException)
            {
                Beker();
            }
        }
    }
}
