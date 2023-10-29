namespace Estudiozinho
{
    partial class ConsultarTurma
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
            this.txtId = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mkdHora = new System.Windows.Forms.MaskedTextBox();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.txtModalidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaximoAluno = new System.Windows.Forms.TextBox();
            this.txtMatriculados = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID da Turma:";
            // 
            // txtId
            // 
            this.txtId.FormattingEnabled = true;
            this.txtId.Location = new System.Drawing.Point(181, 28);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(169, 21);
            this.txtId.TabIndex = 1;
            this.txtId.SelectedIndexChanged += new System.EventHandler(this.txtId_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMatriculados);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMaximoAluno);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.mkdHora);
            this.groupBox1.Controls.Add(this.txtDia);
            this.groupBox1.Controls.Add(this.txtProfessor);
            this.groupBox1.Controls.Add(this.txtModalidade);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(23, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 175);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Turma";
            // 
            // mkdHora
            // 
            this.mkdHora.Enabled = false;
            this.mkdHora.Location = new System.Drawing.Point(349, 87);
            this.mkdHora.Mask = "00:00";
            this.mkdHora.Name = "mkdHora";
            this.mkdHora.Size = new System.Drawing.Size(36, 20);
            this.mkdHora.TabIndex = 19;
            // 
            // txtDia
            // 
            this.txtDia.Enabled = false;
            this.txtDia.Location = new System.Drawing.Point(108, 87);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(181, 20);
            this.txtDia.TabIndex = 18;
            // 
            // txtProfessor
            // 
            this.txtProfessor.Enabled = false;
            this.txtProfessor.Location = new System.Drawing.Point(108, 61);
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.Size = new System.Drawing.Size(277, 20);
            this.txtProfessor.TabIndex = 17;
            // 
            // txtModalidade
            // 
            this.txtModalidade.Enabled = false;
            this.txtModalidade.Location = new System.Drawing.Point(108, 35);
            this.txtModalidade.Name = "txtModalidade";
            this.txtModalidade.Size = new System.Drawing.Size(277, 20);
            this.txtModalidade.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Hora:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Dia da Semana";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Professor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Modalidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Max Alunos:";
            // 
            // txtMaximoAluno
            // 
            this.txtMaximoAluno.Enabled = false;
            this.txtMaximoAluno.Location = new System.Drawing.Point(108, 113);
            this.txtMaximoAluno.Name = "txtMaximoAluno";
            this.txtMaximoAluno.Size = new System.Drawing.Size(277, 20);
            this.txtMaximoAluno.TabIndex = 21;
            // 
            // txtMatriculados
            // 
            this.txtMatriculados.Enabled = false;
            this.txtMatriculados.Location = new System.Drawing.Point(108, 139);
            this.txtMatriculados.Name = "txtMatriculados";
            this.txtMatriculados.Size = new System.Drawing.Size(277, 20);
            this.txtMatriculados.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Qnt alunos:";
            // 
            // ConsultarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 253);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Name = "ConsultarTurma";
            this.Text = "ConsultarTurma";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mkdHora;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtProfessor;
        private System.Windows.Forms.TextBox txtModalidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaximoAluno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMatriculados;
        private System.Windows.Forms.Label label7;
    }
}