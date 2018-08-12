using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using DTO;

namespace BLL
{
    class BLL_Relatorio : BLL_Base
    {

        public DataTable ListarOSparaSindico()
        {
            try
            {
                string sql = "select * from view_os_sindico ;";
                return bd.ExecutarConsulta(sql);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable ListarOSporSindico (DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                string sql = "SELECT `nome_sindico`, `dataabertura_os`, `dataservico_os`, `vip_os`, `horacontratadas_os`, `descricao_os`, `comentarios_os` FROM tbl_os inner join tbl_sindico on tbl_os.tbl_sindico_id_sindico = tbl_sindico.id_sindico where dataabertura_os between '" + dataInicio.ToString("yyyy/MM/dd") + "' and '" + dataFim.ToString("yyyy/MM/dd") + "'";
                return bd.ExecutarConsulta(sql);
            }
            catch (Exception)
            {

                throw;
            }
        }

		public DataTable ListarOSporSindico(int id_sindico)
		{
			try
			{
				string sql = "SELECT `nome_sindico`, `dataabertura_os`, `dataservico_os`, `vip_os`, `horacontratadas_os`, `descricao_os`, `comentarios_os` FROM tbl_os inner join tbl_sindico on tbl_os.tbl_sindico_id_sindico = tbl_sindico.id_sindico where tbl_os.tbl_sindico_id_sindico = " +id_sindico ; 
				return bd.ExecutarConsulta(sql);
			}
			catch (Exception)
			{

				throw;
			}
		}

		public DataTable ListarOSporServico(int id_servico)
        {
            try
            {
                string sql = "SELECT descricao_servico, dataabertura_os, dataservico_os, descricao_os, horacontratadas_os FROM `tbl_os` os INNER join `tbl_servicos` serv on os.tbl_servicos_id_servico = serv.id_servico where os.tbl_servicos_id_servico = " + id_servico;
                return bd.ExecutarConsulta(sql);
            }
            catch (Exception)
            {

                throw;
            }
        }

		public DataTable ListarOSporFuncionario(int id_funcionario)
		{
			try
			{
				string sql = "SELECT nome_funcionario, dataabertura_os, dataservico_os, descricao_os, horacontratadas_os FROM `tbl_os` os INNER join `tbl_funcionario` func on os.tbl_funcionario_id_funcionario = func.id_funcionario where os.tbl_funcionario_id_funcionario = " + id_funcionario;
				return bd.ExecutarConsulta(sql);
			}
			catch (Exception)
			{

				throw;
			}
		}

		public DataTable ListarOSporConservadora(int id_conservadora)
		{
			try
			{
				string sql = "SELECT nome_conservadora, dataabertura_os, dataservico_os, descricao_os, horacontratadas_os from tbl_os os INNER join tbl_funcionario func on os.tbl_funcionario_id_funcionario = func.id_funcionario inner join tbl_conservadora cons on cons.id_conservadora = func.tbl_conservadora_id_conservadora WHERE func.tbl_conservadora_id_conservadora = "+ id_conservadora+ " ;";
				return bd.ExecutarConsulta(sql);
			}
			catch (Exception)
			{

				throw;
			}
		}

		//public DataTable ListarRelatorioOS(string condicao)
		//{
		//	try
		//	{
		//		string sql = "SELECT descricao_servico, dataabertura_os, dataservico_os, descricao_os, horacontratadas_os FROM `tbl_os` os INNER join `tbl_servicos` serv on os.tbl_servicos_id_servico = serv.id_servico where " + condicao;
		//		return bd.ExecutarConsulta(sql);
		//	}
		//	catch (Exception)
		//	{

		//		throw;
		//	}
		//}

	}
}
