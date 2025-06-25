using System.Globalization;
using ExemploExplorandoCsharp.Models; // Importando o namespace ExemploExplorandoCsharp.Models
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR"); // Definindo a cultura padrão para pt-BR

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
