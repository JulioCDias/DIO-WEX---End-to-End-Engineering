
namespace ExemploPOO.Models;

public class Aluno : Pessoa // Herança da classe Pessoa
{
    public Aluno()
    {

    }
    public Aluno(string nome) : base(nome) // Construtor da classe Aluno, passando o nome como parâmetro para classe Pessoa
    {

    }
    public double Nota { get; set; }

    public override void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos. e sou um aluno com nota {Nota}");
    }
}
