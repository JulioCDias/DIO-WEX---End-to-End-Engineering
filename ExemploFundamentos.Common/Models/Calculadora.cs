namespace ExemploFundamentos.Common.Models;
/// <summary>
/// Classe Calculadora representa uma calculadora com várias operações matemáticas.
/// </summary>
public class Calculadora
{
    /// <summary>
    /// Método Somar realiza a soma de dois números inteiros e retorna o resultado através de um parâmetro out.
    /// O parâmetro out é usado para retornar um valor de um método sem precisar usar o return.
    /// </summary>
    /// <param name="a">O primeiro numeoro interio da Soma</param>
    /// <param name="b">O Ultimo numero inteiro da soma</param>
    /// <param name="resultado">O resultado do methodo</param>
    public void Somar(int a, int b, out double resultado)
    {
        resultado = a + b;
    }
    /// <summary>
    /// Método Subtrair realiza a subtração de dois números inteiros e retorna o resultado através de um parâmetro out.
    /// O parâmetro out é usado para retornar um valor de um método sem precisar usar o return.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="resultado"></param>
    public void Subtrair(int a, int b, out double resultado)
    {
        resultado = a - b;
    }
    /// <summary>
    /// Método Multiplicar realiza a multiplicação de dois números inteiros e retorna o resultado através de um parâmetro out.
    /// O parâmetro out é usado para retornar um valor de um método sem precisar usar o return.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="resultado"></param>
    public void Multiplicar(int a, int b, out double resultado)
    {
        resultado = a * b;
    }

    /// <summary>
    /// Método Dividir realiza a divisão de dois números inteiros e retorna o resultado através de um parâmetro out.
    /// O parâmetro out é usado para retornar um valor de um método sem precisar usar o return.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="resultado"></param>
    /// <exception cref="DivideByZeroException"></exception>
    public void Dividir(int a, int b, out double resultado)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Divisão por zero não é permitida.");
        }
        resultado = a / b;
    }

    /// <summary>
    /// Método Potencia realiza a potenciação de um número inteiro elevado a outro número inteiro e retorna o resultado através de um parâmetro out.
    /// O parâmetro out é usado para retornar um valor de um método sem precisar usar o return.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="resultado"></param>
    public void Potencia(int a, int b, out double resultado)
    {
        resultado = Math.Pow(a, b);
    }
    /// <summary>
    /// Método RaizQuadrada calcula a raiz quadrada de um número inteiro e retorna o resultado através de um parâmetro out.
    /// O parâmetro out é usado para retornar um valor de um método sem precisar usar o return.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="resultado"></param>
    /// <exception cref="ArgumentException"></exception>
    public void RaizQuadrada(int a, out double resultado)
    {
        if (a < 0)
        {
            throw new ArgumentException("Não é possível calcular a raiz quadrada de um número negativo.");
        }
        resultado = Math.Sqrt(a);
    }
    /// <summary>
    /// Método Fatorial calcula o fatorial de um número inteiro e retorna o resultado através de um parâmetro out.
    /// O parâmetro out é usado para retornar um valor de um método sem precisar usar o return.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="resultado"></param>
    /// <exception cref="ArgumentException"></exception>
    public void Fatorial(int a, out long resultado)
    {
        if (a < 0)
        {
            throw new ArgumentException("Não é possível calcular o fatorial de um número negativo.");
        }
        resultado = 1;
        for (int i = 2; i <= a; i++)
        {
            resultado *= i;
        }
    }
    /// <summary>
    /// Método Media calcula a média de uma lista de números inteiros e retorna o resultado através de um parâmetro out.
    /// O parâmetro out é usado para retornar um valor de um método sem precisar usar o return.
    /// </summary>
    /// <param name="numeros"></param>
    /// <param name="resultado"></param>
    /// <exception cref="ArgumentException"></exception>
    public void Media(int[] numeros, out double resultado)
    {
        if (numeros == null || numeros.Length == 0)
        {
            throw new ArgumentException("A lista de números não pode ser nula ou vazia.");
        }
        double soma = 0;
        foreach (var numero in numeros)
        {
            soma += numero;
        }
        resultado = soma / numeros.Length;
    }
    /// <summary>
    /// Método Modulo calcula o resto da divisão de dois números inteiros e retorna o resultado através de um parâmetro out.
    /// O parâmetro out é usado para retornar um valor de um método sem precisar usar o return.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="resultado"></param>
    /// <exception cref="DivideByZeroException"></exception>
    public void Modulo(int a, int b, out int resultado)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Divisão por zero não é permitida.");
        }
        resultado = a % b;
    }
    /// <summary>
    /// Método Porcentagem calcula a porcentagem de um valor em relação a outro e retorna o resultado através de um parâmetro out.
    /// O parâmetro out é usado para retornar um valor de um método sem precisar usar o return.
    /// </summary>
    /// <param name="valor"></param>
    /// <param name="percentual"></param>
    /// <param name="resultado"></param>
    public void Porcentagem(int valor, int percentual, out double resultado)
    {
        resultado = (valor * percentual) / 100.0;
    }

}
