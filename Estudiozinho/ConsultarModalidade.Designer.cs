namespace Estudiozinho
{
    partial class ConsultarModalidade
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
            this.txtDescricao = new System.Windows.Forms.ComboBox();
            this.txtAulas = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtAlunos = new System.Windows.Forms.TextBox();
            this.lblQntAula = new System.Windows.Forms.Label();
            this.lblQntAluno = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.FormattingEnabled = true;
            this.txtDescricao.Location = new System.Drawing.Point(132, 35);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(281, 21);
            this.txtDescricao.TabIndex = 12;
            this.txtDescricao.SelectedIndexChanged += new System.EventHandler(this.txtDescricao_SelectedIndexChanged);
            // 
            // txtAulas
            // 
            this.txtAulas.Enabled = false;
            this.txtAulas.Location = new System.Drawing.Point(313, 88);
            this.txtAulas.Name = "txtAulas";
            this.txtAulas.Size = new System.Drawing.Size(100, 20);
            this.txtAulas.TabIndex = 19;
            // 
            // txtPreco
            // 
            this.txtPreco.Enabled = false;
            this.txtPreco.Location = new System.Drawing.Point(132, 62);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(281, 20);
            this.txtPreco.TabIndex = 18;
            // 
            // txtAlunos
            // 
            this.txtAlunos.Enabled = false;
            this.txtAlunos.Location = new System.Drawing.Point(132, 88);
            this.txtAlunos.Name = "txtAlunos";
            this.txtAlunos.Size = new System.Drawing.Size(100, 20);
            this.txtAlunos.TabIndex = 17;
            // 
            // lblQntAula
            // 
            this.lblQntAula.AutoSize = true;
            this.lblQntAula.Location = new System.Drawing.Point(239, 91);
            this.lblQntAula.Name = "lblQntAula";
            this.lblQntAula.Size = new System.Drawing.Size(71, 13);
            this.lblQntAula.TabIndex = 16;
            this.lblQntAula.Text = "Qnt de Aulas:";
            // 
            // lblQntAluno
            // 
            this.lblQntAluno.AutoSize = true;
            this.lblQntAluno.Location = new System.Drawing.Point(49, 91);
            this.lblQntAluno.Name = "lblQntAluno";
            this.lblQntAluno.Size = new System.Drawing.Size(77, 13);
            this.lblQntAluno.TabIndex = 15;
            this.lblQntAluno.Text = "Qnt de Alunos:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(49, 65);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(38, 13);
            this.lblPreco.TabIndex = 14;
            this.lblPreco.Text = "Preço:";
            // 
            // ConsultarModalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 147);
            this.Controls.Add(this.txtAulas);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtAlunos);
            this.Controls.Add(this.lblQntAula);
            this.Controls.Add(this.lblQntAluno);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label1);
            this.Name = "ConsultarModalidade";
            this.Text = "ConsultarModalidade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtDescricao;
        private System.Windows.Forms.TextBox txtAulas;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtAlunos;
        private System.Windows.Forms.Label lblQntAula;
        private System.Windows.Forms.Label lblQntAluno;
        private System.Windows.Forms.Label lblPreco;
    }
}