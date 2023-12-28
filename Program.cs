using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quatro valores.");
            int primeiro = int.Parse(Console.ReadLine());
            int segundo = int.Parse(Console.ReadLine());
            int terceiro = int.Parse(Console.ReadLine());
            int quarto = int.Parse(Console.ReadLine());

            int diferenca = primeiro * segundo - terceiro * quarto;
            Console.WriteLine("DIFERENCA = " + diferenca);
        }
    }
}