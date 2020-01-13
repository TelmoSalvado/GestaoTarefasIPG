using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoTarefasIPG.Models
{
    public class CargosViewModel
    {
        public IEnumerable<Cargos> Cargos { get; set; }

        public int PaginaAtual { get; set; }

        public int TotalPaginas { get; set; }

        public int PrimeiraPagina { get; set; }

        public int UltimaPagina { get; set; }

        public string StringProcura { get; set; }

    }
}

