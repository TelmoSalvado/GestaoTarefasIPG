using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GestãoTarefasIPG.Models;

namespace GestãoTarefasIPG.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<GestãoTarefasIPG.Models.Funcionario> Funcionario { get; set; }
        public DbSet<GestãoTarefasIPG.Models.Cargos> Cargos { get; set; }
        
    }
}
