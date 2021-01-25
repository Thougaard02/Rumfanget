using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumfanget
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rumfang af kasse");
            Console.WriteLine("Bestem højden");
            double h = double.Parse(Console.ReadLine());

            Console.WriteLine("Bestem bredden");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Bestem længden");
            double l = double.Parse(Console.ReadLine());

            string v = $"Rumfanget af kassen = {h * b * l}";

            Console.WriteLine(v);
        }
    }
}
