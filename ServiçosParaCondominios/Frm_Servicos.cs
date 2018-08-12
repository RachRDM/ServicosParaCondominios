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

namespace ServiçosParaCondominios
{
	public partial class Frm_Servicos : Form
	{
		public Frm_Servicos()
		{
			InitializeComponent();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void Frm_Servicos_Load(object sender, EventArgs e)
		{
			BLL_Servico bll_servico = new BLL_Servico();
			dataGridView1.DataSource = bll_servico.Listar_Registros();
		}
	}
}
