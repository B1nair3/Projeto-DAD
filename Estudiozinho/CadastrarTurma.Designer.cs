
namespace Estudiozinho
{
    partial class CadastrarTurma
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mkdHora = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastar = new System.Windows.Forms.Button();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.txtModalidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwTurma = new System.Windows.Forms.DataGridView();
            this.modalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTurma)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mkdHora);
            this.groupBox1.Controls.Add(this.btnCadastar);
            this.groupBox1.Controls.Add(this.txtDia);
            this.groupBox1.Controls.Add(this.txtProfessor);
            this.groupBox1.Controls.Add(this.txtModalidade);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Turma";
            // 
            // mkdHora
            // 
            this.mkdHora.Location = new System.Drawing.Point(342, 77);
            this.mkdHora.Mask = "00:00";
            this.mkdHora.Name = "mkdHora";
            this.mkdHora.Size = new System.Drawing.Size(36, 20);
            this.mkdHora.TabIndex = 9;
            // 
            // btnCadastar
            // 
            this.btnCadastar.Location = new System.Drawing.Point(18, 121);
            this.btnCadastar.Name = "btnCadastar";
            this.btnCadastar.Size = new System.Drawing.Size(360, 23);
            this.btnCadastar.TabIndex = 8;
            this.btnCadastar.Text = "Cadastrar Turma";
            this.btnCadastar.UseVisualStyleBackColor = true;
            this.btnCadastar.Click += new System.EventHandler(this.btnCadastar_Click);
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(101, 77);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(181, 20);
            this.txtDia.TabIndex = 6;
            // 
            // txtProfessor
            // 
            this.txtProfessor.Location = new System.Drawing.Point(101, 51);
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.Size = new System.Drawing.Size(277, 20);
            this.txtProfessor.TabIndex = 5;
            // 
            // txtModalidade
            // 
            this.txtModalidade.Location = new System.Drawing.Point(101, 25);
            this.txtModalidade.Name = "txtModalidade";
            this.txtModalidade.Size = new System.Drawing.Size(277, 20);
            this.txtModalidade.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hora:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dia da Semana";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Professor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modalidade:";
            // 
            // dgwTurma
            // 
            this.dgwTurma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTurma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modalidade});
            this.dgwTurma.Location = new System.Drawing.Point(423, 20);
            this.dgwTurma.MultiSelect = false;
            this.dgwTurma.Name = "dgwTurma";
            this.dgwTurma.ReadOnly = true;
            this.dgwTurma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwTurma.Size = new System.Drawing.Size(144, 159);
            this.dgwTurma.TabIndex = 9;
            this.dgwTurma.SelectionChanged += new System.EventHandler(this.dgwTurma_SelectionChanged);
            // 
            // modalidade
            // 
            this.modalidade.HeaderText = "Modalidade";
            this.modalidade.Name = "modalidade";
            this.modalidade.ReadOnly = true;
            // 
            // CadastrarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 199);
            this.Controls.Add(this.dgwTurma);
            this.Controls.Add(this.groupBox1);
            this.Name = "CadastrarTurma";
            this.Text = "CadastrarTurma";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTurma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProfessor;
        private System.Windows.Forms.TextBox txtModalidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwTurma;
        private System.Windows.Forms.Button btnCadastar;
        private System.Windows.Forms.MaskedTextBox mkdHora;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn modalidade;
    }
}