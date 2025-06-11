using ExemploFundamentos.Models; // Importando o namespace que contém a classe Pessoa
// Início do programa principal

Pessoa pessoa = new Pessoa(); // Instanciando a classe Pessoa
pessoa.Nome = "João"; // Atribuindo o nome
pessoa.Idade = 30; // Atribuindo a idade
pessoa.Apresentar(); // Chamando o método para apresentar a pessoa

//Declarando e inicializando uma variável
int numero = 10; // Declarando uma variável do tipo inteiro e atribuindo o valor 10
string texto = "Olá, Mundo!"; // Declarando uma variável do tipo string e atribuindo um texto
long numeroGrande = 10000000000; // Declarando uma variável do tipo long para números grandes
decimal preco = 19.99m; // Declarando uma variável do tipo decimal para valores monetários
float altura = 1.75f; // Declarando uma variável do tipo float para números com ponto flutuante
char letra = 'A'; // Declarando uma variável do tipo char para um único caractere
bool estaChovendo = false; // Declarando uma variável do tipo bool para verdadeiro ou falso
double pi = 3.14159; // Declarando uma variável do tipo double para números com maior precisão
uint numeroSemSinal = 100; // Declarando uma variável do tipo uint para números inteiros sem sinal
ulong numeroMuitoGrande = 1000000000000; // Declarando uma variável do tipo ulong para números muito grandes sem sinal
object objetoGenerico = new object(); // Declarando uma variável do tipo object, que pode armazenar qualquer tipo de dado
byte numeroPequeno = 255; // Declarando uma variável do tipo byte para números pequenos (0 a 255)
short numeroCurto = 32767; // Declarando uma variável do tipo short para números inteiros menores que int
sbyte numeroNegativo = -128; // Declarando uma variável do tipo sbyte para números pequenos com sinal (-128 a 127)
// Exibindo os valores das variáveis no console
Console.WriteLine($"Número: {numero}"); // Exibindo o valor da variável numero
Console.WriteLine($"Texto: {texto}"); // Exibindo o valor da variável texto
Console.WriteLine($"Número Grande: {numeroGrande}"); // Exibindo o valor da variável numeroGrande
Console.WriteLine($"Preço: {preco}"); // Exibindo o valor da variável preco
Console.WriteLine($"Altura: {altura}"); // Exibindo o valor da variável altura
Console.WriteLine($"Letra: {letra}"); // Exibindo o valor da variável letra
Console.WriteLine($"Está Chovendo: {estaChovendo}"); // Exibindo o valor da variável estaChovendo
Console.WriteLine($"Pi: {pi}"); // Exibindo o valor da variável pi
Console.WriteLine($"Número Sem Sinal: {numeroSemSinal}"); // Exibindo o valor da variável numeroSemSinal
Console.WriteLine($"Número Muito Grande: {numeroMuitoGrande}"); // Exibindo o valor da variável numeroMuitoGrande
Console.WriteLine($"Objeto Genérico: {objetoGenerico}"); // Exibindo o valor da variável objetoGenerico
Console.WriteLine($"Número Pequeno: {numeroPequeno}"); // Exibindo o valor da variável numeroPequeno
Console.WriteLine($"Número Curto: {numeroCurto}"); // Exibindo o valor da variável numeroCurto
Console.WriteLine($"Número Negativo: {numeroNegativo}"); // Exibindo o valor da variável numeroNegativo

DateTime dataAtual = DateTime.Now; // Declarando uma variável do tipo DateTime para armazenar a data e hora atual
Console.WriteLine($"Data e Hora Atual: {dataAtual}"); // Exibindo a data e hora atual
                                                      // Fim do programa principal