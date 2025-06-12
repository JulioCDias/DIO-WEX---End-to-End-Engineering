using ExemploFundamentos.Models; // Importando o namespace que contém a classe Pessoa
// Início do programa principal
#region Declaração de variáveis e tipos primitivos
// Declaração de variáveis e tipos primitivos
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
#endregion
// Aguardando o usuário pressionar uma tecla antes de fechar o console

#region Tipos de Operadores em C#
// Operadores Aritméticos
int a = 10; // sinal de = é o operador de atribuição
int b = 5; // variavel b recebe o valor 5
int soma = a + b; // Soma
Console.WriteLine($"Soma: {soma}"); // Exibindo o resultado da soma
soma = soma + 5; // Adicionando 5 à soma
soma += 5; // Outra forma de adicionar 5 à soma
Console.WriteLine($"Soma após adição: {soma}"); // Exibindo o resultado após a adição
//Convertendo tipo de variaveis
int numeroInteiro = 10; // Declarando uma variável do tipo inteiro
double numeroDouble = (double)numeroInteiro; // Convertendo inteiro para double
Console.WriteLine($"Número convertido para double: {numeroDouble}"); // Exibindo o número convertido
//Usando convert
string numeroString = "123"; // Declarando uma variável do tipo string com um número
int numeroConvertido = Convert.ToInt32(numeroString); // Convertendo string para inteiro
Console.WriteLine($"Número convertido de string para inteiro: {numeroConvertido}"); // Exibindo o número convertido
                                                                                    // Diferenca entre convert e parse
/* a diferença entre Convert e Parse é que o Convert pode lidar com valores nulos e tipos diferentes,
enquanto o Parse é mais específico para conversão de strings para tipos primitivos. 
O Convert retorna um valor padrão se a conversão falhar, enquanto o Parse lança uma exceção.
alem de do Convert não quebrar o programa se for passados valores Nullos ele converte o null para zero,
já o Parse lança uma exceção se for passado um valor nulo ou inválido.
 */
// maneira segura de converter
string a1 = "456"; // Declarando uma variável do tipo string com um número
int a2; //Variavel declarada mas nao inicializada
int.TryParse(a1, out a2); // Tentando converter string para inteiro de forma segura
if (a2 != 0) // Verificando se a conversão foi bem-sucedida
{
    Console.WriteLine($"Número convertido de string para inteiro de forma segura: {a2}"); // Exibindo o número convertido
}
else
{
    Console.WriteLine("Conversão falhou, valor inválido ou nulo."); // Mensagem de falha na conversão
}
//Convertendo para string
int numeroParaString = 456; // Declarando uma variável do tipo inteiro
string numeroComoString = numeroParaString.ToString(); // Convertendo inteiro para string
Console.WriteLine($"Número convertido para string: {numeroComoString}"); // Exibindo o número convertido
// Casting Impliccito
int numeroInt = 100; // Declarando uma variável do tipo inteiro
double numeroDoubleCasting = numeroInt; // Casting implícito de int para double
Console.WriteLine($"Número após casting implícito para double: {numeroDoubleCasting}"); // Exibindo o número após o casting
// Ordem dos Operadores
double item1 = 4 / 2 + 2;
Console.WriteLine($"Resultado da expressão 4 / 2 + 2: {item1}"); // Exibindo o resultado da expressão
/*
A ordem dos operadores em C# segue as regras matemáticas padrão:
1. Parênteses: () - Operações dentro de parênteses são realizadas primeiro.
2. Exponenciação: ** - Operações de exponenciação são realizadas em seguida.
3. Multiplicação e Divisão: * / % - Operações de multiplicação, divisão e módulo são realizadas da esquerda para a direita.
4. Adição e Subtração: + - - Operações de adição e subtração são realizadas por último, também da esquerda para a direita.
*/
#endregion

#region  Operadores Condicionais
// Operadores Condicionais
/*
O Os peradores consicionais em C# são usados para mudar o fluxo de execução do programa com base em condições lógicas.
Os principais operadores condicionais são:
1. IF - Executa um bloco de código se a condição for verdadeira.
2. ELSE - Executa um bloco de código se a condição do IF for falsa.
3. ELSE IF - Permite verificar múltiplas condições, executando o bloco de código correspondente à primeira condição verdadeira.
4. SWITCH - Avalia uma expressão e executa um bloco de código correspondente ao valor da expressão.
5. CASE - Define um bloco de código a ser executado quando o valor da expressão no SWITCH corresponder ao valor especificado.
*/
// Exemplo de uso do IF e ELSE
int idade = 18; // Declarando uma variável do tipo inteiro para idade
if (idade >= 18) // Verificando se a idade é maior ou igual a 18
{
    Console.WriteLine("Você é maior de idade."); // Mensagem se a condição for verdadeira
}
else // Se a condição for falsa
{
    Console.WriteLine("Você é menor de idade."); // Mensagem se a condição for falsa
}
// Exemplo de uso do ELSE IF
int nota = 75; // Declarando uma variável do tipo inteiro para nota

if (nota >= 90) // Verificando se a nota é maior ou igual a 90
{
    Console.WriteLine("Aprovado com louvor!"); // Mensagem se a condição for verdadeira
}
else if (nota >= 70) // Verificando se a nota é maior ou igual a 70
{
    Console.WriteLine("Aprovado!"); // Mensagem se a condição for verdadeira
}
else if (nota >= 50) // Verificando se a nota é maior ou igual a 50
{
    Console.WriteLine("Recuperação!"); // Mensagem se a condição for verdadeira
}
else // Se nenhuma das condições anteriores for verdadeira
{
    Console.WriteLine("Reprovado!"); // Mensagem se todas as condições forem falsas
}
// Exemplo de uso do SWITCH
int diaDaSemana = 3; // Declarando uma variável do tipo inteiro para o dia da semana
switch (diaDaSemana) // Iniciando o SWITCH com a variável diaDaSemana
{
    case 1: // Se diaDaSemana for 1
        Console.WriteLine("Domingo"); // Mensagem para domingo
        break; // Saindo do SWITCH
    case 2: // Se diaDaSemana for 2
        Console.WriteLine("Segunda-feira"); // Mensagem para segunda-feira
        break; // Saindo do SWITCH
    case 3: // Se diaDaSemana for 3
        Console.WriteLine("Terça-feira"); // Mensagem para terça-feira
        break; // Saindo do SWITCH
    case 4: // Se diaDaSemana for 4
        Console.WriteLine("Quarta-feira"); // Mensagem para quarta-feira
        break; // Saindo do SWITCH
    case 5: // Se diaDaSemana for 5
        Console.WriteLine("Quinta-feira"); // Mensagem para quinta-feira
        break; // Saindo do SWITCH
    case 6: // Se diaDaSemana for 6
        Console.WriteLine("Sexta-feira"); // Mensagem para sexta-feira
        break; // Saindo do SWITCH
    case 7: // Se diaDaSemana for 7
        Console.WriteLine("Sábado"); // Mensagem para sábado
        break; // Saindo do SWITCH
    default: // Se nenhuma das condições anteriores for verdadeira
        Console.WriteLine("Dia inválido!"); // Mensagem de erro para dia inválido
        break; // Saindo do SWITCH
}

#endregion

#region Operadores Lógicos
// Operadores Lógicos
//Os operadores lógicos em C# são usados para combinar ou inverter condições booleanas. Os principais operadores lógicos são:
// 1. AND (&&) - Retorna verdadeiro se ambas as condições forem verdadeiras.
// 2. OR (||) - Retorna verdadeiro se pelo menos uma das condições for verdadeira.
// 3. NOT (!) - Inverte o valor lógico de uma condição, tornando verdadeiro em falso e vice-versa.
// Exemplo de uso do operador AND (&&)
bool ehMaiorDeIdade = true; // Declarando uma variável booleana para verificar se é maior de idade
bool temCarteiraDeHabilitacao = true; // Declarando uma variável booleana para verificar se tem carteira de habilitação
if (ehMaiorDeIdade && temCarteiraDeHabilitacao) // Verificando se ambas as condições são verdadeiras
{
    Console.WriteLine("Você pode dirigir."); // Mensagem se ambas as condições forem verdadeiras
}
else
{
    Console.WriteLine("Você não pode dirigir."); // Mensagem se pelo menos uma condição for falsa
}
// Exemplo de uso do operador OR (||)
bool ehAluno = true; // Declarando uma variável booleana para verificar se é aluno
bool temDesconto = false; // Declarando uma variável booleana para verificar se tem desconto
if (ehAluno || temDesconto) // Verificando se pelo menos uma das condições é verdadeira
{
    Console.WriteLine("Você tem direito a desconto."); // Mensagem se pelo menos uma condição for verdadeira
}
else
{
    Console.WriteLine("Você não tem direito a desconto."); // Mensagem se ambas as condições forem falsas
}

// Exemplo de uso do operador NOT (!)
bool estaChovendoo = false; // Declarando uma variável booleana para verificar se está chovendo
if (!estaChovendoo) // Verificando se não está chovendo
{
    Console.WriteLine("Você pode sair sem guarda-chuva."); // Mensagem se não estiver chovendo
}
else
{
    Console.WriteLine("Leve um guarda-chuva."); // Mensagem se estiver chovendo
}
#endregion