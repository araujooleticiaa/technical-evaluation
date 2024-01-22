using Gestao.Colaboradores.Models;
using Microsoft.EntityFrameworkCore;

namespace Gestao.Colaboradores.Data;
public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Colaborador> Colaboradores { get; set; }
    public DbSet<Unidade> Unidade { get; set; }
}
