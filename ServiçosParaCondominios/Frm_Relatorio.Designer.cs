namespace ServiçosParaCondominios
{
    partial class Frm_Relatorio
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dtpAbertura = new System.Windows.Forms.DateTimePicker();
			this.dtpFim = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnData = new System.Windows.Forms.Button();
			this.cbxServico = new System.Windows.Forms.ComboBox();
			this.btnServico = new System.Windows.Forms.Button();
			this.cbxFuncionario = new System.Windows.Forms.ComboBox();
			this.cbxConservadora = new System.Windows.Forms.ComboBox();
			this.btnConservadora = new System.Windows.Forms.Button();
			this.cbxSindico = new System.Windows.Forms.ComboBox();
			this.btnSindico = new System.Windows.Forms.Button();
			this.btnFuncionario = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 178);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(831, 339);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// dtpAbertura
			// 
			this.dtpAbertura.Location = new System.Drawing.Point(76, 23);
			this.dtpAbertura.Name = "dtpAbertura";
			this.dtpAbertura.Size = new System.Drawing.Size(200, 20);
			this.dtpAbertura.TabIndex = 1;
			this.dtpAbertura.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// dtpFim
			// 
			this.dtpFim.Location = new System.Drawing.Point(76, 60);
			this.dtpFim.Name = "dtpFim";
			this.dtpFim.Size = new System.Drawing.Size(200, 20);
			this.dtpFim.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "início";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(23, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Fim";
			// 
			// btnData
			// 
			this.btnData.Location = new System.Drawing.Point(12, 125);
			this.btnData.Name = "btnData";
			this.btnData.Size = new System.Drawing.Size(75, 23);
			this.btnData.TabIndex = 5;
			this.btnData.Text = "data";
			this.btnData.UseVisualStyleBackColor = true;
			this.btnData.Click += new System.EventHandler(this.btnData_Click);
			// 
			// cbxServico
			// 
			this.cbxServico.FormattingEnabled = true;
			this.cbxServico.Location = new System.Drawing.Point(345, 108);
			this.cbxServico.Name = "cbxServico";
			this.cbxServico.Size = new System.Drawing.Size(121, 21);
			this.cbxServico.TabIndex = 6;
			// 
			// btnServico
			// 
			this.btnServico.Location = new System.Drawing.Point(345, 138);
			this.btnServico.Name = "btnServico";
			this.btnServico.Size = new System.Drawing.Size(75, 23);
			this.btnServico.TabIndex = 7;
			this.btnServico.Text = "servico";
			this.btnServico.UseVisualStyleBackColor = true;
			this.btnServico.Click += new System.EventHandler(this.btnServico_Click);
			// 
			// cbxFuncionario
			// 
			this.cbxFuncionario.FormattingEnabled = true;
			this.cbxFuncionario.Location = new System.Drawing.Point(345, 21);
			this.cbxFuncionario.Name = "cbxFuncionario";
			this.cbxFuncionario.Size = new System.Drawing.Size(121, 21);
			this.cbxFuncionario.TabIndex = 8;
			// 
			// cbxConservadora
			// 
			this.cbxConservadora.FormattingEnabled = true;
			this.cbxConservadora.Location = new System.Drawing.Point(587, 21);
			this.cbxConservadora.Name = "cbxConservadora";
			this.cbxConservadora.Size = new System.Drawing.Size(121, 21);
			this.cbxConservadora.TabIndex = 10;
			// 
			// btnConservadora
			// 
			this.btnConservadora.Location = new System.Drawing.Point(587, 57);
			this.btnConservadora.Name = "btnConservadora";
			this.btnConservadora.Size = new System.Drawing.Size(84, 23);
			this.btnConservadora.TabIndex = 11;
			this.btnConservadora.Text = "conservadora";
			this.btnConservadora.UseVisualStyleBackColor = true;
			this.btnConservadora.Click += new System.EventHandler(this.btnConservadora_Click);
			// 
			// cbxSindico
			// 
			this.cbxSindico.FormattingEnabled = true;
			this.cbxSindico.Location = new System.Drawing.Point(587, 108);
			this.cbxSindico.Name = "cbxSindico";
			this.cbxSindico.Size = new System.Drawing.Size(121, 21);
			this.cbxSindico.TabIndex = 12;
			// 
			// btnSindico
			// 
			this.btnSindico.Location = new System.Drawing.Point(587, 138);
			this.btnSindico.Name = "btnSindico";
			this.btnSindico.Size = new System.Drawing.Size(75, 23);
			this.btnSindico.TabIndex = 13;
			this.btnSindico.Text = "Sindico";
			this.btnSindico.UseVisualStyleBackColor = true;
			this.btnSindico.Click += new System.EventHandler(this.btnSindico_Click);
			// 
			// btnFuncionario
			// 
			this.btnFuncionario.Location = new System.Drawing.Point(345, 52);
			this.btnFuncionario.Name = "btnFuncionario";
			this.btnFuncionario.Size = new System.Drawing.Size(75, 23);
			this.btnFuncionario.TabIndex = 14;
			this.btnFuncionario.Text = "Funcionario";
			this.btnFuncionario.UseVisualStyleBackColor = true;
			this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
			// 
			// Frm_Relatorio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(880, 541);
			this.Controls.Add(this.btnFuncionario);
			this.Controls.Add(this.btnSindico);
			this.Controls.Add(this.cbxSindico);
			this.Controls.Add(this.btnConservadora);
			this.Controls.Add(this.cbxConservadora);
			this.Controls.Add(this.cbxFuncionario);
			this.Controls.Add(this.btnServico);
			this.Controls.Add(this.cbxServico);
			this.Controls.Add(this.btnData);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtpFim);
			this.Controls.Add(this.dtpAbertura);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Frm_Relatorio";
			this.Text = "Frm_Relatorio";
			this.Load += new System.EventHandler(this.Frm_Relatorio_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtpAbertura;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.ComboBox cbxServico;
        private System.Windows.Forms.Button btnServico;
        private System.Windows.Forms.ComboBox cbxFuncionario;
        private System.Windows.Forms.ComboBox cbxConservadora;
        private System.Windows.Forms.Button btnConservadora;
        private System.Windows.Forms.ComboBox cbxSindico;
        private System.Windows.Forms.Button btnSindico;
        private System.Windows.Forms.Button btnFuncionario;
    }
}