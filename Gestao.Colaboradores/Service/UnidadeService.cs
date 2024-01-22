using Gestao.Colaboradores.Data;
using Gestao.Colaboradores.Interface;
using Gestao.Colaboradores.Models;
using Microsoft.EntityFrameworkCore;

namespace Gestao.Colaboradores.Service;

public class UnidadeService : IUnidadeService
{
    private readonly DataContext _context;

    public UnidadeService(DataContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public async Task<Unidade> CreateUnidade(Unidade unidade)
    {
        var novaUnidade = new Unidade
        {
            CodigoUnidade = Guid.NewGuid(),
            Nome = unidade.Nome,
            Status = unidade.Status,
            ColaboradorId = unidade.ColaboradorId
        };

        await _context.Unidade.AddAsync(unidade);
        await _context.SaveChangesAsync();
        return novaUnidade;
    }

    public async Task<List<Unidade>> GetUnidade()
    {
        return await _context.Unidade.ToListAsync();
    }
    public async Task<Unidade> PutUnidade(Unidade unidade, Guid id)
    {
        var unidadeAlterado = _context.Unidade.FirstOrDefault(x => x.Id == id);

        if (unidadeAlterado == null)
        {
            throw new Exception();
        }

        unidadeAlterado.Status = unidade.Status;

        _context.Unidade.Update(unidadeAlterado);

        await _context.SaveChangesAsync();

        return unidadeAlterado;
    }
}