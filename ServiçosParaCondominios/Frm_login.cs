using BLL;
using System;
using System.Windows.Forms;
using System.Data;

namespace ServiçosParaCondominios
{
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
        }

		private void Frm_login_Load(object sender, EventArgs e)
		{

		}


		

		private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Frm_Sindico crud_sindico = new Frm_Sindico();
			crud_sindico.ShowDialog();
		}

		private void btnSair_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}


		private void btnEntrar_Click(object sender, EventArgs e)
		{
			
			if (rbnSindico.Checked == true)
			{
				if (Program.sindico_login != null)
				{
					DialogResult = DialogResult.OK;
				}
				
			}

			if (rbnConservadora.Checked == true)
			{
				if (Program.conservadora_login != null)
				{
					DialogResult = DialogResult.Yes;
				}
				
			}
		}

		private void rbnSindico_CheckedChanged_1(object sender, EventArgs e)
		{
			if (rbnSindico.Checked == true)
			{
				
				BLL_Sindico bll_sindico = new BLL_Sindico();
				Program.sindico_login = bll_sindico.ConsultarSindicoLogin(txtEmail.Text, txtPwd.Text);
				btnEntrar.Enabled = true;

			}
		}

		private void rbnConservadora_CheckedChanged(object sender, EventArgs e)
		{
			if (rbnConservadora.Checked == true)
			{
				
				BLL_Conservadora bll_conservadora = new BLL_Conservadora();
				Program.conservadora_login = bll_conservadora.ConsultarConservadoraLogin(txtEmail.Text, txtPwd.Text);
				btnEntrar.Enabled = true;

			}
		}
	}
}
