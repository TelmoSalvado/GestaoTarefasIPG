using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GestãoTarefasIPG.Models
{
    public class GestaoTarefasIPGContext : DbContext
    {
        public GestaoTarefasIPGContext (DbContextOptions<GestaoTarefasIPGContext> options)
            : base(options)
        {
        }

        public DbSet<GestãoTarefasIPG.Models.Funcionario> Funcionario { get; set; }
        public DbSet<GestãoTarefasIPG.Models.Cargos> Cargos { get; set; }

        public DbSet<GestãoTarefasIPG.Models.Professor> Professor { get; set; }
    }
}
