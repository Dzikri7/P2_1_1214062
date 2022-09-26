using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1214062
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Silahkan masukan angka : ");
            int angka1 = int.Parse(Console.ReadLine());
            int angka2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Angka Pertama : " + angka1);
            Console.WriteLine("Angka Pertama : " + angka2);

            Console.Write(angka1);
            Console.Write(" + ");
            Console.Write(angka2 + " = ");
            Console.WriteLine(angka1 + angka2);

            Console.Write(angka1);
            Console.Write(" - ");
            Console.Write(angka2 + " = ");
            Console.WriteLine(angka1 - angka2);

            Console.Write(angka1);
            Console.Write(" x ");
            Console.Write(angka2 + " = ");
            Console.WriteLine(angka1 * angka2);

            Console.Write(angka1);
            Console.Write(" : ");
            Console.Write(angka2 + " = ");
            Console.WriteLine(angka1 / angka2);
        }
    }
}
