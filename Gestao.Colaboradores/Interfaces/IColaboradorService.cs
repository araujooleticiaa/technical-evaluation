using Gestao.Colaboradores.Models;

namespace Gestao.Colaboradores.Interface;
public interface IColaboradorService
{
    Task<List<Colaborador>> GetColaborador();
    Task<Colaborador> CreateColaborador(Colaborador colaborador);
    Task<Colaborador> PutColaborador(Colaborador colaborador, Guid id);
    Task<Colaborador> DeleteColaborador(Guid id);
}