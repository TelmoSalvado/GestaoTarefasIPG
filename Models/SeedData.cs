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
            PopulateFuncionario(db);
            PopulateCargos(db);
            PopulateProfessor(db);
        }
        public static async Task PopulateUsersAsync(UserManager<IdentityUser> userManager)
        {
           /* const string ADMIN_USERNAME = "administrador@ipg.pt";
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

          /* if (!await roleManager.RoleExistsAsync(ADMIN_ROLE))
            {
                await roleManager.CreateAsync(new IdentityRole(ADMIN_ROLE));
            }

            if (!await roleManager.RoleExistsAsync(FUNCIONARIO_ROLE))
            {
                await roleManager.CreateAsync(new IdentityRole(FUNCIONARIO_ROLE));
            }*/
        }
        private static void PopulateFuncionario(GestaoTarefasIPGContext db)
        {
            if (db.Funcionario.Any())
            {
                return;
            }
            db.Funcionario.AddRange(
                new Funcionario { Nome = "Gonçalo Santos", Idade = 32, Email = "goncalo@gmail.com", Numero = 1700780, Funcao = "Secretario" },
                new Funcionario { Nome = "Leonel Rita", Idade = 22, Email = "leonel@gmail.com", Numero = 1705250, Funcao = "Vice Diretor" },
                new Funcionario { Nome = "Telmo Salvado", Idade = 18, Email = "telmo@gmail.com", Numero = 17552780, Funcao = "Diretor" },
                new Funcionario { Nome = "Teste1", Idade = 18, Email = "teste@1.com", Numero = 17552780, Funcao = "Tester" },
                new Funcionario { Nome = "Teste1", Idade = 18, Email = "teste@1.com", Numero = 17552780, Funcao = "Tester" },
                new Funcionario { Nome = "Teste1", Idade = 18, Email = "teste@1.com", Numero = 17552780, Funcao = "Tester" },
                new Funcionario { Nome = "Teste1", Idade = 18, Email = "teste@1.com", Numero = 17552780, Funcao = "Tester" },
                new Funcionario { Nome = "Teste1", Idade = 18, Email = "teste@1.com", Numero = 17552780, Funcao = "Tester" },
                new Funcionario { Nome = "Teste1", Idade = 18, Email = "teste@1.com", Numero = 17552780, Funcao = "Tester" },
                new Funcionario { Nome = "Teste1", Idade = 18, Email = "teste@1.com", Numero = 17552780, Funcao = "Tester" },
                new Funcionario { Nome = "Teste1", Idade = 18, Email = "teste@1.com", Numero = 17552780, Funcao = "Tester" },
                new Funcionario { Nome = "Teste1", Idade = 18, Email = "teste@1.com", Numero = 17552780, Funcao = "Tester" },
                new Funcionario { Nome = "Teste1", Idade = 18, Email = "teste@1.com", Numero = 17552780, Funcao = "Tester" },
                new Funcionario { Nome = "Teste1", Idade = 18, Email = "teste@1.com", Numero = 17552780, Funcao = "Tester" }, 
                new Funcionario { Nome = "Teste1", Idade = 18, Email = "teste@1.com", Numero = 17552780, Funcao = "Tester" },
                new Funcionario { Nome = "Teste1", Idade = 18, Email = "teste@1.com", Numero = 17552780, Funcao = "Tester" },
                new Funcionario { Nome = "Teste1", Idade = 18, Email = "teste@1.com", Numero = 17552780, Funcao = "Tester" }, 
                new Funcionario { Nome = "Teste1", Idade = 18, Email = "teste@1.com", Numero = 17552780, Funcao = "Tester" },
                new Funcionario { Nome = "Teste1", Idade = 18, Email = "teste@1.com", Numero = 17552780, Funcao = "Tester" }, 
                new Funcionario { Nome = "Teste1", Idade = 18, Email = "teste@1.com", Numero = 17552780, Funcao = "Tester" },
                new Funcionario { Nome = "Teste1", Idade = 18, Email = "teste@1.com", Numero = 17552780, Funcao = "Tester" },
                new Funcionario { Nome = "Teste1", Idade = 18, Email = "teste@1.com", Numero = 17552780, Funcao = "Tester" }, 
                new Funcionario { Nome = "Teste1", Idade = 18, Email = "teste@1.com", Numero = 17552780, Funcao = "Tester" },
                new Funcionario { Nome = "Teste1", Idade = 18, Email = "teste@1.com", Numero = 17552780, Funcao = "Tester" }, 
                new Funcionario { Nome = "Teste1", Idade = 18, Email = "teste@1.com", Numero = 17552780, Funcao = "Tester" },
                new Funcionario { Nome = "Teste1", Idade = 18, Email = "teste@1.com", Numero = 17552780, Funcao = "Tester" }
                );
            
            db.SaveChanges();
        }
        private static void PopulateCargos(GestaoTarefasIPGContext db)
        {
            if (db.Cargos.Any())
            {
                return;
            }
            db.Cargos.AddRange(
                new Cargos { Nome = "Diretor", Nível = 5 },
                new Cargos { Nome = "Tesoureiro", Nível = 3 },
                new Cargos { Nome = "Limpeza", Nível = 1 }
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


    }
}


