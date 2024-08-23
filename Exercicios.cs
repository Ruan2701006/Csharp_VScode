using System;
using System.ComponentModel;
using System.Runtime.Serialization.Formatters;
using System.Data;
using System.Security.Cryptography.X509Certificates;
namespace CursoC
{
    public class Exercicios
    {
        /* Criando e Inicializando um Array
        Crie um array de inteiros chamado numeros com capacidade para 5 elementos.
        Inicialize-o com os valores 2, 4, 6, 8, 10 e imprima todos os elementos. */
        public void demonstrar()
        {
            int[] numeros = { 2, 4, 6, 8, 10 };
            foreach (int n in numeros)
            {
                Console.WriteLine(n);
            }
        }
        /* Acessando Elementos de um Array
        Dado o array int[] valores = {1, 3, 5, 7, 9};, imprima o terceiro
        elemento do array. */

        public void demonstrar1()
        {
            int[] valores = { 1, 3, 5, 7, 9 };

            int terceiroElemento = valores[2];
            Console.WriteLine("O terceiro elemento do array é: " + terceiroElemento);
        }

        /*  Alterando Valores em um Array
        Crie um array de strings chamado nomes com os valores &quot;Ana&quot;, &quot;Bruno&quot;,
        &quot;Carla&quot;. Mude o valor de &quot;Bruno&quot; para &quot;Beto&quot; e depois imprima todos os
        elementos do array. */

        public void demonstrar2()
        {
            string[] nomes = { "Ana", "Bruno", "Carla" };

            nomes[1] = "Beto";

            Console.WriteLine("Elementos do array após a alteração:");
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }

        }

        /* Calculando a Soma dos Elementos de um Array
        Crie um array de inteiros chamado notas com os valores 7, 8, 9, 10, 6.
        Calcule e imprima a soma de todos os elementos do array. */

        public void demonstrar3()
        {
            int[] notas = { 7, 8, 9, 10, 6 };

            int soma = 0;

            foreach (int nota in notas)
            {
                soma += nota;
            }
            Console.WriteLine("A soma dos elementos do array é: " + soma);
        }

        /* Procurando um Elemento em um Array
        Dado o array int[] numeros = {5, 10, 15, 20, 25};, escreva um código
        que verifique se o número 15 está presente no array e imprima uma mensagem
        confirmando. */
        public void demonstrar4()
        {
            int[] numeros = { 5, 10, 15, 20, 25 };
            int numeroParaBuscar = 15;

            if (Array.Exists(numeros, numero => numero == numeroParaBuscar))
            {
                Console.WriteLine($"O número {numeroParaBuscar} está presente no array.");
            }
            else
            {
                Console.WriteLine($"O número {numeroParaBuscar} não está presente no array.");
            }
        }

        //List

        /* 1. Criando e Adicionando Elementos em uma List
        Crie uma List&lt;string&gt; chamada frutas. Adicione as frutas &quot;Maçã&quot;,
        &quot;Banana&quot;, &quot;Laranja&quot; e imprima todos os elementos da lista. */
        public void List1()
        {
            List<string> frutas = new List<string>();
            frutas.Add(" Maçã ");
            frutas.Add(" Banana ");
            frutas.Add(" Laranja ");
            Console.Write("Lista de frutas:");
            foreach (string fruta in frutas)
            {
                Console.WriteLine(fruta);
            }
        }

        /* Removendo um Elemento de uma List
        Crie uma List&lt;int&gt; chamada numeros e adicione os valores 1, 2, 3, 4, 5.
        Remova o número 3 da lista e depois imprima os elementos restantes. */

        public void List2()
        {
            List<int> numeros = new List<int>();
            Console.WriteLine();
            numeros.Add(1);
            numeros.Add(2);
            numeros.Add(3);
            numeros.Add(4);
            numeros.Add(5);

            numeros.Remove(3);

            Console.WriteLine("Lista de numeros sem o 3:");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }

        /* Acessando um Elemento Específico em uma List
        Dada a List&lt;string&gt; chamada cidades = new List&lt;string&gt; {&quot;São
        Paulo&quot;, &quot;Rio de Janeiro&quot;, &quot;Belo Horizonte&quot;}, imprima a segunda
        cidade da lista. */

        public void List3()
        {
            List<string> cidades = new List<string> { "São Paulo", "Rio de Janeiro", "Belo Horizonte" };
            Console.WriteLine("A Segunda cidade da lista é:" + cidades[1]);
        }

        /* Contando Elementos em uma List
        Crie uma List&lt;string&gt; chamada animais e adicione os valores &quot;Cachorro&quot;,
        &quot;Gato&quot;, &quot;Coelho&quot;. Escreva um código que imprima quantos elementos
        existem na lista. */
        public void List4()
        {
            List<string> animais = new List<string> { "Cachorro", "Gato", "Coelho" };
            int QuantidadeAnimais = animais.Count;
            Console.WriteLine("Quantidade de animais na lista: " + QuantidadeAnimais);
        }

        // Escopo de Variáveis

        /* 1. Variável Local em um Método
        Escreva um método chamado CalculaSoma que declare uma variável local int
        soma e calcule a soma de dois números passados como parâmetros. A variável
        soma deve estar acessível apenas dentro deste método. */

        public void Escopo1()
        {
            int numero1 = 4;
            int numero2 = 7;
            int soma = numero1 + numero2;
            Console.WriteLine($"O resultado da soma entre {numero1} e {numero2} é igual a {soma}");
        }

        /* Variável Global em uma Classe
        Crie uma classe chamada Carro com uma variável global string marca. No
        método Main, instancie um objeto Carro, defina a marca do carro como
        &quot;Toyota&quot; e imprima a marca. */

        public class Escopo2
        {
            public string? marca;
            public void Escrever()
            {
                Console.WriteLine($"Marca: {marca}");
            }
        }

        /* Conflito de Escopo
        Escreva um método onde você declare uma variável local com o mesmo nome
        de uma variável global da classe. Mostre como acessar ambas as variáveis no
        mesmo método. */

        public void ConflitoEscopo()
        {
            string? marca;
            marca = "Fiat";
            Console.WriteLine($"Variavel Local: {marca}");
        }

        /* 4.	Variável Local dentro de um Bloco Condicional
            Escreva um código onde uma variável int x seja declarada dentro de um bloco if. 
            Tente acessar essa variável fora do bloco if e observe o que acontece. */
            public void XCondicional(int y)
            {
                if (y > 3)
                {
                    int x = y + 5;
                    Console.WriteLine($"Valor de x: {x}");
                }
                else
                {
                    Console.WriteLine("Valor de x não é acessavel.");
                }
                
            }

          /* 5.	Alterando o Valor de uma Variável Global
            Crie uma variável global int contador em uma classe.
            No método Main, altere o valor de contador dentro de um loop for e depois imprima o valor final de contador.*/

            public class Contador{
                public int contador = 0;
                public void IncrementarPor10(int i)
                {
                    Console.Write($"O valor incrementado {i} vezes por 10.");
                    while (i-1 >= 0)
                    {
                        contador += 10;
                        i--;
                    }
                    Console.Write($" O total atual é {contador}");
                }
            }

        /* 6.	Capturando uma Exceção de Conversão de Tipo
            Tente converter uma string não numérica para um inteiro usando int.Parse. 
            Use try-catch para capturar a exceção e imprima uma mensagem apropriada. */

            public void CapturarExcecao(string converterNum)
            {
                try
                {
                    int num = int.Parse(converterNum);
                    Console.WriteLine($"Número convertido: {num}");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Ocorreu um erro de conversão: {ex.Message}");
                }
            }

        /* 7.	Lançando Exceções
            Escreva um método que recebe um número inteiro. 
            Se o número for negativo, lance uma ArgumentException. 
            Capture a exceção no método Main e imprima uma mensagem apropriada. */

        public void NumeroPositivo(int numero)
        {
            if (numero < 0)
            {
                throw new ArgumentException("Número não pode ser negativo.");
            }
            Console.WriteLine($"Número válido: {numero}");
        }

    }

}

