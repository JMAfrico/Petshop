using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consultas_medicas.Models
{
    public class Funcionarios
    {
        public int codFuncionario { get; set; }

        public string nomeFuncionario { get; set; }

        public string sobrenomeFuncionario { get; set; }

        public string emailFuncionario { get; set; }

        public Int64 telefoneFixoFunc { get; set; }

        public Int64 telefoneCelularFunc { get; set; }

        public string enderecoFuncionario { get; set; }

        public string bairroFuncionario { get; set; }

        public string cepFuncionario { get; set; }

        public int numeroResidenciaFuncionario { get; set; }

        public string complementoFuncionario { get; set; }

    }
}
