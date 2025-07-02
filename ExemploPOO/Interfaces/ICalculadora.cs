
namespace ExemploPOO.Interfaces;
//Exemplo de interface

public interface ICalculadora // Interface
{
    int Somar(int num1, int num2);
    int Subtrair(int num1, int num2);
    int Multiplicar(int num1, int num2);
    int Dividir(int num1, int num2);
    /**
    * a Interface seria como uma classe abstrata, é um contrato de um conjunto de métodos
    *uma interface pode ter métodos abstratos e métodos concretos
    *exemplo
    *int Somar(int num1, int num2);
    *int Subtrair(int num1, int num2);
    *int Multiplicar(int num1, int num2);
    *int Dividir(int num1, int num2);
    *
    *int Somar(int num1, int num2)
    *{
    *    return num1 + num2;
    *}
    *
    */
}
