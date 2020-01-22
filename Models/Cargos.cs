using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoTarefasIPG.Models
{
    public class Cargos
    {
        public int CargosId { get; set; }

        public string Nome { get; set; }

        public int Nível { get; set; }
        public ICollection<Funcionario> Funcionarios { get; set; }
    }
}
