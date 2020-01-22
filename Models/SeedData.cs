using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoTarefasIPG.Models
{
    public class SeedData
    {
        private const string ADMIN_ROLE = "admin";
        private const string FUNCIONARIO_ROLE = "func";
        public static void Populate(GestaoTarefasIPGContext db)
        {
            
            PopulateCargos(db);
            PopulateProfessor(db);
            PopulateFuncionario(db);
        }
        public static async Task PopulateUsers(UserManager<IdentityUser> userManager)
        {
            /*const string ADMIN_USERNAME = "administrador@ipg.pt";
             const string ADMIN_PASSWORD = "Qualquer123";

             const string FUNC_USERNAME = "funcionario@ipg.pt";
             const string FUNC_PASSWORD = "Qualquer123";

             IdentityUser user = await userManager.FindByNameAsync(ADMIN_USERNAME);
             if (user == null)
             {
                 user = new IdentityUser
                 {
                     UserName = ADMIN_USERNAME,
                     Email = ADMIN_USERNAME
                 };

                 await userManager.CreateAsync(user, ADMIN_PASSWORD);
             }

             if (!await userManager.IsInRoleAsync(user, ADMIN_ROLE))
             {
                 await userManager.AddToRoleAsync(user, ADMIN_ROLE);
             }

             user = await userManager.FindByNameAsync(FUNC_USERNAME);
             if (user == null)
             {
                 user = new IdentityUser
                 {
                     UserName = FUNC_USERNAME,
                     Email = FUNC_USERNAME
                 };

                 await userManager.CreateAsync(user, FUNC_PASSWORD);
             }

             if (!await userManager.IsInRoleAsync(user, FUNCIONARIO_ROLE))
             {
                 await userManager.AddToRoleAsync(user, FUNCIONARIO_ROLE);
             }

             user = await userManager.FindByNameAsync("test@ipg.pt");
             if (user == null)
             {
                 user = new IdentityUser
                 {
                     UserName = "test@ipg.pt",
                     Email = "test@ipg.pt"
                 };

                 await userManager.CreateAsync(user, ADMIN_PASSWORD);
             }*/
        }


        public static async Task CreateRolesAsync(RoleManager<IdentityRole> roleManager)
        {

          if (!await roleManager.RoleExistsAsync(ADMIN_ROLE))
            {
                await roleManager.CreateAsync(new IdentityRole(ADMIN_ROLE));
            }

            if (!await roleManager.RoleExistsAsync(FUNCIONARIO_ROLE))
            {
                await roleManager.CreateAsync(new IdentityRole(FUNCIONARIO_ROLE));
            }
        }
       
        private static void PopulateCargos(GestaoTarefasIPGContext db)
        {
            if (db.Cargos.Any())
            {
                return;
            }
            db.Cargos.AddRange(
                new Cargos { Nome = "Diretor da escola", Nível = 4},
                new Cargos { Nome = "Tesoureiro", Nível = 3 },
                new Cargos { Nome = "Limpeza", Nível = 1 },
                new Cargos { Nome = "Vice-Diretor", Nível = 4 },
                new Cargos { Nome = "Secretário", Nível = 2 },
                new Cargos { Nome = "Contabilista", Nível = 3 },
                new Cargos { Nome = "Rececionista", Nível = 1 },
                new Cargos { Nome = "Técnico", Nível = 2 },
                new Cargos { Nome = "Diretor do Ipg", Nível = 5},
                new Cargos { Nome = "Professor", Nível = 3 }
                );

            db.SaveChanges();
        }
        private static void PopulateProfessor(GestaoTarefasIPGContext db)
        {
            if (db.Professor.Any())
            {
                return;

            }
            db.Professor.AddRange(
               new Professor { Nome = "Leonel", Numero = 1234567, Email = "Leonel@ipg.pt", Disciplina = "IP"},
               new Professor { Nome = "Carlos Carreto", Numero = 74554, Email = "carreto@ipg.pt", Disciplina = "Algoritmos" },
               new Professor { Nome = "Teste", Numero = 000000, Email = "teste@gmail.pt", Disciplina = "teste" },
               new Professor { Nome = "Gonçalo", Numero = 170023, Email = "Goncalo@ipg.pt", Disciplina = "IA" },
               new Professor { Nome = "Telmo", Numero = 1546123, Email = "Telmo@ipg.pt", Disciplina = "CG"  },
               new Professor { Nome = "Ariana", Numero = 123478, Email = "Ariana@ipg.pt", Disciplina = "CG" },
               new Professor { Nome = "Jose", Numero = 1546123, Email = "Telmo@ipg.pt", Disciplina = "CG" },
               new Professor { Nome = "Aldina", Numero = 1546123, Email = "Telmo@ipg.pt", Disciplina = "CG" },
               new Professor { Nome = "Ana", Numero = 1546123, Email = "Telmo@ipg.pt", Disciplina = "CG" },
               new Professor { Nome = "Andre", Numero = 1546123, Email = "Telmo@ipg.pt", Disciplina = "CG" }
                );
            db.SaveChanges();
        }

        private static void PopulateFuncionario(GestaoTarefasIPGContext db)
        {

            if (db.Funcionario.Any())
            {
                return;
            }
            db.Funcionario.AddRange(
                new Funcionario { Nome = "Gonçalo Santos", Idade = 32, Email = "goncalo@gmail.com", Numero = 1700780, CargosId = 1 },
                new Funcionario { Nome = "Leonel Rita", Idade = 22, Email = "leonel@gmail.com", Numero = 1705250, CargosId = 2 },
                new Funcionario { Nome = "Telmo Salvado", Idade = 18, Email = "telmo@gmail.com", Numero = 17552780, CargosId = 3 },
                new Funcionario { Nome = "Manuel Proença", Idade = 48, Email = "manu@gmail.com", Numero = 1755230, CargosId = 4 },
                new Funcionario { Nome = "Manuela Tobias", Idade = 50, Email = "manuela@gmail.com", Numero = 1123230, CargosId = 5 },
                new Funcionario { Nome = "Raquel Gomes", Idade = 20, Email = "raqui@gmail.com", Numero = 212580, CargosId = 6 },
                new Funcionario { Nome = "Jéssica Trindade", Idade = 25, Email = "jessica@gmail.com", Numero = 1712312, CargosId = 7 },
                new Funcionario { Nome = "Maria Antónia", Idade = 55, Email = "maria@gmail.com", Numero = 11231230, CargosId = 8 },
                new Funcionario { Nome = "António Manuel", Idade = 35, Email = "to@gmail.com", Numero = 1755230, CargosId = 9 },
                new Funcionario { Nome = "Joao Miguel", Idade = 48, Email = "joao@gmail.com", Numero = 1755230, CargosId = 10 }


                );

            db.SaveChanges();
        }


    }
}


