namespace ExemploPOO.Models;

/// <summary>
/// Classe Conta corrente
/// </summary>
public class ContaCorrente
{
    /// <summary>
    /// Construtor da classe conta corrent com argumentos
    /// </summary>
    /// <param name="numeroConta"></param>
    /// <param name="Saldo"></param>
    /// <exception cref="ArgumentException"></exception>
    public ContaCorrente(int numeroConta, decimal Saldo)
    {
        NumeroConta = numeroConta; // parametros do contrutor da classe
        this.Saldo = Saldo >= 0 ? Saldo : throw new ArgumentException("Saldo inicial não pode ser negativo."); // Parametros do construtor
    }
    /// <summary>
    /// Propiedade da Classe = Numero da conta
    /// </summary>
    public int NumeroConta { get; set; }
    /// <summary>
    /// Propriedade da Classe = Saldo
    /// </summary>
    private decimal Saldo;
    /// <summary>
    /// Metetodo de saque
    /// </summary>
    /// <param name="valor"></param>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="InvalidOperationException"></exception>
    public void Sacar(decimal valor) //Metodo da classe = Sacar
    {
        if (valor <= 0)
        {
            throw new ArgumentException("Valor do saque deve ser positivo.");
        }
        if (valor > Saldo)
        {
            throw new InvalidOperationException("Saldo insuficiente para saque.");
        }

        Saldo -= valor;
    }

    /// <summary>
    /// Metodo de exibição de saldo da classe
    /// </summary>
    public void ExibirSaldo()
    {
        Console.WriteLine($"O saldo da Conta:{NumeroConta}, é: {Saldo:C}");
    }
}
