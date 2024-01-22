using System;
using System.Runtime.Intrinsics.X86;
using Azure;
using Gestao.Colaboradores.Data;
using Gestao.Colaboradores.Interface;
using Gestao.Colaboradores.Models;
using Microsoft.EntityFrameworkCore;

namespace Gestao.Colaboradores.Service;

public class ColaboradorService : IColaboradorService
{
    private readonly DataContext _context;

    public ColaboradorService(DataContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public async Task<Colaborador> CreateColaborador(Colaborador colaborador)
    {
        var novoColaborador =  new Colaborador
        {
            Nome = colaborador.Nome,
            Usuario = new Usuario
            {
                Login = colaborador.Usuario.Login,
                Senha = colaborador.Usuario.Senha,
                Status = colaborador.Usuario.Status,
            },
            Unidade = new Unidade
            {
                Nome = colaborador.Unidade.Nome,
                CodigoUnidade = colaborador.Unidade.CodigoUnidade,
                Status =  colaborador.Unidade.Status,
            },
        };

        await _context.Colaboradores.AddAsync(novoColaborador);
        await _context.Usuarios.AddAsync(novoColaborador.Usuario);
        await _context.Unidade.AddAsync(novoColaborador.Unidade);

        await _context.SaveChangesAsync();

        return novoColaborador;
    }

    public async Task<List<Colaborador>> GetColaborador()
    {
        return await _context.Colaboradores
                .Include(unidade => unidade.Unidade)
                .Include(usuario => usuario.Usuario)
                .ToListAsync();
    }

    public async Task<Colaborador> PutColaborador(Colaborador colaborador, Guid id)
    {
        var colaboradorAlterado = _context.Colaboradores.FirstOrDefault(x => x.Id == id);

        if (colaboradorAlterado == null)
        {
            throw new Exception();
        }

        colaboradorAlterado.Nome = colaborador.Nome;

        _context.Colaboradores.Update(colaboradorAlterado);

        await _context.SaveChangesAsync();

        return colaboradorAlterado;
    }

    public async Task<Colaborador> DeleteColaborador(Guid id)
    {
        var colaborador = _context.Colaboradores.FirstOrDefault(x => x.Id == id);
        
        _context.Colaboradores.Remove(colaborador);

        await _context.SaveChangesAsync();
        return colaborador;
    }
}