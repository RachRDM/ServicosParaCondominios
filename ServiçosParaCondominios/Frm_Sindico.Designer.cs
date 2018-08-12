namespace ServiçosParaCondominios
{
    partial class Frm_Sindico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtSenha = new System.Windows.Forms.MaskedTextBox();
			this.txtCep = new System.Windows.Forms.MaskedTextBox();
			this.btnInserir = new System.Windows.Forms.Button();
			this.btnAtualizar = new System.Windows.Forms.Button();
			this.btnDeletar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtCondominio = new System.Windows.Forms.TextBox();
			this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
			this.txtNumEndereco = new System.Windows.Forms.TextBox();
			this.txtComplemento = new System.Windows.Forms.TextBox();
			this.txtId = new System.Windows.Forms.TextBox();
			this.ID = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(200, 91);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(200, 20);
			this.txtNome.TabIndex = 0;
			// 
			// txtSenha
			// 
			this.txtSenha.Location = new System.Drawing.Point(202, 163);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(200, 20);
			this.txtSenha.TabIndex = 3;
			this.txtSenha.UseSystemPasswordChar = true;
			// 
			// txtCep
			// 
			this.txtCep.Location = new System.Drawing.Point(202, 232);
			this.txtCep.Name = "txtCep";
			this.txtCep.Size = new System.Drawing.Size(200, 20);
			this.txtCep.TabIndex = 5;
			// 
			// btnInserir
			// 
			this.btnInserir.Location = new System.Drawing.Point(35, 438);
			this.btnInserir.Name = "btnInserir";
			this.btnInserir.Size = new System.Drawing.Size(101, 37);
			this.btnInserir.TabIndex = 8;
			this.btnInserir.Text = "Inserir";
			this.btnInserir.UseVisualStyleBackColor = true;
			this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
			// 
			// btnAtualizar
			// 
			this.btnAtualizar.Location = new System.Drawing.Point(142, 438);
			this.btnAtualizar.Name = "btnAtualizar";
			this.btnAtualizar.Size = new System.Drawing.Size(101, 37);
			this.btnAtualizar.TabIndex = 9;
			this.btnAtualizar.Text = "Atualizar";
			this.btnAtualizar.UseVisualStyleBackColor = true;
			this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
			// 
			// btnDeletar
			// 
			this.btnDeletar.Location = new System.Drawing.Point(249, 438);
			this.btnDeletar.Name = "btnDeletar";
			this.btnDeletar.Size = new System.Drawing.Size(101, 37);
			this.btnDeletar.TabIndex = 10;
			this.btnDeletar.Text = "Deletar";
			this.btnDeletar.UseVisualStyleBackColor = true;
			this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(45, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "NOME";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(45, 98);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "CONDOMÍNIO";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(45, 125);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 13);
			this.label3.TabIndex = 13;
			this.label3.Text = "EMAIL";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(45, 163);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 13);
			this.label4.TabIndex = 14;
			this.label4.Text = "SENHA";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(45, 199);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(34, 13);
			this.label5.TabIndex = 15;
			this.label5.Text = "CNPJ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(45, 235);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(28, 13);
			this.label6.TabIndex = 16;
			this.label6.Text = "CEP";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(45, 276);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(137, 13);
			this.label7.TabIndex = 17;
			this.label7.Text = "NUMERO DO ENDEREÇO";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(45, 311);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(90, 13);
			this.label8.TabIndex = 18;
			this.label8.Text = "COMPLEMENTO";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(29, -3);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(277, 31);
			this.label9.TabIndex = 19;
			this.label9.Text = "Cadastro do Sindico";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(202, 129);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(200, 20);
			this.txtEmail.TabIndex = 20;
			// 
			// txtCondominio
			// 
			this.txtCondominio.Location = new System.Drawing.Point(202, 57);
			this.txtCondominio.Name = "txtCondominio";
			this.txtCondominio.Size = new System.Drawing.Size(200, 20);
			this.txtCondominio.TabIndex = 21;
			// 
			// txtCnpj
			// 
			this.txtCnpj.Location = new System.Drawing.Point(202, 196);
			this.txtCnpj.Name = "txtCnpj";
			this.txtCnpj.Size = new System.Drawing.Size(200, 20);
			this.txtCnpj.TabIndex = 22;
			// 
			// txtNumEndereco
			// 
			this.txtNumEndereco.Location = new System.Drawing.Point(202, 273);
			this.txtNumEndereco.Name = "txtNumEndereco";
			this.txtNumEndereco.Size = new System.Drawing.Size(200, 20);
			this.txtNumEndereco.TabIndex = 23;
			// 
			// txtComplemento
			// 
			this.txtComplemento.Location = new System.Drawing.Point(200, 311);
			this.txtComplemento.Name = "txtComplemento";
			this.txtComplemento.Size = new System.Drawing.Size(200, 20);
			this.txtComplemento.TabIndex = 24;
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(79, 379);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(43, 20);
			this.txtId.TabIndex = 26;
			// 
			// ID
			// 
			this.ID.AutoSize = true;
			this.ID.Location = new System.Drawing.Point(45, 382);
			this.ID.Name = "ID";
			this.ID.Size = new System.Drawing.Size(16, 13);
			this.ID.TabIndex = 25;
			this.ID.Text = "Id";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(429, 50);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(390, 425);
			this.dataGridView1.TabIndex = 27;
			// 
			// Sindico
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(877, 496);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.ID);
			this.Controls.Add(this.txtComplemento);
			this.Controls.Add(this.txtNumEndereco);
			this.Controls.Add(this.txtCnpj);
			this.Controls.Add(this.txtCondominio);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnDeletar);
			this.Controls.Add(this.btnAtualizar);
			this.Controls.Add(this.btnInserir);
			this.Controls.Add(this.txtCep);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.txtNome);
			this.Name = "Sindico";
			this.Text = "Zz";
			this.Load += new System.EventHandler(this.Sindico_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox txtSenha;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCondominio;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private System.Windows.Forms.TextBox txtNumEndereco;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}