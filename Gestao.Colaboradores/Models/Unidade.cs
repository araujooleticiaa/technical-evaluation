using Gestao.Colaboradores.Enums;

namespace Gestao.Colaboradores.Models;

public class Unidade : BaseModel
{
    public Unidade()
    {
    }

    public Unidade(string nome, EStatus status)
    {
        CodigoUnidade = Guid.NewGuid();
        Nome = nome;
        Status = status;
    }

    public Guid CodigoUnidade { get; set; }
    public string Nome { get; set; }
    public EStatus Status { get; set; }
    public Guid? ColaboradorId { get; set; }
}