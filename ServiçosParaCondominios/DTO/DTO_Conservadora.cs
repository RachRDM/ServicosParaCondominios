using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Conservadora : DTO_dadosPessoais
    {
		string razaoSocial;

		public string RazaoSocial { get => razaoSocial; set => razaoSocial = value; }
		public int Vip { get => vip; set => vip = value; }
		public int Categoria { get => categoria; set => categoria = value; }

		int vip;
		int categoria;

    }
}
