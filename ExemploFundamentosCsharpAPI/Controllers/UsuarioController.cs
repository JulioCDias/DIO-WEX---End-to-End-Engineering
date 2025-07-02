using Microsoft.AspNetCore.Mvc;

namespace ExemploFundamentosCsharpAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "Hello World!";
    }

    [HttpGet("ObterDataHoraAtual")]
    public IActionResult ObterDataHora()
    {
        var obj = new
        {
            Data = DateTime.Now.ToLongDateString(),
            Hora = DateTime.Now.ToLongTimeString()
        };
        return Ok(obj);
    }

    [HttpGet("Apresentar/{nome}/{idade}")]
    public IActionResult Apresentar(string nome, int idade)
    {
        var mensagem = $"Ola, meu nome é {nome} e tenho {idade} anos.";
        return Ok(mensagem);
    }
}
