using System;
using System.Data;
using DTO;

namespace BLL
{
	class BLL_Conservadora : BLL_Base
	{
		

		public BLL_Conservadora()
		{
			tabela = "tbl_conservadora ";
		
			
		}
		public DTO_Conservadora ConsultarConservadoraLogin(string Email, string Senha)
		{
			try
			{
				string sql = "select * from "+tabela+" where email_conservadora= '" + Email + "' and senha_conservadora = '" + Senha + "'";
				DataTable dt = bd.ExecutarConsulta(sql);
				if (dt.Rows.Count == 1)
				{
                    DTO_Conservadora conservadora = new DTO_Conservadora();
                    conservadora.Id = (int)dt.Rows[0][0];

					//	Id = (int)dt.Rows[0][0],
					//	Nome = dt.Rows[0][1].ToString(),
					//	RazaoSocial = dt.Rows[0][2].ToString(),
					//	Email = dt.Rows[0][3].ToString(),
					//	Senha = dt.Rows[0][4].ToString(),
					//	Cnpj = dt.Rows[0][5].ToString(),
					//	Vip = Convert.ToInt32(dt.Rows[0][6].ToString()),
					//	Categoria = Convert.ToInt32(dt.Rows[0][7].ToString())

					//};

					return conservadora;
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


