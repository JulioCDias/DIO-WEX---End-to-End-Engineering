using System.Runtime.InteropServices;
using ExemploPOO.Models; // Importa o namespace ExemploPOO.Models, onde está definida a classe Pessoa

Pessoa p1 = new Pessoa("João"); // Cria uma instância da classe Pessoa
// Define as propriedades Nome e Idade da instância p1
p1.Idade = 30; // Atribui a idade 30 à propriedade Idade
// Chama o método Apresentar da instância p1, que imprime uma mensagem de apresentação
p1.Apresentar();
ContaCorrente conta = new ContaCorrente(12345, 1000.00m); // Cria uma instância da classe ContaCorrente com número de conta 12345 e saldo inicial de 1000.00
conta.Sacar(200.00m); // Chama o método Sacar da instância conta, tentando sacar 200.00 do saldo
conta.ExibirSaldo();

Aluno a1 = new Aluno("Julio");
a1.Idade = 30;
a1.Nota = 8.5f;


a1.Apresentar();
Console.WriteLine($"Nota: {a1.Nota}");

Professor prof1 = new Professor("João");
prof1.Idade = 30;
prof1.Salario = 5000.00d;
prof1.Apresentar();
Console.WriteLine($"Salário: {prof1.Salario}");
Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
Corrente c = new Corrente();
c.Creditar(1000.00m);
c.ExibirSaldo();

Computador comp = new Computador();
Console.WriteLine(comp.ToString());