
namespace ExemploExplorandoCsharp.Models;

public class Curso
{
    public string Nome { get; set; }
    public List<Pessoa> Alunos { get; set; }

    public void AdicionarAluno(Pessoa aluno)
    {
        if (Alunos == null)
        {
            Alunos = new List<Pessoa>();
        }
        Alunos.Add(aluno);
    }

    public int ObterQuantidadeDeAlunos()
    {
        int quantidade = 0;
        if (Alunos != null)
        {
            quantidade = Alunos.Count;
        }
        return quantidade;
    }

    public bool RemoverAluno(Pessoa aluno)
    {
        if (Alunos != null && Alunos.Contains(aluno))
        {
            Alunos.Remove(aluno);
            Console.WriteLine($"Aluno {aluno.Nomecompleto} removido com sucesso.");
        }
        else
        {
            Console.WriteLine("Aluno não encontrado.");
        }

        return Alunos != null && Alunos.Contains(aluno);
    }

    public void ListarAlunos()
    {
        if (Alunos == null || Alunos.Count == 0)
        {
            Console.WriteLine("Nenhum aluno cadastrado.");
            return;
        }

        Console.WriteLine($"Alunos do curso {Nome}:");
        for (int i = 0; i < Alunos.Count; i++)
        {
            string texto = $"{i + 1}. {Alunos[i].Nomecompleto}"; //Concatenação de string
            Console.WriteLine(texto); //Exibição do texto concatenado
            Console.WriteLine("__________________________________________");
            Console.WriteLine($"N*{i + 1}. {Alunos[i].Nomecompleto}"); //Interpolação de string
            Console.WriteLine("__________________________________________");
            Console.WriteLine(string.Format("N*{0}. {1}", i + 1, Alunos[i].Nomecompleto)); // Formatação de string
        }
    }

}
