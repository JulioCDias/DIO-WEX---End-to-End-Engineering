namespace ExemploExplorandoCsharp.Models;

public class ExemploExcecao
{
    public void Metodo1()
    {
        try
        {
            Metodo2(); // Chamando o Método2
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu uma exceção: {ex.Message}"); // Tratando a exceção e exibindo a mensagem
        }
        finally
        {
            Console.WriteLine("Bloco finally executado."); // Bloco finally que sempre será executado
        }
    }

    public void Metodo2()
    {
        Metodo3(); // Chamando o Método3
    }

    public void Metodo3()
    {
        Metodo4(); // Chamando o Método4
    }
    public void Metodo4()
    {
        throw new Exception("Exceção lançada no Método 4"); // Lançando uma exceção personalizada
    }

}

