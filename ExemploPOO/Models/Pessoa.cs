namespace ExemploPOO.Models;

public class Pessoa //exemplo de classe em C#, abstração de um objeto do mundo real
{
    public Pessoa()
    {

    }
    public Pessoa(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; set; } //propriedade Nome do tipo string
    // Propriedade Idade do tipo int

    public int Idade { get; set; }

    public virtual void Apresentar() //método que imprime uma mensagem de apresentação, virtual indica que pode ser sobreescrito
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
    }
}
