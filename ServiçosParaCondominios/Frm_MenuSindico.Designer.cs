namespace ServiçosParaCondominios
{
	partial class Frm_MenuSindico
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.todasAsOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNovaOS = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOsAceitas = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todasAsOSToolStripMenuItem,
            this.relatórioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(788, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // todasAsOSToolStripMenuItem
            // 
            this.todasAsOSToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.todasAsOSToolStripMenuItem.Name = "todasAsOSToolStripMenuItem";
            this.todasAsOSToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.todasAsOSToolStripMenuItem.Text = "Serviços Disponíveis";
            this.todasAsOSToolStripMenuItem.Click += new System.EventHandler(this.todasAsOSToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bem Vindo ! ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(438, 166);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(280, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Suas Ordens de Serviço";
            // 
            // btnNovaOS
            // 
            this.btnNovaOS.Location = new System.Drawing.Point(21, 148);
            this.btnNovaOS.Name = "btnNovaOS";
            this.btnNovaOS.Size = new System.Drawing.Size(191, 23);
            this.btnNovaOS.TabIndex = 4;
            this.btnNovaOS.Text = "Manipular Ordens de Serviço";
            this.btnNovaOS.UseVisualStyleBackColor = true;
            this.btnNovaOS.Click += new System.EventHandler(this.btnNovaOS_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "O que deseja fazer?";
            // 
            // btnOsAceitas
            // 
            this.btnOsAceitas.Location = new System.Drawing.Point(21, 193);
            this.btnOsAceitas.Name = "btnOsAceitas";
            this.btnOsAceitas.Size = new System.Drawing.Size(191, 23);
            this.btnOsAceitas.TabIndex = 6;
            this.btnOsAceitas.Text = "Ver Ordens de Serviço aceitas";
            this.btnOsAceitas.UseVisualStyleBackColor = true;
            this.btnOsAceitas.Click += new System.EventHandler(this.btnOsAceitas_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(284, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 264);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar Por:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            this.relatórioToolStripMenuItem.Click += new System.EventHandler(this.relatórioToolStripMenuItem_Click);
            // 
            // Frm_MenuSindico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 367);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOsAceitas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNovaOS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_MenuSindico";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Frm_MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnNovaOS;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnOsAceitas;
		private System.Windows.Forms.ToolStripMenuItem todasAsOSToolStripMenuItem;
		private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
    }
}