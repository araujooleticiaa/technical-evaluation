using Gestao.Colaboradores.Data;
using Gestao.Colaboradores.Enums;
using Gestao.Colaboradores.Interface;
using Gestao.Colaboradores.Models;
using Microsoft.EntityFrameworkCore;

namespace Gestao.Colaboradores.Service;

public class UsuarioService : IUsuarioService
{
    private readonly DataContext _context;

    public UsuarioService(DataContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public async Task<Usuario> CreateUsuario(Usuario usuario)
    {
        var novoUsuario = new Usuario
        {
            Id = usuario.Id,
            Login = usuario.Login,
            Senha = usuario.Senha,
            Status = usuario.Status,
        };

        await _context.Usuarios.AddAsync(usuario);
        await _context.SaveChangesAsync();

        return novoUsuario;
    }

    public async Task<List<Usuario>> GetUsuario()
    {
        return await _context.Usuarios.ToListAsync();
    }

    public async Task<Usuario> PutUsuario(Usuario usuario, Guid id)
    {
        var usuarioAlterado  = _context.Usuarios.FirstOrDefault(x => x.Id == id);

        if(usuarioAlterado == null)
        {
            throw new Exception();
        }

        usuarioAlterado.Senha = usuario.Senha;
        usuarioAlterado.Status = usuario.Status;

        _context.Usuarios.Update(usuarioAlterado);

        await _context.SaveChangesAsync();

        return usuarioAlterado;
    }

    public async Task<Usuario> GetUsuarioId(Guid id)
    {
        var usuario = _context.Usuarios.FirstOrDefault(x => x.Id == id);
        return usuario;
    }
}