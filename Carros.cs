using System;

class Carro
{
    public string Fabricante { get; set; } // Get: Possibilita Leitura Set: Possibilita escrita
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public bool Financiamento { get; set; }

    public void ExibirFichaTecnica() // Criando a ficha tecinica dos carros
    {
        Console.WriteLine($"Fabricante: {Fabricante}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Ano: {Ano}");
        if (Financiamento)
        {
            Console.WriteLine("Disponível para financiamento"); // Condições de financiamento
        }
        else
        {
            Console.WriteLine("Disponível apenas para consórcio ou à vista");
        }
    }
}