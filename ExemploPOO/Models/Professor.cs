
namespace ExemploPOO.Models;

public class Professor : Pessoa // tipo sealed indica que essa classe nao pode ser herdada
{
    public Professor()
    {

    }
    public Professor(string nome) : base(nome)
    {

    }
    public double Salario { get; set; }

    public override void Apresentar() // typo sealed indica que essa classe nao pode ser herdada
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos. e sou um professor com salário {Salario}");
    }
}
