using System;
using System.Threading.Tasks.Dataflow;

namespace CursoC
{
    public class Atividade
    {
        public void Exercicio1()

        /*Faça um programa para calcular o estoque medio de uma peça sendo que: ESTOQUE MÉDIO = (QUANTIDADE_MINIMA + QUANTIDADE_MAXIMA) /2.*/
        {
            Console.Write("digite a quantidade minima do estoque:");
            int QuantidadeMinima = int.Parse(Console.ReadLine());

            Console.Write("digite a quantidade maxima do estoque:");
            int QuantidadeMaxima = int.Parse(Console.ReadLine());

            double estoqueMedio = (QuantidadeMinima + QuantidadeMaxima) / 2;

            Console.WriteLine($"O estoque Medio é :{estoqueMedio}");
        }

        public void Exercicio2()
        /*Faça um programa que:
        -Leia a cotação do Dolar 
        -Leia um valor em dolares 
        -Converta esse valor para real
        -Mostra o resultado*/ 
        {
            Console.Write("Digite a cotação do dolar:");
            double cotacaoDolar = double.Parse(Console.ReadLine());

            Console.Write("Digite um valor em dolares:");
            double valorDolares = double.Parse(Console.ReadLine());

            double valorReais = valorDolares * cotacaoDolar;

            Console.WriteLine($"O valor de {valorDolares}Dolares é equivalente a {valorReais} Reais");
        }

        
    }
}


