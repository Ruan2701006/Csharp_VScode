using System;

namespace CursoCSharp
{
    // Definição de uma classe chamada Pessoa
    public class Pessoa
    {
        // Atributos (variáveis de instância)
        public string Nome;
        public int Idade;

        // Membro Estático (variável de classe)
        public static int NumeroDePessoas;

        // Construtor (um método especial para criar objetos)
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            NumeroDePessoas++;
        }

        // Método para exibir informações da pessoa
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }

        // Método Estático (pertence à classe, não à instância)
        public static void ExibirNumeroDePessoas()
        {
            Console.WriteLine($"Número de pessoas criadas: {NumeroDePessoas}");
        }
    }


}


