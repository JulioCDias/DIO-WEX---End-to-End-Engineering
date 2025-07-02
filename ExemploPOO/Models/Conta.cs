namespace ExemploPOO.Models;

public abstract class Conta //classe abstrata, nao pode ser instanciada, somente herdada serve como molde
{
    protected decimal Saldo; //propriedade

    public abstract void Creditar(decimal valor); //metodo abstrato, nao tem implementação serve como molde
    /*
    * Protected = visibilidade interna da classe ou seja
    * somente a classe e suas subclasses podem acessar esse metodo
    */

    public void ExibirSaldo()
    {
        Console.WriteLine($"O saldo da Conta é: {Saldo:C}");
    }
}
