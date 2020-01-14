using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoTarefasIPG.Models
{
    public class Professor
    {
        public int ProfessorId { get; set; }
        [Required]
        public string Nome { get; set; }
        public int Numero { get; set; }
        
        [EmailAddress]
        public string Email { get; set; }

        public string Disciplina { get; set; }


    }
}
