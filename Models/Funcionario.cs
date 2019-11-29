using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoTarefasIPG.Models
{
    public class Funcionario
    {
        public int IDFuncionario { get; set; }
        [Required]
        public string Nome { get; set; }

        public int Numero { get; set; }

        public int Idade { get; set; }

        public string Funcao { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}
