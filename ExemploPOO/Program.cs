using ExemploPOO.Models; // Importa o namespace ExemploPOO.Models, onde está definida a classe Pessoa

Pessoa p1 = new Pessoa(); // Cria uma instância da classe Pessoa
// Define as propriedades Nome e Idade da instância p1
p1.Nome = "João"; // Atribui o nome "João" à propriedade Nome
p1.Idade = 30; // Atribui a idade 30 à propriedade Idade
// Chama o método Apresentar da instância p1, que imprime uma mensagem de apresentação
p1.Apresentar();
ContaCorrente conta = new ContaCorrente(12345, 1000.00m); // Cria uma instância da classe ContaCorrente com número de conta 12345 e saldo inicial de 1000.00
conta.Sacar(200.00m); // Chama o método Sacar da instância conta, tentando sacar 200.00 do saldo
conta.ExibirSaldo();