namespace ExemploExplorandoCsharp.Models;

/// <summary>
/// Classe que representa uma pessoa fisica.
/// </summary>
public class Pessoa // Classe Pessoa
{
    private string _nome; // Campo privado para armazenar o nome da pessoa
    /// <summary>
    /// Propriedade Nome da pessoa.
    /// </summary>
    public string Nome
    {
        // Propriedade Nome com getter e setter, com o Body Expression
        get => _nome.ToUpper(); // Retorna o valor do campo privado _nome
        // exemplo mais verboso de propriedade com getter e setter
        // get
        // {
        //     return _nome.ToUpper(); // Retorna o valor do campo privado _nome
        // }

        set
        {
            if (value == "") // Verifica se o nome está vazio
            {
                throw new ArgumentException("O nome não pode ser vazio."); // Lança uma exceção se o nome for vazio
            }
            _nome = value; // Atribui o valor à variável privada _nome
        }
    } //Propriedades tem getters e setters

    private int _idade; // Campo privado para armazenar a idade da pessoa
    /// <summary>
    /// Propriedade Idade da pessoa.
    /// </summary>
    public int Idade
    {
        get => _idade; // Retorna o valor do campo privado _idade
        set
        {
            if (value < 0) // Verifica se a idade é negativa
            {
                throw new ArgumentException("A idade não pode ser negativa."); // Lança uma exceção se a idade for negativa
            }
            _idade = value; // Atribui o valor à variável privada _idade
        }
    }
    /// <summary>
    /// Método para apresentar a pessoa.
    /// </summary>
    public void Apresentar() // Método para apresentar a pessoa
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
    }
}
