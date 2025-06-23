using ExemploExplorandoCsharp.Models; // Importando o namespace ExemploExplorandoCsharp.Models

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