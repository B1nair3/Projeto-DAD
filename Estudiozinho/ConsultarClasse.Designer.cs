namespace Estudiozinho
{
    partial class ConsultarClasse
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
            this.dgwClasses = new System.Windows.Forms.DataGridView();
            this.dgwNomes = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtMatriculados = new System.Windows.Forms.TextBox();
            this.mkdHora = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwNomes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwClasses
            // 
            this.dgwClasses.AllowUserToAddRows = false;
            this.dgwClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwClasses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.a});
            this.dgwClasses.Location = new System.Drawing.Point(12, 12);
            this.dgwClasses.MultiSelect = false;
            this.dgwClasses.Name = "dgwClasses";
            this.dgwClasses.ReadOnly = true;
            this.dgwClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwClasses.Size = new System.Drawing.Size(145, 175);
            this.dgwClasses.TabIndex = 0;
            this.dgwClasses.SelectionChanged += new System.EventHandler(this.dgwClasses_SelectionChanged);
            // 
            // dgwNomes
            // 
            this.dgwNomes.AllowUserToAddRows = false;
            this.dgwNomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwNomes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            this.dgwNomes.Location = new System.Drawing.Point(459, 12);
            this.dgwNomes.Name = "dgwNomes";
            this.dgwNomes.ReadOnly = true;
            this.dgwNomes.Size = new System.Drawing.Size(145, 175);
            this.dgwNomes.TabIndex = 2;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nome dos alunos matriculados";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mkdHora);
            this.groupBox1.Controls.Add(this.txtMatriculados);
            this.groupBox1.Controls.Add(this.txtDia);
            this.groupBox1.Controls.Add(this.txtProfessor);
            this.groupBox1.Location = new System.Drawing.Point(163, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 164);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Turma";
            // 
            // txtProfessor
            // 
            this.txtProfessor.Enabled = false;
            this.txtProfessor.Location = new System.Drawing.Point(69, 37);
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.Size = new System.Drawing.Size(207, 20);
            this.txtProfessor.TabIndex = 0;
            // 
            // txtDia
            // 
            this.txtDia.Enabled = false;
            this.txtDia.Location = new System.Drawing.Point(96, 72);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(98, 20);
            this.txtDia.TabIndex = 1;
            // 
            // txtMatriculados
            // 
            this.txtMatriculados.Enabled = false;
            this.txtMatriculados.Location = new System.Drawing.Point(191, 110);
            this.txtMatriculados.Name = "txtMatriculados";
            this.txtMatriculados.Size = new System.Drawing.Size(85, 20);
            this.txtMatriculados.TabIndex = 2;
            // 
            // mkdHora
            // 
            this.mkdHora.Enabled = false;
            this.mkdHora.Location = new System.Drawing.Point(239, 72);
            this.mkdHora.Mask = "00:00";
            this.mkdHora.Name = "mkdHora";
            this.mkdHora.Size = new System.Drawing.Size(37, 20);
            this.mkdHora.TabIndex = 3;
            this.mkdHora.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Professor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dia da semana:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hora:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantidade de alunos matriculados:";
            // 
            // a
            // 
            this.a.HeaderText = "Codigo da Turma";
            this.a.Name = "a";
            this.a.ReadOnly = true;
            // 
            // ConsultarClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 199);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwNomes);
            this.Controls.Add(this.dgwClasses);
            this.Name = "ConsultarClasse";
            this.Text = "ConsultarClasse";
            ((System.ComponentModel.ISupportInitialize)(this.dgwClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwNomes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwClasses;
        private System.Windows.Forms.DataGridView dgwNomes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mkdHora;
        private System.Windows.Forms.TextBox txtMatriculados;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtProfessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn a;
    }
}