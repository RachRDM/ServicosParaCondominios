using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
	class BLL_Sindico : BLL_Base
	{

		private DTO_Sindico sindico = new DTO_Sindico();

		public BLL_Sindico()
		{
			tabela = "tbl_sindico";
		}

		public void RegistrarSindico(DTO_Sindico sindico)
		{
			try
			{
				string sql = string.Format("insert into " + tabela + " values(null,'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'); ", sindico.Nome, sindico.NomeCondominio, sindico.Email, sindico.Senha, sindico.Cnpj, sindico.Cep, sindico.Numero, sindico.Complemento);
				bd.ExecutarComandos(sql);
			}
			catch (Exception)
			{
				throw;
			}
		}

		public void AtualizarSindico(DTO_Sindico sindico)
		{
			try
			{
				string sql = string.Format("update " + tabela + " set `nome_sindico`='{0}',`nomecondominio_sindico`='{1}',`email_sindico`='{2}',`senha_sindico`='{3}',`cnpj_sindico`='{4}',`cep_sindico`='{5}',`numendereco_sindico`='{6}',`complemento_sindico`='{7}' WHERE id_sindico = '{8}'; ", sindico.Nome, sindico.NomeCondominio, sindico.Email, sindico.Senha, sindico.Cnpj, sindico.Cep, sindico.Numero, sindico.Complemento, sindico.Id);
				bd.ExecutarComandos(sql);
			}
			catch (Exception)
			{
				throw;
			}
		}
		public void DeletarSindico(DTO_Sindico sindico)
		{
			try
			{
				string sql = string.Format("delete from " + tabela + " where id_sindico='{0}'; ", sindico.Id);
				bd.ExecutarComandos(sql);
			}
			catch (Exception)
			{
				throw;
			}
		}

		public DTO_Sindico ConsultarSindicoLogin(string Email, string Senha)
		{
			try
			{
				string sql = "select * from tbl_sindico where email_sindico = '" + Email + "' and senha_sindico = '" + Senha + "'";
				DataTable dt = bd.ExecutarConsulta(sql);
				if (dt.Rows.Count == 1)
				{
					DTO_Sindico sindico = new DTO_Sindico
					{
						Id = (int)dt.Rows[0][0],
						Nome = dt.Rows[0][1].ToString(),
						NomeCondominio = dt.Rows[0][2].ToString(),
						Email = dt.Rows[0][3].ToString(),
						Senha = dt.Rows[0][4].ToString(),
						Cnpj = dt.Rows[0][5].ToString(),
						Cep = dt.Rows[0][6].ToString(),
						Numero = Convert.ToInt32(dt.Rows[0][7].ToString()),
						Complemento = dt.Rows[0][8].ToString()
					
					};

					return sindico;
				}
				else
				{
					return null;
				}
			}
			catch (Exception)
			{

				throw;
			}
		}
    }
}
