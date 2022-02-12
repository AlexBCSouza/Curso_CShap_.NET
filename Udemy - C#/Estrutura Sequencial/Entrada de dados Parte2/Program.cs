using System;
using System.Globalization;

namespace Entrada_de_dados_Parte2
{
    internal class Program
    {
        static void Main(string[] args)

            /// Entrada de dados com inteiros, Char, Double e Int ///
        {
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] v = Console.ReadLine().Split(' '); /// Usando vetor com "Split"///

            string nome = v[0]; ///Mapeando os Vetores do comando Split///
            char sexo = char.Parse(v[1]);   ///Mapeando os Vetores do comando Split///
            int idade = int.Parse(v[2]);    ///Mapeando os Vetores do comando Split///
            double altura = double.Parse(v[3], CultureInfo.InvariantCulture);   ///Mapeando os Vetores do comando Split///


            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2);
            Console.WriteLine(nome);/// Usando vetor [] comando "Split"///
            Console.WriteLine(sexo);/// Usando vetor [] comando "Split"///
            Console.WriteLine(idade);/// Usando vetor [] comando "Split"///
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));/// Usando vetor [] comando "Split"///
        }
    }
}
