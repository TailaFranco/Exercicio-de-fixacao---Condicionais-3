using System;

namespace Exercício_3___produtos
{
//     Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
// preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
// desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
// - Se quantidade <= 5 o desconto será de 2%
// - Se quantidade > 5 e quantidade <=10 o desconto será de 3%
// - Se quantidade > 10 o desconto será de 5%
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int qtde;
            double preco_unitario;
            double desconto;
            double total;
            double total1;


            Console.WriteLine("Digite o nome do produto:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a quantidade adquirida do produto:");
            qtde = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preço unitário do produto:");
            preco_unitario = double.Parse(Console.ReadLine());

            if(preco_unitario <= 5)
            {
                desconto = preco_unitario*0.02*qtde;
                total1 = qtde * preco_unitario;
                total = total1 - desconto;
                Console.WriteLine($"Você adquiriu {qtde} {nome}");
                Console.WriteLine($"Preço total sem descontos: {total1} \n Descontos: {desconto} \n Preço total com descontos {total}");
            }
            if (preco_unitario >5 && preco_unitario <=10)
            {
                desconto = preco_unitario *0.03*qtde;
                total1 = qtde * preco_unitario;
                total = total1 - desconto;
                Console.WriteLine($"Você adquiriu {qtde} {nome}");
                Console.WriteLine($"Preço total sem descontos: {total1} \n Descontos: {desconto} \n Preço total com descontos {total}");
            
            }
            if (preco_unitario>10)
            {
                desconto = preco_unitario*0.05*qtde;
                total1 = qtde * preco_unitario;
                total = total1 - desconto;
                Console.WriteLine($" Você adquiriu {qtde} {nome}");
                Console.WriteLine($" Preço total sem descontos: {total1} \n Descontos: {desconto} \n Preço total com descontos {total}");
            
            }
            
        }
    }
}
