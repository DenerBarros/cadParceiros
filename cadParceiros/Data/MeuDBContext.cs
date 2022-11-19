using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadParceiros.Data
{
    public class MeuDBContext : DbContext
    {
        public DbSet<Parceiro> Parceiros { get; set; }
        public MeuDBContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MeuDBContext).Assembly);
            base.OnModelCreating(modelBuilder);           
        }
    }
}
