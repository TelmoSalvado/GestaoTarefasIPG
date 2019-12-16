using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoTarefasIPG.Models
{
    public class SeedData
    {
        public static void Populate(GestaoTarefasIPGContext db)
        {
            PopulateFuncionario(db);
            PopulateCargos(db);
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


    }
}


