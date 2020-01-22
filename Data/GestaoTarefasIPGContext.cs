using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GestaoTarefasIPG.Models
{
    public class GestaoTarefasIPGContext : DbContext
    {
        public GestaoTarefasIPGContext(DbContextOptions<GestaoTarefasIPGContext> options)
            : base(options)
        {
        }


        public DbSet<GestaoTarefasIPG.Models.Cargos> Cargos { get; set; }

        public DbSet<GestaoTarefasIPG.Models.Professor> Professor { get; set; }
        public DbSet<GestaoTarefasIPG.Models.Funcionario> Funcionario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Funcionario>()
                .HasOne(mm => mm.Cargos)
                .WithMany(m => m.Funcionarios)
                .HasForeignKey(mm => mm.CargosId)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }

}