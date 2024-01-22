using System.ComponentModel.DataAnnotations;
using Gestao.Colaboradores.Enums;

namespace Gestao.Colaboradores.Models;

public class Usuario : BaseModel
{
    public Usuario()
    {
        
    }
    public Usuario(string login, string senha, EStatus status)
    {
        Login = login;
        Senha = senha;
        Status = status;
    }

    public string Login { get; set; }
    public string Senha { get; set; }
    public EStatus Status { get; set; }
}