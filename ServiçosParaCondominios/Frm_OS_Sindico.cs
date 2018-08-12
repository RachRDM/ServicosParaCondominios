using DTO;
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
    public partial class Frm_OS_Sindico : Form
    {
        public Frm_OS_Sindico()
        {
            InitializeComponent();
        }

		BLL_OrdemServico bll_os = new BLL_OrdemServico();
		DTO_ordemServico dto_os = new DTO_ordemServico();

		private void OrdemServico_Load(object sender, EventArgs e)
        {
			dataGridView1.DataSource = bll_os.Listar_Registros();

			BLL_Servico servico = new BLL_Servico();
			cbxServico.DataSource = servico.Listar_Registros();
			cbxServico.DisplayMember = "descricao_servico";
			cbxServico.ValueMember = "id_servico";

			//BLL_Funcionario funcionario = new BLL_Funcionario();
			//cbxFuncionario.DataSource = funcionario.Listar_Registros();
			//cbxFuncionario.DisplayMember = "nome_funcionario";
			//cbxFuncionario.ValueMember = "id_funcionario";

			BLL_Sindico sindico = new BLL_Sindico();
			cbxSindico.DataSource = sindico.Listar_Registros();
			cbxSindico.DisplayMember = "nome_sindico";
			cbxSindico.ValueMember = "id_sindico";

		}

		

		private void btnRegistrar_Click(object sender, EventArgs e)
		{
			dto_os.DataAbertura = Convert.ToDateTime( txtDataAbertura.Text);
			dto_os.DataAbertura = Convert.ToDateTime(txtDataServico.Text);
			dto_os.DataServico = Convert.ToDateTime(txtDataServico.Text);
			if (cbxVip.Text == "sim")
				dto_os.Vip = 1;
			else
				dto_os.Vip = 0;

			dto_os.HorasContratadas = Convert.ToInt32(txtHoras.Text);
			dto_os.Descricao = txtDescricao.Text;
			dto_os.Comentarios = txtComentarios.Text;
			dto_os.Sindico_id = Convert.ToInt32(cbxSindico.SelectedValue);
			dto_os.Servico_id = Convert.ToInt32(cbxServico.SelectedValue);

			bll_os.RegistrarOs(dto_os);
			dataGridView1.DataSource = bll_os.Listar_Registros();
		}

		private void btnDeletar_Click(object sender, EventArgs e)
		{
			dto_os.Id = Convert.ToInt32(txtId.Text);
			bll_os.DeletarOs(dto_os);
			dataGridView1.DataSource = bll_os.Listar_Registros();

		}

		private void txtDataAbertura_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{

		}

		private void txtComentarios_TextChanged(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btnAtualizar_Click(object sender, EventArgs e)
		{
			dto_os.Id = Convert.ToInt32(txtId.Text);
			dto_os.DataAbertura = Convert.ToDateTime(txtDataAbertura.Text);
			dto_os.DataServico = Convert.ToDateTime(txtDataServico.Text);
			if (cbxVip.Text == "sim")
				dto_os.Vip = 1;
			else
				dto_os.Vip = 0;

			dto_os.HorasContratadas = Convert.ToInt32(txtHoras.Text);
			dto_os.Descricao = txtDescricao.Text;
			dto_os.Comentarios = txtComentarios.Text;
			dto_os.Sindico_id = Convert.ToInt32(cbxSindico.SelectedValue);
			dto_os.Servico_id = Convert.ToInt32(cbxServico.SelectedValue);

			bll_os.AtualizarOs(dto_os);
			dataGridView1.DataSource = bll_os.Listar_Registros();
		}

		private void txtId_TextChanged(object sender, EventArgs e)
		{

		}

		private void cbxServico_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
