using System;
using System.Security.Cryptography.X509Certificates;

namespace CalculadoraDeJurosCompostos0
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Calc calc = new Calc();

            Console.Write("Investimento inicial: R$ ");
            double ValorInicial = double.Parse(Console.ReadLine());

            Console.Write("Valor Mensal: ");
            double ValorMensal = double.Parse(Console.ReadLine());


            Console.Write("Tempo em Meses: ");
            int Ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Taxa de Juros a.a: ");
            double Juros = double.Parse(Console.ReadLine());

            Console.WriteLine($"No final de {calc.Ano} anos você terá R$ ");

        }
    }
}