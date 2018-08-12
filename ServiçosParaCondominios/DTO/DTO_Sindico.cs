using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_Sindico : DTO_dadosPessoais
    {

        public string NomeCondominio { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }

	}
}
