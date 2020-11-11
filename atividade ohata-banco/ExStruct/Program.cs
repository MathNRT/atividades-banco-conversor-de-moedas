using System;
using System.Globalization;

namespace ExStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("PS5", 6000.00, 10); //Instancia o produto

            //printa as informaçoes na tela
            Console.WriteLine("Nome do Produto: " + p.Nome);
            Console.WriteLine("Preço do Produto: R$" + p.Preço.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Quantidade do Produto: " + p.Quantidade);
            Console.WriteLine("Valor Total do Estoque: R$" + p.ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture));

            Console.Write("Digite o número de produtos a serem adicionados no estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte); //adiciona os produtos da quantidade

            //novos depois apos a adição
            Console.WriteLine("Nome do Produto: " + p.Nome);
            Console.WriteLine("Quantidade do Produto: " + p.Quantidade);
            Console.WriteLine("Valor Total do Estoque: R$" + p.ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture));

            Console.Write("Digite o número de produtos a serem removidos no estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte); // removee os produtos da quantidade 

            //novos dados apos a remoção
            Console.WriteLine("Nome do Produto: " + p.Nome);
            Console.WriteLine("Quantidade do Produto: " + p.Quantidade);
            Console.WriteLine("Valor Total do Estoque: R$" + p.ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
