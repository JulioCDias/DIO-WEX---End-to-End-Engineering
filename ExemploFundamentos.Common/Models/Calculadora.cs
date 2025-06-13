namespace ExemploFundamentos.Common.Models;

public class Calculadora
{
    public void Somar(int a, int b, out double resultado)
    {
        resultado = a + b;
    }
    public void Subtrair(int a, int b, out double resultado)
    {
        resultado = a - b;
    }
    public void Multiplicar(int a, int b, out double resultado)
    {
        resultado = a * b;
    }
    public void Dividir(int a, int b, out double resultado)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Divisão por zero não é permitida.");
        }
        resultado = a / b;
    }
    public void Potencia(int a, int b, out double resultado)
    {
        resultado = Math.Pow(a, b);
    }
    public void RaizQuadrada(int a, out double resultado)
    {
        if (a < 0)
        {
            throw new ArgumentException("Não é possível calcular a raiz quadrada de um número negativo.");
        }
        resultado = Math.Sqrt(a);
    }
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
    public void Modulo(int a, int b, out int resultado)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Divisão por zero não é permitida.");
        }
        resultado = a % b;
    }
    public void Porcentagem(int valor, int percentual, out double resultado)
    {
        resultado = (valor * percentual) / 100.0;
    }

}
