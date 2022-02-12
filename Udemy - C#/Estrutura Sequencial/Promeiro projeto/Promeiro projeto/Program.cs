using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promeiro_projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 10.123356;
            int y = 32;
            string z = "Maria";
            char w = 'F';


            Console.WriteLine("Olá Mundo!");
            Console.WriteLine("Bom dia!");
            Console.WriteLine("Até mais.");

            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F1"));
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F3"));
            Console.WriteLine(x.ToString("F4"));
            Console.WriteLine(x.ToString("F5", CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.WriteLine("Resultado = " + x);
            Console.WriteLine("O valor do troco é " + x + " reais");
            Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais");

            Console.WriteLine();
            Console.WriteLine("A paciente " + z + " tem " + y + " anos e seu sexo é: " + w);
            Console.ReadLine();


        }
    }
}
