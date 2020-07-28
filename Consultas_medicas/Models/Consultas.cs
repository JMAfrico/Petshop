using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consultas_medicas.Models
{
    public class Consultas 
    {
        public int codConsulta { get; set; }

        public string relatoConsulta { get; set; }

        public DateTime dataConsulta { get; set; }

        public DateTime horaConsulta { get; set; }

        public string CodCliente { get; set; }
    }
}
