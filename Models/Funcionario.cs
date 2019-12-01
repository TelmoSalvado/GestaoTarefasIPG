﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoTarefasIPG.Models
{
    public class Funcionario
    {
        public int FuncionarioId { get; set; }
        [Required(ErrorMessage = "Por favor, insira um nome")]
        public string Nome { get; set; }
      
        public int Numero { get; set; }
       
        public int Idade { get; set; }
        [Required(ErrorMessage = "Por favor, insira uma função")]
        public string Funcao { get; set; }
        [Required(ErrorMessage = "Por favor, insira um e-mail")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
