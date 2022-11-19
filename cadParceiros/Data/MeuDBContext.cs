using Microsoft.EntityFrameworkCore;

namespace cadParceiros.Data;

public class MeuDBContext : DbContext
{
    public DbSet<Parceiro> Parceiros { get; set; }    
    public MeuDBContext() : base()
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Integrated Security=true;Database=CadastroParceiros;");           
       
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(MeuDBContext).Assembly);
        base.OnModelCreating(modelBuilder);           
    }
}
