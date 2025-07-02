
namespace ExemploPOO.Models;

public class Professor : Pessoa
{
    public double Salario { get; set; }

    public override void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos. e sou um professor com salário {Salario}");
    }
}
