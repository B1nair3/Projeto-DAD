using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiozinho
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            if (DAO_Conexão.getConexao("143.106.241.3", "cl202235", "cl202235", "cl*17062007"))
                Console.WriteLine("Conectado!");
            else Console.WriteLine("Erro de conexão!");
            menuStrip1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cadastrarLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarLogin cadastrarLogin = new CadastrarLogin();
            cadastrarLogin.MdiParent = this;
            cadastrarLogin.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tipo = DAO_Conexão.login(textBox1.Text, textBox2.Text);
            //errado
            if (tipo == 0)
            {
                MessageBox.Show("Falha no Login!");
            }
            //adm
            if (tipo == 1)
            {
                groupBox1.Visible = false;
                menuStrip1.Enabled = true;
            }
            //não adm
            if (tipo == 2)
            {
                groupBox1.Visible = false;
                menuStrip1.Enabled = true;
                cadastrarLoginToolStripMenuItem.Enabled = false;
                cadastrarModalidadeToolStripMenuItem.Enabled = false;
                excluirToolStripMenuItem1.Enabled = false;
                cadastrarTurmaToolStripMenuItem.Enabled = false;
                atualizarTurmaToolStripMenuItem.Enabled = false;
                excluirTurmaToolStripMenuItem.Enabled = false;
            }
        }

        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarAluno cadastrarAluno = new CadastrarAluno();
            cadastrarAluno.MdiParent = this;
            cadastrarAluno.Show();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Excluir excluir = new Excluir();
            excluir.MdiParent = this;
            excluir.Show();
        }

        private void cadastrarModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarModalidade cadastrarModalidade = new CadastrarModalidade();
            cadastrarModalidade.MdiParent = this;
            cadastrarModalidade.Show();
        }

        private void excluirModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcluirModalidade excluir = new ExcluirModalidade();
            excluir.MdiParent = this;
            excluir.Show();
        }

        private void cadastrarTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarTurma cadTurma = new CadastrarTurma();
            cadTurma.MdiParent = this;
            cadTurma.Show();
        }

        private void excluirTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcluirTurma exTurma = new ExcluirTurma();
            exTurma.MdiParent = this;
            exTurma.Show();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sairToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarModalidadeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CadastrarModalidade cadModalidade = new CadastrarModalidade();
            cadModalidade.MdiParent = this;
            cadModalidade.Show();
        }

        private void excluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExcluirModalidade exModalidade = new ExcluirModalidade();
            exModalidade.MdiParent = this;
            exModalidade.Show();
        }

        private void atualizarTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizarTurma attTurma = new AtualizarTurma();
            attTurma.MdiParent = this;
            attTurma.Show();
        }

        private void matriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MatricularAluno mAluno = new MatricularAluno();
            mAluno.MdiParent = this;
            mAluno.Show();
        }

        private void consultarModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarModalidade consultarModalidade = new ConsultarModalidade();
            consultarModalidade.MdiParent = this;
            consultarModalidade.Show();
        }

        private void consultarTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarTurma consultarTurma = new ConsultarTurma();
            consultarTurma.MdiParent = this;
            consultarTurma.Show();
        }

        private void consultarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarAluno aluno = new ConsultarAluno(); 
            aluno.MdiParent = this;
            aluno.Show();
        }

        private void reativarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReativarAluno reativar = new ReativarAluno();
            reativar.MdiParent = this;
            reativar.Show();
        }

        private void reativarModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReativarModalidade reativarModal = new ReativarModalidade();
            reativarModal.MdiParent = this;
            reativarModal.Show();
        }
    }
}
