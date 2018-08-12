using BLL;
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
    public partial class Frm_Relatorio : Form
    {
        public Frm_Relatorio()
        {
            InitializeComponent();
        }

		private BLL_Relatorio relatorio = new BLL_Relatorio();

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

     

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
           
        }

        private void Frm_Relatorio_Load(object sender, EventArgs e)
        {

            BLL_Servico servico = new BLL_Servico();
            cbxServico.DataSource = servico.Listar_Registros();
            cbxServico.DisplayMember = "descricao_servico";
            cbxServico.ValueMember = "id_servico";

			BLL_Funcionario func = new BLL_Funcionario();
			cbxFuncionario.DataSource = func.Listar_Registros();
			cbxFuncionario.DisplayMember = "nome_Funcionario";
			cbxFuncionario.ValueMember = "id_Funcionario";

			BLL_Sindico sind = new BLL_Sindico();
			cbxSindico.DataSource = sind.Listar_Registros();
			cbxSindico.DisplayMember = "nome_Sindico";
			cbxSindico.ValueMember = "id_Sindico";

			BLL_Conservadora conserv = new BLL_Conservadora();
			cbxConservadora.DataSource = conserv.Listar_Registros();
			cbxConservadora.DisplayMember = "nome_conservadora";
			cbxConservadora.ValueMember = "id_conservadora";
		}

		private void btnData_Click(object sender, EventArgs e)
		{
			BLL_Relatorio relatorio = new BLL_Relatorio();
			dataGridView1.DataSource = relatorio.ListarOSporSindico(Convert.ToDateTime(dtpAbertura.Value), Convert.ToDateTime(dtpAbertura.Value));
		}

		private void btnServico_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = relatorio.ListarOSporServico(Convert.ToInt32(cbxServico.SelectedValue));
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
			dataGridView1.DataSource = relatorio.ListarOSporFuncionario(Convert.ToInt32(cbxServico.SelectedValue));
        }

		private void btnConservadora_Click(object sender, EventArgs e)
		{
			dataGridView1.DataSource = relatorio.ListarOSporConservadora(Convert.ToInt32(cbxConservadora.SelectedValue));

		}

		private void btnSindico_Click(object sender, EventArgs e)
		{
			dataGridView1.DataSource = relatorio.ListarOSporSindico(Convert.ToInt32(cbxSindico.SelectedValue));

		}
	}
}
