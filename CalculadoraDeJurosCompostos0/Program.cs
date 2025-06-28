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
            calc.ValorInicial = double.Parse(Console.ReadLine());

            Console.Write("Valor Mensal: ");
            calc.ValorMensal = double.Parse(Console.ReadLine());


            Console.Write("Tempo em Meses: ");
            calc.TempoEmMeses = int.Parse(Console.ReadLine());

            Console.Write("Taxa de Juros a.a: ");
            calc.Juros = double.Parse(Console.ReadLine())/100;

            double resultadoFinal = calc.CalcularValorFinal();


            Console.WriteLine($"No final de {calc.TempoEmMeses} meses você terá R$ {resultadoFinal:F2}");

            Console.ReadKey();

        }
    }
}