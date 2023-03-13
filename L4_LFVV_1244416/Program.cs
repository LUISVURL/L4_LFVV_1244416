using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_LFVV_1244416
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, Suma, Resta, Multi, Division;
            int Div, Mod;
            Console.WriteLine("ejercicio 1: operaciones artiméticas");
            Console.WriteLine("");
            Console.Write("Ingrese Valor 1: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese Valor 2: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            Suma = n1 + n2;
            Resta = n1 - n2;
            Multi = n1 * n2;
            Division = n1 / n2;
            Div = Convert.ToInt32(n1 / n2);
            Mod = Convert.ToInt32(n1 % n2);
            Console.WriteLine("");
            Console.WriteLine(n1 + "+" + n2 + "=" + Suma);
            Console.WriteLine(n1 + "-" + n2 + "=" + Resta);
            Console.WriteLine(n1 + "*" + n2 + "=" + Multi);
            Console.WriteLine(n1 + "÷" + n2 + "=" + Division);
            Console.WriteLine(n1 + "DIV" + n2 + "=" + Div);
            Console.WriteLine(n1 + "MOD" + n2 + "=" + Mod);
            Console.WriteLine("");
            Console.WriteLine("ejercicio 2: operaciones booleanas");
            if (n1 > n2)
                {
                Console.WriteLine(n1 + ">" + n2); 
                }
            if (n2 > n1) 
                {
                Console.WriteLine(n2 + ">" + n1);
                }
            if (n1 == n2)
            {
                Console.WriteLine(n1 + "=" + n2);
            }
            Console.ReadKey();
        }
    }
}
