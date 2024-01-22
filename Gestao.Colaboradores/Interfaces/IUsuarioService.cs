using Gestao.Colaboradores.Enums;
using Gestao.Colaboradores.Models;

namespace Gestao.Colaboradores.Interface;
public interface IUsuarioService
{
    Task<List<Usuario>> GetUsuario();
    Task<Usuario> CreateUsuario(Usuario usuario);
    Task<Usuario> PutUsuario(Usuario usuario, Guid id);
    Task<Usuario> GetUsuarioId(Guid id);
}