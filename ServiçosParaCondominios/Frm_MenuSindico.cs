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
	public partial class Frm_MenuSindico : Form
	{
		public Frm_MenuSindico()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{
			
		}

		private void Frm_MenuPrincipal_Load(object sender, EventArgs e)
		{
			BLL_Sindico sindico = new BLL_Sindico();
			BLL_OrdemServico os = new BLL_OrdemServico();
			label1.Text = "Bem vindo " + Program.sindico_login.Nome + " ! ";
			dataGridView1.DataSource = os.ListarOSsindico(Program.sindico_login.Id);

		}

		private void btnNovaOS_Click(object sender, EventArgs e)
		{
			Frm_OS_Sindico crud_os = new Frm_OS_Sindico();
			crud_os.ShowDialog();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void todasAsOSToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Frm_Servicos frm_servicos = new Frm_Servicos();
			frm_servicos.ShowDialog();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btnOsAceitas_Click(object sender, EventArgs e)
		{

		}

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Relatorio frm_relatorios = new Frm_Relatorio();
            frm_relatorios.ShowDialog();
        }
    }
}
