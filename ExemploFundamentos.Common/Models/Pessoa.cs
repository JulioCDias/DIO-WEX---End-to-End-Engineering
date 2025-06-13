namespace ExemploFundamentos.Common.Models; // Namespace é uma forma de organizar o código em C#

public class Pessoa // Classse é um modelo que define as propriedades e comportamentos de um objeto
{
    // Propriedades são características do objeto, como Nome e Idade
    public string? Nome { get; set; } // Propriedade Nome do tipo string
    public int Idade { get; set; } // Propriedade Idade do tipo int

    public void Apresentar() // Método para apresentar a pessoa
    {
        Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos.");
    }
}
