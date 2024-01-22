namespace Gestao.Colaboradores.Models;

public class Colaborador : BaseModel
{
    public Colaborador()
    {
        
    } 

    public string Nome { get; set; }
    public Usuario Usuario { get; set; }
    public Unidade Unidade { get; set; }
}