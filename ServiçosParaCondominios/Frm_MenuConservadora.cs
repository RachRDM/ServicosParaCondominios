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
	public partial class Frm_MenuConservadora : Form
	{
		public Frm_MenuConservadora()
		{
			InitializeComponent();
		}

		BLL_OrdemServico os = new BLL_OrdemServico();

		private void Frm_Conservadora_Load(object sender, EventArgs e)
		{

		}

		private void toolStripLabel1_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{
			label1.Text =  Program.conservadora_login.Nome ;

		}

		private void cbnPesquisa_SelectedIndexChanged(object sender, EventArgs e)
		{
			
			if (cbnPesquisa.Text == "OS Abertas")
			{
				dataGridView1.DataSource = os.ListarOSaberta();
			}
			if (cbnPesquisa.Text == "OS Aceitas")
			{
				dataGridView1.DataSource = os.ListarOSaceita();
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			dataGridView1.DataSource = os.ListarOSconservadora();
		}

		private void aceitarNovaOSToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void aceitarNovaOSToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			Frm_OS_Conservadora osCons = new Frm_OS_Conservadora();
			osCons.ShowDialog();
		}

		private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{
			dataGridView1.DataSource = os.ListarOSconservadora();
		}
	}
}
