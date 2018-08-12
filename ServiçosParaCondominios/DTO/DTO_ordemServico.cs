using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_ordemServico
    {
        int id;
        DateTime dataAbertura;
        DateTime dataServico;
		Int16 vip;
        string senha;
        int horasContratadas;
        string descricao;
        string comentarios;
        int servico_id;
        int sindico_id;
        int funcionario_id;
		int conservadora_id;

        public int Id { get => id; set => id = value; }
        public DateTime DataAbertura { get => dataAbertura; set => dataAbertura = value; }
        public DateTime DataServico { get => dataServico; set => dataServico = value; }
        public string Senha { get => senha; set => senha = value; }
        public int HorasContratadas { get => horasContratadas; set => horasContratadas = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Comentarios { get => comentarios; set => comentarios = value; }
        public int Servico_id { get => servico_id; set => servico_id = value; }
        public int Sindico_id { get => sindico_id; set => sindico_id = value; }
        public int Funcionario_id { get => funcionario_id; set => funcionario_id = value; }
		public Int16 Vip { get => vip; set => vip = value; }
		public int Conservadora_id { get => conservadora_id; set => conservadora_id = value; }
	}
}
