using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_dadosPessoais
    {
        int id;
        string nome;
        string email;
        string senha;
        string cnpj;
        string cep;
        string telefone;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Telefone { get => telefone; set => telefone = value; }
    }
}
