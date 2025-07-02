using ExemploPOO.Interfaces;
namespace ExemploPOO.Models;
/**
 * Classe Computador
 * exemplo de herança, com implementação de interface
 */
public class Computador : Pessoa, ICalculadora
{
    public int Dividir(int num1, int num2)
    {
        throw new NotImplementedException();
    }

    public int Multiplicar(int num1, int num2)
    {
        throw new NotImplementedException();
    }

    public int Somar(int num1, int num2)
    {
        throw new NotImplementedException();
    }

    public int Subtrair(int num1, int num2)
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return "Computador";
    }
}
