using System;

class Program
{
    static void Main(string[] args)
    {
        // Criar primeiro carro
        Carro carroFord = new Carro();
        carroFord.Fabricante = "Ford";
        carroFord.Modelo = "Focus";
        carroFord.Ano = 2022;
        carroFord.Financiamento = true;

        // Criar segundo carro
        Carro carroFiat = new Carro();
        carroFiat.Fabricante = "Fiat";
        carroFiat.Modelo = "Argo";
        carroFiat.Ano = 2020;
        carroFiat.Financiamento = false;

        // Exibindo primeiro carro
        Console.WriteLine("Ficha Técnica do Carro Ford:");
        carroFord.ExibirFichaTecnica();


        Console.WriteLine();

        // Exibindo segundo carro 
        Console.WriteLine("Ficha Técnica do Carro Fiat:");
        carroFiat.ExibirFichaTecnica();

        // Criar pessoas
        Pessoa pessoa1 = new Pessoa("Alice");
        Pessoa pessoa2 = new Pessoa("Bob");

        // Atribuir carros às pessoas
        pessoa1.AdicionarCarro(carroFord);
        pessoa2.AdicionarCarro(carroFiat);

        Console.WriteLine();

        pessoa1.ListarCarros();
        pessoa2.ListarCarros();


        Console.ReadLine();


    }
}

