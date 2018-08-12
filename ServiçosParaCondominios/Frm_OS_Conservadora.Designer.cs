namespace ServiçosParaCondominios
{
	partial class Frm_OS_Conservadora
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
			this.lblOS = new System.Windows.Forms.Label();
			this.dgv_OSabertas = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbxFuncionario = new System.Windows.Forms.ComboBox();
			this.btnAceitar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgv_OSabertas)).BeginInit();
			this.SuspendLayout();
			// 
			// lblOS
			// 
			this.lblOS.AutoSize = true;
			this.lblOS.Location = new System.Drawing.Point(12, 19);
			this.lblOS.Name = "lblOS";
			this.lblOS.Size = new System.Drawing.Size(175, 13);
			this.lblOS.TabIndex = 0;
			this.lblOS.Text = "Selecione uma das OS disponíveis:";
			// 
			// dgv_OSabertas
			// 
			this.dgv_OSabertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_OSabertas.Location = new System.Drawing.Point(12, 54);
			this.dgv_OSabertas.Name = "dgv_OSabertas";
			this.dgv_OSabertas.Size = new System.Drawing.Size(444, 141);
			this.dgv_OSabertas.TabIndex = 1;
			this.dgv_OSabertas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_OSabertas_CellContentClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 240);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "ID";
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(44, 237);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(45, 20);
			this.txtId.TabIndex = 11;
			this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(136, 240);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "Funcionário:";
			// 
			// cbxFuncionario
			// 
			this.cbxFuncionario.FormattingEnabled = true;
			this.cbxFuncionario.Location = new System.Drawing.Point(207, 237);
			this.cbxFuncionario.Name = "cbxFuncionario";
			this.cbxFuncionario.Size = new System.Drawing.Size(121, 21);
			this.cbxFuncionario.TabIndex = 14;
			// 
			// btnAceitar
			// 
			this.btnAceitar.Location = new System.Drawing.Point(12, 287);
			this.btnAceitar.Name = "btnAceitar";
			this.btnAceitar.Size = new System.Drawing.Size(75, 32);
			this.btnAceitar.TabIndex = 15;
			this.btnAceitar.Text = "Aceitar";
			this.btnAceitar.UseVisualStyleBackColor = true;
			this.btnAceitar.Click += new System.EventHandler(this.btnAceitar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(103, 287);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 32);
			this.btnCancelar.TabIndex = 16;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			// 
			// Frm_OS_Conservadora
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(468, 331);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceitar);
			this.Controls.Add(this.cbxFuncionario);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.dgv_OSabertas);
			this.Controls.Add(this.lblOS);
			this.Name = "Frm_OS_Conservadora";
			this.Text = "Frm_OS_Conservadora";
			this.Load += new System.EventHandler(this.Frm_OS_Conservadora_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_OSabertas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblOS;
		private System.Windows.Forms.DataGridView dgv_OSabertas;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbxFuncionario;
		private System.Windows.Forms.Button btnAceitar;
		private System.Windows.Forms.Button btnCancelar;
	}
}