using Gestao.Colaboradores.Models;

namespace Gestao.Colaboradores.Interface;
public interface IUnidadeService
{
    Task<List<Unidade>> GetUnidade();
    Task<Unidade> CreateUnidade(Unidade unidade);
    Task<Unidade> PutUnidade(Unidade unidade, Guid id);
}