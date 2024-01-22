using Gestao.Colaboradores.Interface;
using Gestao.Colaboradores.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gestao.Colaboradores.Controllers;

[ApiController]
public class UsuarioController : ControllerBase
{
    private readonly IUsuarioService _usuarioService;
    public UsuarioController(IUsuarioService usuarioService)
    {
        _usuarioService = usuarioService;
    }

    [HttpPost("/criar-usuario")]
    public async Task<ActionResult<Usuario>> CreateUsuario(Usuario usuario)
    {
        try
        {
            var result = await _usuarioService.CreateUsuario(usuario);
            return Ok(result);
        }
        catch
        {
            return StatusCode(500, "Internal server failure.");
        }
    }

    [HttpGet("/buscar-usuario")]
    public async Task<ActionResult<List<Usuario>>> GetUsuario()
    {
        try
        {
            var result = await _usuarioService.GetUsuario();
            return Ok(result);
        }
        catch
        {
            return StatusCode(500, "Internal server failure.");
        }
    }

    [HttpPut("/alterar-usuario/{id:guid}")]
    public async Task<ActionResult<Usuario>> PutUsuario(
            [FromRoute] Guid id,
            [FromBody] Usuario usuario)
    {
       
        try
        { 
            var result = await _usuarioService.PutUsuario(usuario, id);
            return Ok(result);
        }
        catch
        {
            return StatusCode(500, "Internal server failure.");
        }
    }

    [HttpGet("/buscar-usuario/{id:guid}")]
    public async Task<ActionResult<List<Usuario>>> GetUsuarioId(
         [FromRoute] Guid id)
    {
        try
        {
            var result = await _usuarioService.GetUsuarioId(id);
            return Ok(result);
        }
        catch
        {
            return StatusCode(500, "Internal server failure.");
        }
    }
}
