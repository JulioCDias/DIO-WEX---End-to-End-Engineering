using System.Globalization;
using ExemploExplorandoCsharp.Models; // Importando o namespace ExemploExplorandoCsharp.Models
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR"); // Definindo a cultura padrão para pt-BR

#region exemplo de interpolação de strings etc.
Pessoa pessoa = new Pessoa(); // Instanciando a classe Pessoa
pessoa.Nome = "João"; // Atribuindo valores às propriedades
pessoa.Sobrenome = "Silva"; // Atribuindo valores às propriedades
pessoa.Idade = 30; // Atribuindo valores às propriedades
pessoa.Apresentar(); // Chamando o método para apresentar a pessoa

Pessoa pessoa2 = new Pessoa(); // Instanciando outra classe Pessoa
pessoa2.Nome = "Maria"; // Atribuindo valores às propriedades
pessoa2.Sobrenome = "Oliveira"; // Atribuindo valores às propriedades
pessoa2.Idade = 25; // Atribuindo valores às propriedades
pessoa2.Apresentar(); // Chamando o método para apresentar a pessoa

Pessoa pessoa3 = new Pessoa("Carlos", "Pereira", 40); // Instanciando a classe Pessoa com o construtor com parâmetros
pessoa3.Apresentar(); // Chamando o método para apresentar a pessoa

Curso CursoDeIngles = new Curso(); // Instanciando a classe Curso
CursoDeIngles.Nome = "Curso de Inglês"; // Atribuindo o nome do curso
CursoDeIngles.Alunos = new List<Pessoa>(); // Inicializando a lista de alunos
CursoDeIngles.AdicionarAluno(pessoa); // Adicionando a primeira pessoa ao curso
CursoDeIngles.AdicionarAluno(pessoa2); // Adicionando a segunda pessoa ao curso
CursoDeIngles.ListarAlunos(); // Listando os alunos do curso

decimal valorMonetario = 1234.56m; // Declarando uma variável decimal
Console.WriteLine($"Valor monetário formatado: {valorMonetario:C}"); //Formatando o valor monetário como moeda C de Currancy
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))); // Exibindo o valor monetário formatado com a cultura English (United States)

// Exemplo de formatação de porcentagem
double porcentagem = .1234; // Declarando uma variável double
Console.WriteLine($"Porcentagem formatada: {porcentagem:P}"); //Formatando o valor como porcentagem P de Percent

//Formatando numeros
int numero = 123456789; // Declarando uma variável int
Console.WriteLine(numero.ToString("##-##-##-##_#")); // Exibindo o número formatado com máscara

// Exemplo de formatação de data
DateTime data = DateTime.Now; // Obtendo a data atual
Console.WriteLine($"Data formatada: {data:dd/MM/yyyy HH:mm:ss}"); //Formatando a data com o formato dd/MM/yyyy hh:mm:ss
// Exemplo de formatação de hora
TimeSpan hora = new TimeSpan(14, 30, 0); // Criando
// um TimeSpan representando 14 horas e 30 minutos
Console.WriteLine($"Hora formatada: {hora:hh\\:mm}"); //Formatando a hora com o formato hh:mm

System.Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

#endregion

#region  Exeções e Coleções

//Tratando uma possível exceção ao ler o arquivo
try
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt"); // Lendo os nomes do arquivo arquivoLeitura.txt
    foreach (string linha in linhas) // Iterando sobre cada linha do arquivo
    {
        Console.WriteLine(linha); // Exibindo cada linha lida
    }
}
catch (FileNotFoundException ex) // Capturando exceção de arquivo não encontrado
{
    Console.WriteLine($"Arquivo não encontrado: {ex.Message}"); // Exibindo mensagem de erro
}
catch (DirectoryNotFoundException ex) // Capturando exceção de diretório não encontrado
{
    Console.WriteLine($"Diretório não encontrado: {ex.Message}"); // Exibindo mensagem de erro
}
catch (Exception ex) // Capturando qualquer outra exceção
{
    Console.WriteLine($"Ocorreu um erro: {ex.Message}"); // Exibindo mensagem de erro genérica
}
finally // Bloco finally que sempre será executado, independentemente de uma exceção ter sido lançada ou não
{
    Console.WriteLine("Leitura do arquivo concluída."); // Mensagem de conclusão da leitura do arquivo
}
//Posso ter várias exceções para tratar erros específicos, como FileNotFoundException, DirectoryNotFoundException, etc.

//usando trhow para lançar uma exceção personalizada
new ExemploExcecao().Metodo1(); // Chamando o método que irá lançar uma exceção

//Exemplo de Queue

Queue<int> fila = new Queue<int>(); // Criando uma fila de inteiros
fila.Enqueue(1); // Adicionando o elemento 1 à fila
fila.Enqueue(2); // Adicionando o elemento 2 à fila
fila.Enqueue(3); // Adicionando o elemento 3 à fila
fila.Enqueue(4); // Adicionando o elemento 4 à fila
Console.WriteLine("Elementos na fila:"); // Exibindo mensagem antes de listar os elementos da fila

foreach (int item in fila) // Iterando sobre os elementos da fila
{
    Console.WriteLine(item); // Exibindo cada elemento da fila
}
// Removendo elementos da fila
Console.WriteLine($"Removendo: {fila.Dequeue()}"); // Remove e exibe o primeiro elemento da fila
Console.WriteLine($"Removendo: {fila.Dequeue()}"); // Remove e exibe o segundo elemento da fila
foreach (int item in fila) // Iterando sobre os elementos da fila
{
    Console.WriteLine(item); // Exibindo cada elemento da fila
}
// Exemplo de Stack
Stack<int> pilha = new Stack<int>(); // Criando uma pilha de inteiros
pilha.Push(1); // Adicionando o elemento 1 à pilha
pilha.Push(2); // Adicionando o elemento 2 à pilha
pilha.Push(3); // Adicionando o elemento 3 à pilha
pilha.Push(4); // Adicionando o elemento 4 à pilha
Console.WriteLine("Elementos na pilha:"); // Exibindo mensagem antes de listar os elementos da pilha
foreach (int item in pilha) // Iterando sobre os elementos da pilha
{
    Console.WriteLine(item); // Exibindo cada elemento da pilha
}
// Removendo elementos da pilha
Console.WriteLine($"Removendo: {pilha.Pop()}"); // Remove e exibe o último elemento adicionado à pilha
Console.WriteLine($"Removendo: {pilha.Pop()}"); // Remove e exibe o penúltimo elemento adicionado à pilha
foreach (int item in pilha) // Iterando sobre os elementos restantes da pilha
{
    Console.WriteLine(item); // Exibindo cada elemento restante da pilha
}
// Exemplo de Dictionary
Dictionary<int, string> dicionario = new Dictionary<int, string>(); // Criando um dicionário com chave do tipo int e valor do tipo string
dicionario.Add(1, "Um"); // Adicionando o par chave-valor
dicionario.Add(2, "Dois"); // Adicionando o par chave-valor
dicionario.Add(3, "Três"); // Adicionando o par chave-valor
Console.WriteLine("Elementos no dicionário:"); // Exibindo mensagem antes de listar os elementos do dicionário
foreach (KeyValuePair<int, string> item in dicionario) // Iterando sobre os pares chave-valor do dicionário
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}"); // Exibindo cada par chave-valor
}
// Removendo um elemento do dicionário
dicionario.Remove(2); // Removendo o elemento com chave 2
//alterando o valor de uma chave existente
dicionario[3] = "Três Modificado"; // Modificando o valor associado
Console.WriteLine("Elementos no dicionário após remoção:"); // Exibindo mensagem após a remoção
foreach (var item in dicionario) // Iterando sobre os pares chave-valor restantes do dicionário
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}"); // Exibindo cada par chave-valor restante
}
//Verifiacdno se uma chave existe no dicionário
if (dicionario.ContainsKey(1)) // Verificando se a chave 1 existe
{
    Console.WriteLine("Chave 1 existe no dicionário."); // Exibindo mensagem se a chave existir
}
else
{
    Console.WriteLine("Chave 1 não existe no dicionário."); // Exibindo mensagem se a chave não existir
}

#endregion