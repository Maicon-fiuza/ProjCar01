using System.Collections.Generic;
using System;

class Pessoa
{
    public string Nome { get; set; } // Armazenar o nome da pessoa
    public List<Carro> Carros { get; set; } //Lista vazia

    public Pessoa(string nome) //Construtor do tipo pessoa onde receberá o nome da pessoa
    {
        Nome = nome;
        Carros = new List<Carro>();// Carros atribuido a Lista que estava vazia
    }

    public void AdicionarCarro(Carro carro) // Adicionando o carro a lista de carros
    {
        Carros.Add(carro);
    }

    public void ListarCarros() //Um loop para imprimir a ficha tecnica do carro
    {
        Console.WriteLine($"Carros de {Nome}:");
        foreach (var carro in Carros)
        {
            Console.WriteLine($"- {carro.Fabricante} {carro.Modelo} ({carro.Ano})");
        }
    }
}
