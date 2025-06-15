using ExemploFundamentos.Common.Models;
// Importando o namespace que contém a classe Pessoa
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

#region  Operadores Aritimeticos e a Classe Math
// Operadores Aritméticos e a Classe Math
// Os operadores aritméticos em C# são usados para realizar operações matemáticas básicas. Os principais operadores aritméticos são:
// 1. Adição (+) - Soma dois valores.
// 2. Subtração (-) - Subtrai um valor de outro.
// 3. Multiplicação (*) - Multiplica dois valores.
// 4. Divisão (/) - Divide um valor por outro.
// 5. Módulo (%) - Retorna o resto da divisão de um valor por outro.
// 6. Incremento (++) - Aumenta o valor de uma variável em 1.
// 7. Decremento (--) - Diminui o valor de uma variável em 1.
// Exemplo de uso dos operadores aritméticos
int x = 10; // Declarando uma variável do tipo inteiro
int y = 5; // Declarando outra variável do tipo inteiro
int _soma = x + y; // Usando o operador de adição
int subtracao = x - y; // Usando o operador de subtração
int multiplicacao = x * y; // Usando o operador de multiplicação
int divisao = x / y; // Usando o operador de divisão
int modulo = x % y; // Usando o operador de módulo
Console.WriteLine($"Soma: {_soma}"); // Exibindo o resultado da soma
Console.WriteLine($"Subtração: {subtracao}"); // Exibindo o resultado da subtração
Console.WriteLine($"Multiplicação: {multiplicacao}"); // Exibindo o resultado da multiplicação
Console.WriteLine($"Divisão: {divisao}"); // Exibindo o resultado da divisão
Console.WriteLine($"Módulo: {modulo}"); // Exibindo o resultado do módulo
// Exemplo de uso dos operadores de incremento e decremento
x++; // Incrementando o valor de x em 1
Console.WriteLine($"Valor de x após incremento: {x}"); // Exibindo o valor de x após o incremento
y--; // Decrementando o valor de y em 1
Console.WriteLine($"Valor de y após decremento: {y}"); // Exibindo o valor de y após o decremento
// Usando a Classe Math para operações matemáticas avançadas
double raizQuadrada = Math.Sqrt(25); // Calculando a raiz quadrada de 25
Console.WriteLine($"Raiz quadrada de 25: {raizQuadrada}"); // Exibindo o resultado da raiz quadrada
double potencia = Math.Pow(2, 3); // Calculando 2 elevado a 3
Console.WriteLine($"2 elevado a 3: {potencia}"); // Exibindo o resultado da potência
double valorAbsoluto = Math.Abs(-10.5); // Calculando o valor absoluto de -10.5
Console.WriteLine($"Valor absoluto de -10.5: {valorAbsoluto}"); // Exibindo o resultado do valor absoluto
double maiorValor = Math.Max(10, 20); // Encontrando o maior valor entre 10 e 20
Console.WriteLine($"Maior valor entre 10 e 20: {maiorValor}"); // Exibindo o maior valor
double menorValor = Math.Min(10, 20); // Encontrando o menor valor entre 10 e 20
Console.WriteLine($"Menor valor entre 10 e 20: {menorValor}"); // Exibindo o menor valor
double arredondado = Math.Round(3.14159, 2); // Arredondando o número 3.14159 para 2 casas decimais
Console.WriteLine($"Número 3.14159 arredondado para 2 casas decimais: {arredondado}"); // Exibindo o número arredondado
double teto = Math.Ceiling(3.14); // Arredondando para cima
Console.WriteLine($"Número 3.14 arredondado para cima: {teto}"); // Exibindo o número arredondado para cima
double piso = Math.Floor(3.99); // Arredondando para baixo
Console.WriteLine($"Número 3.99 arredondado para baixo: {piso}"); // Exibindo o número arredondado para baixo
double seno = Math.Sin(Math.PI / 2); // Calculando o seno de 90 graus (PI/2 radianos)
Console.WriteLine($"Seno de 90 graus: {seno}"); // Exibindo o resultado do seno
double cosseno = Math.Cos(Math.PI); // Calculando o cosseno de 180 graus (PI radianos)
Console.WriteLine($"Cosseno de 180 graus: {cosseno}"); // Exibindo o resultado do cosseno
double tangente = Math.Tan(Math.PI / 4); // Calculando a tangente de 45 graus (PI/4 radianos)
Console.WriteLine($"Tangente de 45 graus: {tangente}"); // Exibindo o resultado da tangente
// Exemplo de uso com classe externa

Calculadora calc = new Calculadora(); // Instanciando a classe Calculadora
double resultadoPotencia,
    resultadoRaizQuadrada,
    resultadoMultiplicação,
    resultadoDivisao,
    resultadoSoma,
    resultadoSubtracao; // Declarando variáveis para armazenar os resultados de potência e raiz quadrada
calc.Somar(5, 3, out resultadoSoma); // Chamando o método Somar da classe Calculadora
Console.WriteLine($"Resultado da soma: {resultadoSoma}"); // Exibindo o resultado da soma
calc.Subtrair(10, 4, out resultadoSubtracao); // Chamando o método Subtrair da classe Calculadora
Console.WriteLine($"Resultado da subtração: {resultadoSubtracao}"); // Exibindo o resultado da subtração
calc.Multiplicar(6, 7, out resultadoMultiplicação); // Chamando o método Multiplicar da classe Calculadora
Console.WriteLine($"Resultado da multiplicação: {resultadoMultiplicação}"); // Exibindo o resultado da multiplicação
calc.Dividir(20, 4, out resultadoDivisao); // Chamando o método Dividir da classe Calculadora
Console.WriteLine($"Resultado da divisão: {resultadoDivisao}"); // Exibindo o resultado da divisão
calc.Potencia(2, 3, out resultadoPotencia); // Chamando o método Potencia da classe Calculadora
Console.WriteLine($"Resultado da potência: {resultadoPotencia}"); // Exibindo o resultado da potência
calc.RaizQuadrada(16, out resultadoRaizQuadrada); // Chamando o método RaizQuadrada da classe Calculadora
Console.WriteLine($"Resultado da raiz quadrada: {Math.Round(resultadoRaizQuadrada, 4)}"); // Exibindo o resultado da raiz quadrada
// Exemplo de uso de Incremento e Decremento
int contador = 0; // Declarando uma variável do tipo inteiro para contador
contador++; // Incrementando o contador em 1
Console.WriteLine($"Contador após incremento: {contador}"); // Exibindo o valor do contador após o incremento
contador--; // Decrementando o contador em 1
Console.WriteLine($"Contador após decremento: {contador}"); // Exibindo o valor do contador após o decremento

#endregion

#region Estruturas de Repetição
// Estruturas de Repetição
// As estruturas de repetição em C# são usadas para executar um bloco de código várias vezes, com base em uma condição. As principais estruturas de repetição são:
// 1. FOR - Executa um bloco de código um número específico de vezes.
// 2. WHILE - Executa um bloco de código enquanto uma condição for verdadeira.
// 3. DO WHILE - Executa um bloco de código pelo menos uma vez e, em seguida, continua enquanto uma condição for verdadeira.
// 4. FOREACH - Itera sobre uma coleção ou array, executando um bloco de código para cada elemento.

// Exemplo de uso do FOR
// O loop FOR é usado para executar um bloco de código um número específico de vezes.
// O for necessita de três partes:
// 1. Inicialização: Define uma variável de controle e seu valor inicial.
// 2. Condição: Verifica se a variável de controle atende a uma condição para continuar o loop.
// 3. Incremento/Decremento: Atualiza a variável de controle após cada iteração.
for (int contadorr = 0; contadorr < 10; contadorr++) // Iniciando o loop FOR com i começando em 0 e indo até 4
{
    Console.WriteLine($"Valor de i: {contadorr}"); // Exibindo o valor de i em cada iteração
}
//exemplo de uso de for com uma tabuada de multiplicação
for (int i = 0; i <= 10; i++) // Loop para a tabuada de multiplicação de 1 a 10
{
    Console.WriteLine($"Tabuada do {i}:"); // Exibindo o título da tabuada
    for (int j = 1; j <= 10; j++) // Loop interno para multiplicar i por j
    {
        Console.WriteLine($"{i} x {j} = {i * j}"); // Exibindo o resultado da multiplicação
    }
    Console.WriteLine(); // Linha em branco para separar as tabuadas
}

// Exemplo de uso do WHILE
// O loop WHILE executa um bloco de código enquanto uma condição for verdadeira.
int contadorWhile = 0; // Declarando uma variável do tipo inteiro para contador
while (contadorWhile < 5) // Verificando se o contador é menor que 5
{
    Console.WriteLine($"Valor do contador: {contadorWhile}"); // Exibindo o valor do contador
    contadorWhile++; // Incrementando o contador em 1
}
// Exemplo de uso do DO WHILE
// O loop DO WHILE executa um bloco de código pelo menos uma vez e, em seguida, continua enquanto uma condição for verdadeira.
int contadorDoWhile = 0; // Declarando uma variável do tipo inteiro para contador
do // Iniciando o loop DO WHILE
{
    Console.WriteLine($"Valor do contador: {contadorDoWhile}"); // Exibindo o valor do contador
    contadorDoWhile++; // Incrementando o contador em 1
} while (contadorDoWhile < 5); // Verificando se o contador é menor que 5
// Exemplo de uso do FOREACH
// O loop FOREACH é usado para iterar sobre uma coleção ou array, executando um bloco de código para cada elemento.
string[] frutas = { "Maçã", "Banana", "Laranja", "Uva" }; // Declarando um array de strings com nomes de frutas
foreach (string fruta in frutas) // Iniciando o loop FOREACH para iterar sobre o array de frutas
{
    Console.WriteLine($"Fruta: {fruta}"); // Exibindo o nome da fruta em cada iteração
}
// posso interromper um loop com o comando break
// Exemplo de uso do comando break
for (int i = 0; i < 10; i++) // Loop para contar de 0 a 9
{
    if (i == 5) // Verificando se i é igual a 5
    {
        Console.WriteLine("Loop interrompido no valor 5."); // Mensagem de interrupção
        break; // Interrompendo o loop
    }
    Console.WriteLine($"Valor de i: {i}"); // Exibindo o valor de i em cada iteração
}
//exemoplo de menu interativo com while
bool continuarr = true; // Variável para controlar o loop
while (continuarr) // Iniciando o loop WHILE
{
    Console.WriteLine("Menu:"); // Exibindo o menu
    Console.WriteLine("1. Opção 1"); // Opção 1 do menu
    Console.WriteLine("2. Opção 2"); // Opção 2 do menu
    Console.WriteLine("3. Sair"); // Opção para sair do menu
    Console.Write("Escolha uma opção: "); // Solicitando ao usuário que escolha uma opção

    string escolha = Console.ReadLine(); // Lendo a entrada do usuário

    switch (escolha) // Iniciando o SWITCH com a escolha do usuário
    {
        case "1": // Se a escolha for 1
            Console.WriteLine("Você escolheu a Opção 1."); // Mensagem para a Opção 1
            break; // Saindo do SWITCH
        case "2": // Se a escolha for 2
            Console.WriteLine("Você escolheu a Opção 2."); // Mensagem para a Opção 2
            break; // Saindo do SWITCH
        case "3": // Se a escolha for 3
            continuarr = false; // Alterando a variável para sair do loop
            Console.WriteLine("Saindo do menu..."); // Mensagem de saída do menu
            break; // Saindo do SWITCH
        default: // Se nenhuma das opções anteriores for escolhida
            Console.WriteLine("Opção inválida! Tente novamente."); // Mensagem de erro para opção inválida
            break; // Saindo do SWITCH
    }
}
#endregion

#region Arrays e Listas
//exemplo de Array

int[] arreyInteiros = new int[5]; // Declarando um array de inteiros com 5 elementos
arreyInteiros[0] = 10; // Atribuindo o valor 10 ao primeiro elemento do array
arreyInteiros[1] = 20; // Atribuindo o valor 20 ao segundo elemento do array
arreyInteiros[2] = 30; // Atribuindo o valor 30 ao terceiro elemento do array
arreyInteiros[3] = 40; // Atribuindo o valor 40 ao quarto elemento do array
arreyInteiros[4] = 50; // Atribuindo o valor 50 ao quinto elemento do array
Console.WriteLine("Elementos do array:"); // Exibindo a mensagem de início
for (int i = 0; i < arreyInteiros.Length; i++) // Loop para percorrer os elementos do array
{
    Console.WriteLine($"Elemento {i}: {arreyInteiros[i]}"); // Exibindo o valor de cada elemento do array
}

int[] arreyInteiros2 = { 1, 2, 3, 4, 5 }; // Declarando e inicializando um array de inteiros com valores
Console.WriteLine("Elementos do array 2:"); // Exibindo a mensagem de início
for (int i = 0; i < arreyInteiros2.Length; i++) // Loop para percorrer os elementos do array
{
    Console.WriteLine($"Elemento {i}: {arreyInteiros2[i]}"); // Exibindo o valor de cada elemento do array
}
//Percorrendo um array com foreach
foreach (int numeros in arreyInteiros2) // Loop para percorrer os elementos do array usando foreach
{
    Console.WriteLine($"Número: {numeros}"); // Exibindo o valor de cada número no array
}
// caso Precise aumentar o tamanho do array
Array.Resize(ref arreyInteiros, 10); // Redimensionando o array para 10 elementos
//Caso Precise copiar um array para outro
int[] novoArray = new int[arreyInteiros.Length]; // Declarando um novo array com o mesmo tamanho do array original
Array.Copy(arreyInteiros, novoArray, arreyInteiros.Length); // Copiando os elementos do array original para o novo array
// Exibindo os elementos do novo array
Console.WriteLine("Elementos do novo array:"); // Exibindo a mensagem de início
for (int i = 0; i < novoArray.Length; i++) // Loop para percorrer os elementos do novo array
{
    Console.WriteLine($"Elemento {i}: {novoArray[i]}"); // Exibindo o valor de cada elemento do novo array
}
// Exemplo de uso de Listas
List<string> listaStrings = new List<string>(); // Declarando uma lista de strings
listaStrings.Add("Maçã"); // Adicionando "Maçã" à lista
listaStrings.AddRange(new string[] { "Banana", "Laranja" }); // Adicionando múltiplos elementos à lista
Console.WriteLine("Elementos da lista:"); // Exibindo a mensagem de início
foreach (string fruta in listaStrings) // Loop para percorrer os elementos da lista
{
    Console.WriteLine($"Fruta: {fruta}"); // Exibindo o valor de cada fruta na lista
}

#endregion

#region Comentarios e Boas Praticas
// Comentários e Boas Práticas
// Comentários são usados para explicar o código e torná-lo mais legível. Existem dois tipos de comentários em C#:
// 1. Comentários de linha única: Iniciados com // e vão até o final da linha.
// 2. Comentários de várias linhas: Iniciados com /* e terminados com */.
// 3. Comentários XML: Usados para documentar classes, métodos e propriedades, iniciados com ///.
// Exemplo de comentário de linha única
// Este é um comentário de linha única, usado para explicar o código
Console.WriteLine("Exemplo de comentário de linha única"); // Exibindo uma mensagem no console
// Exemplo de comentário de várias linhas
/* Este é um comentário de várias linhas,
   usado para explicar o código em mais detalhes
   ou para desativar temporariamente um bloco de código */
Console.WriteLine("Exemplo de comentário de várias linhas"); // Exibindo uma mensagem no console
// Exemplo de comentário XML
/// <summary>
/// Este método exibe uma mensagem no console.
/// </summary>
void ExibirMensagem()
{
    Console.WriteLine("Exemplo de comentário XML"); // Exibindo uma mensagem no console
}
// Chamada do método para exibir a mensagem
ExibirMensagem(); // Chamando o método para exibir a mensagem
                  // Boas práticas de programação
                  // 1. Use nomes significativos para variáveis, métodos e classes.
                  // 2. Mantenha o código limpo e organizado, com indentação adequada.
                  // 3. Comente o código para explicar partes complexas ou importantes.
                  // 4. Evite duplicação de código, reutilizando métodos quando possível.
                  // 5. Use convenções de nomenclatura consistentes (camelCase para variáveis e métodos, PascalCase para classes).
                  // 6. Teste o código regularmente para garantir que ele funcione conforme o esperado.
                  // 7. Mantenha o código modular, dividindo-o em métodos e classes menores e mais gerenciáveis.
                  // 8. Use controle de versão (como Git) para rastrear alterações no código e colaborar com outros desenvolvedores.
                  // 9. Siga os princípios SOLID para design de software orientado a objetos.
                  // 10. Mantenha-se atualizado com as melhores práticas e padrões da comunidade C#.
#endregion
// Fim do programa principal