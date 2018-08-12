using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
     class BLL_Base
    {
        protected Conexao bd = new Conexao("redeconservadora");
        protected string tabela;

        public BLL_Base()
        {
            tabela = "";
        }

        // metodos
        public DataTable Listar_Registros()
        {
            try
            {
                string sql = "select * from " + tabela;
                return bd.ExecutarConsulta(sql);

            }
            catch (Exception)
            {
                throw;
            }

			
			
		}
	}
}
