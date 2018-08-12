using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace BLL
{
	class BLL_OrdemServico : BLL_Base
	{

		public BLL_OrdemServico()
		{
			tabela = "tbl_os";
		}

		public void RegistrarOs(DTO_ordemServico os)
		{
			try
			{
				string sql = string.Format("insert into " + tabela + " values(null,'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}',null); ", os.DataAbertura.ToString("yyyy-MM-dd hh-mm-ss"), os.DataServico.ToString("yyyy-MM-dd hh-mm-ss"), os.Vip, os.HorasContratadas, os.Descricao, os.Comentarios, os.Servico_id, os.Sindico_id);
				bd.ExecutarComandos(sql);
			}
			catch (Exception)
			{
				throw;
			}
		}
		public DataTable AceitarOs(int Funcionario_id, int Conservadora_id, int Os_Id)
		{
			try
			{
				string sql = "update" + tabela + " set `tbl_funcionario_id_funcionario`= "+ Funcionario_id + " ,`tbl_conservadora_id_conservadora`= "+ Conservadora_id +" where id_os = "+Os_Id+" ;";
				return bd.ExecutarConsulta(sql);
			}
			catch (Exception)
			{

				throw;
			}
		}

		public void AtualizarOs(DTO_ordemServico os)
		{
			try
			{
			
				string sql = string.Format("update " + tabela + "  SET `dataabertura_os`='{0}',`dataservico_os`='{1}',`vip_os`='{2}',`horacontratadas_os`='{3}',`descricao_os`='{4}',`comentarios_os`='{5}',`tbl_servicos_id_servico`='{6}' WHERE id_os={7} and tbl_sindico_id_sindico='{8}'", os.DataAbertura.ToString("yyyy-MM-dd hh-mm-ss"), os.DataServico.ToString("yyyy-MM-dd hh-mm-ss"), os.Vip, os.HorasContratadas, os.Descricao, os.Comentarios, os.Servico_id, os.Id, os.Sindico_id);
				 bd.ExecutarComandos(sql);
                
			}
			catch (Exception)
			{
				throw;
			}
		}
		public void DeletarOs(DTO_ordemServico os)
		{
			try
			{
				string sql = string.Format("delete from " + tabela + " where id_os='{0}'", os.Id);
				bd.ExecutarComandos(sql);
			}
			catch (Exception)
			{
				throw;
			}
		}

		public DataTable ListarOSsindico(int id_sindico)
		{
			try
			{
				string sql = "select * from " + tabela + " where tbl_sindico_id_sindico = " + id_sindico;
				return bd.ExecutarConsulta(sql);
			}
			catch (Exception)
			{

				throw;
			}
		}
		public DataTable ListarOSaberta()
		{
			try
			{
				string sql = "select * from "+tabela+" where tbl_conservadora_id_conservadora = NULL ;";
				return bd.ExecutarConsulta(sql);
			}
			catch (Exception)
			{

				throw;
			}
		}

		public DataTable ListarOSaceita()
		{
			try
			{
				DTO_Conservadora conservadora = new DTO_Conservadora();
				string sql = "select * from " + tabela + " where tbl_funcionario_id_funcionario <> NULL and tbl_conservadora_id_conservadora = "+conservadora.Id+ " ; ";
				return bd.ExecutarConsulta(sql);
			}
			catch (Exception)
			{

				throw;
			}
		}

		public DataTable ListarOSconservadora()
		{
			try
			{
				DTO_Conservadora conservadora = new DTO_Conservadora();
				string sql = "select * from " + tabela + "  where tbl_conservadora_id_conservadora = "+ conservadora.Id+ " ; ";
				return bd.ExecutarConsulta(sql);
			}
			catch (Exception)
			{

				throw;
			}
		}

	}
}
