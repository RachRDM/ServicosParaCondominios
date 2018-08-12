using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace ServiçosParaCondominios
{
	public partial class Frm_OS_Conservadora : Form
	{

		public Frm_OS_Conservadora()
		{
			InitializeComponent();
		}

		private BLL_OrdemServico bll_os = new BLL_OrdemServico();
		private DTO_ordemServico dto_os = new DTO_ordemServico();
		private DTO_Conservadora dto_cons = new DTO_Conservadora();

		private void Frm_OS_Conservadora_Load(object sender, EventArgs e)
		{
			dgv_OSabertas.DataSource = bll_os.ListarOSaberta();
			BLL_Funcionario funcionario = new BLL_Funcionario();
			cbxFuncionario.DataSource = funcionario.Listar_Registros();
			cbxFuncionario.DisplayMember = "nome_funcionario";
			cbxFuncionario.ValueMember = "id_funcionario";

		}

		private void txtId_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void dgv_OSabertas_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex > 0)
			{
				//Pegando o valor do Id no banco e colocando no textbox ID
				txtId.Text = dgv_OSabertas.Rows[e.RowIndex].Cells[0].Value.ToString();
				
			}
		}

		private void btnAceitar_Click(object sender, EventArgs e)
		{
			dto_os.Id = Convert.ToInt32(txtId.Text);
			dto_os.Funcionario_id = Convert.ToInt32(cbxFuncionario.Text);
			dto_os.Conservadora_id = Convert.ToInt32(dto_cons.Id);
			bll_os.AceitarOs(dto_os.Id, dto_os.Funcionario_id, dto_os.Conservadora_id);

			//if ()
			//{

			//}
		}
	}
}
