using Gestao.Colaboradores.Interface;
using Gestao.Colaboradores.Models;
using Gestao.Colaboradores.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Gestao.Colaboradores.Controllers;

[ApiController]
[Route("[controller]")]
public class ColaboradorController : ControllerBase
{
    private readonly IColaboradorService _colaboradorService;
    public ColaboradorController(IColaboradorService colaboradorService)
    {
        _colaboradorService = colaboradorService;
    }

    [HttpPost]
    public async Task<ActionResult<Colaborador>> CreateTransactions(Colaborador colaborador)
    {
        try
        {
            var result = await _colaboradorService.CreateColaborador(colaborador);
            return Ok(result);
        }
        catch
        {
            return StatusCode(500, "Internal server failure.");
        }
    }

    [HttpGet("listar-colaboradores")]
    public async Task<ActionResult<List<Colaborador>>> GetColaborador()
    {
        try
        {
            var result = await _colaboradorService.GetColaborador();
            return Ok(result);
        }
        catch
        {
            return StatusCode(500, "Internal server failure.");
        }
    }

    [HttpPut("/alterar-colaborador/{id:guid}")]
    public async Task<ActionResult<Colaborador>> PutUsuario(
            [FromRoute] Guid id,
            [FromBody] Colaborador colaborador)
    {
        try
        {
            var result = await _colaboradorService.PutColaborador(colaborador, id);
            return Ok(result);
        }
        catch
        {
            return StatusCode(500, "Internal server failure.");
        }
    }

    [HttpDelete("/deletar-colaborador/{id:guid}")]
    public async Task<ActionResult<Colaborador>> DeleteColaborador([FromRoute] Guid id)
    {
        return await _colaboradorService.DeleteColaborador(id);
    }
}
