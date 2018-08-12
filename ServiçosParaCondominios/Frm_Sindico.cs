using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace ServiçosParaCondominios
{
    public partial class Frm_Sindico : Form
    {
        public Frm_Sindico()
        {
            InitializeComponent();
        }

        BLL_Sindico bll_sindico = new BLL_Sindico();
        DTO_Sindico dto_sindico = new DTO_Sindico();

        private void btnInserir_Click(object sender, EventArgs e)
        {
            dto_sindico.Nome = txtNome.Text;
            dto_sindico.NomeCondominio = txtCondominio.Text;
            dto_sindico.Email = txtEmail.Text;
            dto_sindico.Senha = txtSenha.Text;
            dto_sindico.Cnpj = txtCnpj.Text;
            dto_sindico.Cep = txtCep.Text;
            dto_sindico.Numero = Convert.ToInt32(txtNumEndereco.Text);
            dto_sindico.Complemento = txtComplemento.Text;
            bll_sindico.RegistrarSindico(dto_sindico);
            dataGridView1.DataSource = bll_sindico.Listar_Registros();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
			dto_sindico.Id = Convert.ToInt32(txtId.Text);
			dto_sindico.Nome = txtNome.Text;
            dto_sindico.NomeCondominio = txtCondominio.Text;
            dto_sindico.Email = txtEmail.Text;
            dto_sindico.Senha = txtSenha.Text;
            dto_sindico.Cnpj = txtCnpj.Text;
            dto_sindico.Cep = txtCep.Text;
            dto_sindico.Numero = Convert.ToInt32(txtNumEndereco.Text);
            dto_sindico.Complemento = txtComplemento.Text;
            bll_sindico.AtualizarSindico(dto_sindico);
            dataGridView1.DataSource = bll_sindico.Listar_Registros();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            dto_sindico.Id = Convert.ToInt32(txtId.Text);
            bll_sindico.DeletarSindico(dto_sindico);
			dataGridView1.DataSource = bll_sindico.Listar_Registros();
		}

        private void Sindico_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bll_sindico.Listar_Registros();
        }
    }
}
