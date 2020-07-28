using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consultas_medicas.Models
{
    //PASSO 2 : CRIAR UMA CLASSE COM OS MESMOS ATRIBUTOS DO TABELA DO BANCO
    public class Animais
    {
        public int codAnimal { get; set; }

        public string sexoAnimal { get; set; }

        public string descricaoAnimal { get; set; }

        //public string nomeAnimal { get; set; }
    }
}
