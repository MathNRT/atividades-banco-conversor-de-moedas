using System;
using System.Globalization;

namespace Conversor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é Cotação do Dólar? "); //o usuario informa a cotaçao do dolar
            conversor.cotacao = double.Parse(Console.ReadLine());

            Console.Write("Quantos Dólares Você Vai Comprar? "); //o usuario informa quantos dolares vai comprar
            conversor.valor = double.Parse(Console.ReadLine());
         
            Console.Write("Valor a Ser Pago em Reais: " + conversor.Reais().ToString("F2", CultureInfo.InvariantCulture)); //Escreve valor em reais

            Console.ReadKey();
        }
    }
}
