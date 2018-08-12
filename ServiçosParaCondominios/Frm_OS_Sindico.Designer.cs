namespace ServiçosParaCondominios
{
    partial class Frm_OS_Sindico
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.btnAtualizar = new System.Windows.Forms.Button();
			this.btnDeletar = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtId = new System.Windows.Forms.TextBox();
			this.cbxServico = new System.Windows.Forms.ComboBox();
			this.cbxSindico = new System.Windows.Forms.ComboBox();
			this.cbxVip = new System.Windows.Forms.ComboBox();
			this.txtDataServico = new System.Windows.Forms.MaskedTextBox();
			this.txtDataAbertura = new System.Windows.Forms.MaskedTextBox();
			this.txtDescricao = new System.Windows.Forms.RichTextBox();
			this.txtComentarios = new System.Windows.Forms.RichTextBox();
			this.txtHoras = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtHoras)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 142);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "DATA DE SERVIÇO";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 109);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(116, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "DATA DE ABERTURA";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(15, 181);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(24, 13);
			this.label4.TabIndex = 13;
			this.label4.Text = "VIP";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 217);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(129, 13);
			this.label5.TabIndex = 14;
			this.label5.Text = "HORAS CONTRATADAS";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(271, 217);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(86, 13);
			this.label6.TabIndex = 15;
			this.label6.Text = "COMENTARIOS";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(40, 293);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(51, 13);
			this.label8.TabIndex = 17;
			this.label8.Text = "SINDICO";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(40, 257);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(54, 13);
			this.label9.TabIndex = 18;
			this.label9.Text = "SERVIÇO";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(271, 65);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(69, 13);
			this.label10.TabIndex = 19;
			this.label10.Text = "DESCRICAO";
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.Location = new System.Drawing.Point(43, 408);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(118, 46);
			this.btnRegistrar.TabIndex = 20;
			this.btnRegistrar.Text = "Registrar";
			this.btnRegistrar.UseVisualStyleBackColor = true;
			this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
			// 
			// btnAtualizar
			// 
			this.btnAtualizar.Location = new System.Drawing.Point(179, 408);
			this.btnAtualizar.Name = "btnAtualizar";
			this.btnAtualizar.Size = new System.Drawing.Size(118, 46);
			this.btnAtualizar.TabIndex = 21;
			this.btnAtualizar.Text = "Atualizar";
			this.btnAtualizar.UseVisualStyleBackColor = true;
			this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
			// 
			// btnDeletar
			// 
			this.btnDeletar.Location = new System.Drawing.Point(321, 408);
			this.btnDeletar.Name = "btnDeletar";
			this.btnDeletar.Size = new System.Drawing.Size(118, 46);
			this.btnDeletar.TabIndex = 22;
			this.btnDeletar.Text = "Deletar";
			this.btnDeletar.UseVisualStyleBackColor = true;
			this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(6, 9);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(255, 32);
			this.label11.TabIndex = 23;
			this.label11.Text = "Ordem De Serviço";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(7, 481);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(634, 196);
			this.dataGridView1.TabIndex = 24;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(146, 65);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(38, 20);
			this.txtId.TabIndex = 0;
			this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
			// 
			// cbxServico
			// 
			this.cbxServico.FormattingEnabled = true;
			this.cbxServico.Location = new System.Drawing.Point(141, 253);
			this.cbxServico.Name = "cbxServico";
			this.cbxServico.Size = new System.Drawing.Size(105, 21);
			this.cbxServico.TabIndex = 28;
			this.cbxServico.SelectedIndexChanged += new System.EventHandler(this.cbxServico_SelectedIndexChanged);
			// 
			// cbxSindico
			// 
			this.cbxSindico.FormattingEnabled = true;
			this.cbxSindico.Location = new System.Drawing.Point(141, 293);
			this.cbxSindico.Name = "cbxSindico";
			this.cbxSindico.Size = new System.Drawing.Size(105, 21);
			this.cbxSindico.TabIndex = 29;
			// 
			// cbxVip
			// 
			this.cbxVip.FormattingEnabled = true;
			this.cbxVip.Items.AddRange(new object[] {
            "sim",
            "nao"});
			this.cbxVip.Location = new System.Drawing.Point(146, 173);
			this.cbxVip.Name = "cbxVip";
			this.cbxVip.Size = new System.Drawing.Size(100, 21);
			this.cbxVip.TabIndex = 31;
			// 
			// txtDataServico
			// 
			this.txtDataServico.Location = new System.Drawing.Point(146, 139);
			this.txtDataServico.Mask = "00/00/0000";
			this.txtDataServico.Name = "txtDataServico";
			this.txtDataServico.Size = new System.Drawing.Size(100, 20);
			this.txtDataServico.TabIndex = 33;
			this.txtDataServico.ValidatingType = typeof(System.DateTime);
			// 
			// txtDataAbertura
			// 
			this.txtDataAbertura.Location = new System.Drawing.Point(146, 102);
			this.txtDataAbertura.Mask = "00/00/0000";
			this.txtDataAbertura.Name = "txtDataAbertura";
			this.txtDataAbertura.Size = new System.Drawing.Size(100, 20);
			this.txtDataAbertura.TabIndex = 34;
			this.txtDataAbertura.ValidatingType = typeof(System.DateTime);
			this.txtDataAbertura.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtDataAbertura_MaskInputRejected);
			// 
			// txtDescricao
			// 
			this.txtDescricao.Location = new System.Drawing.Point(274, 94);
			this.txtDescricao.Name = "txtDescricao";
			this.txtDescricao.Size = new System.Drawing.Size(331, 104);
			this.txtDescricao.TabIndex = 35;
			this.txtDescricao.Text = "";
			// 
			// txtComentarios
			// 
			this.txtComentarios.Location = new System.Drawing.Point(274, 246);
			this.txtComentarios.Name = "txtComentarios";
			this.txtComentarios.Size = new System.Drawing.Size(331, 104);
			this.txtComentarios.TabIndex = 36;
			this.txtComentarios.Text = "";
			// 
			// txtHoras
			// 
			this.txtHoras.Location = new System.Drawing.Point(146, 215);
			this.txtHoras.Name = "txtHoras";
			this.txtHoras.Size = new System.Drawing.Size(38, 20);
			this.txtHoras.TabIndex = 37;
			// 
			// Frm_OS_Sindico
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(653, 689);
			this.Controls.Add(this.txtHoras);
			this.Controls.Add(this.txtComentarios);
			this.Controls.Add(this.txtDescricao);
			this.Controls.Add(this.txtDataAbertura);
			this.Controls.Add(this.txtDataServico);
			this.Controls.Add(this.cbxVip);
			this.Controls.Add(this.cbxSindico);
			this.Controls.Add(this.cbxServico);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.btnDeletar);
			this.Controls.Add(this.btnAtualizar);
			this.Controls.Add(this.btnRegistrar);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtId);
			this.Name = "Frm_OS_Sindico";
			this.Text = "Ordem de Serviço";
			this.Load += new System.EventHandler(this.OrdemServico_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtHoras)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Label label11;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.ComboBox cbxServico;
		private System.Windows.Forms.ComboBox cbxSindico;
		private System.Windows.Forms.ComboBox cbxVip;
		private System.Windows.Forms.MaskedTextBox txtDataServico;
		private System.Windows.Forms.MaskedTextBox txtDataAbertura;
		private System.Windows.Forms.RichTextBox txtDescricao;
		private System.Windows.Forms.RichTextBox txtComentarios;
		private System.Windows.Forms.NumericUpDown txtHoras;
	}
}