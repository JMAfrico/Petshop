using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consultas_medicas.Models
{
    public class Veterinarios
    {
        public int codVeterinario { get; set; }

        public string nomeVeterinario { get; set; }

        public string sobrenomeVeterinario { get; set; }

        public string crmv { get; set; }

        public string especializacao { get; set; }

        public string enderecoVeterinario { get; set; }

        public string bairroVeterinario { get; set; }

        public string cepVeterinario { get; set; }

        public int numeroResidenciaVeterinario { get; set; }

        public string complementoVeterinario { get; set; }

        public string emailVeterinario { get; set; }

        public Int64 telefoneFixoVet { get; set; }

        public Int64 telefoneCelularVet { get; set; }
    }
}
