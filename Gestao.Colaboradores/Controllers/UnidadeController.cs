using Gestao.Colaboradores.Interface;
using Gestao.Colaboradores.Models;
using Gestao.Colaboradores.Service;
using Microsoft.AspNetCore.Mvc;

namespace Gestao.Colaboradores.Controllers;

[ApiController]
[Route("[controller]")]
public class UnidadeController : ControllerBase
{
    private readonly IUnidadeService _unidadeService;

    public UnidadeController(IUnidadeService unidadeService)
    {
        _unidadeService = unidadeService;
    }

    [HttpPost]
    public async Task<ActionResult<Unidade>> CreateUnidade(Unidade unidade)
    {
        try
        {
            var result = await _unidadeService.CreateUnidade(unidade);
            return Ok(result);
        }
        catch
        {
            return StatusCode(500, "Internal server failure.");
        }
    }

    [HttpGet("listar-unidades")]
    public async Task<ActionResult<List<Unidade>>> GetUnidade()
    {
        try
        {
            var result = await _unidadeService.GetUnidade();
            return Ok(result);
        }
        catch
        {
            return StatusCode(500, "Internal server failure.");
        }
    }

    [HttpPut("/alterar-unidade/{id:guid}")]
    public async Task<ActionResult<Usuario>> PutUsuario(
            [FromRoute] Guid id,
            [FromBody] Usuario usuario)
    {

        try
        {
            var result = await _unidadeService.PutUsuario(usuario, id);
            return Ok(result);
        }
        catch
        {
            return StatusCode(500, "Internal server failure.");
        }
    }
}
