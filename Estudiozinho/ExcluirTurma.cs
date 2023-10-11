using MySql.Data.MySqlClient;
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
    public partial class ExcluirTurma : Form
    {
        public ExcluirTurma()
        {
            InitializeComponent();
            atualizaComboBox();
        }

        public void atualizaComboBox()
        {
            Turma turma = new Turma();
            try
            {
                MySqlDataReader r = turma.consultaTodasTurmas();
                if (r.HasRows)
                {
                    txtId.Items.Clear();
                    while (r.Read())
                    {
                        txtId.Items.Add(r["idEstudio_Turma"].ToString());
                    }
                }
                r.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                DAO_Conexão.con.Close();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Turma turma = new Turma(int.Parse(txtId.Text));

                    if (turma.excluirTurma())
                    {
                        atualizaComboBox();
                        MessageBox.Show("Turma excluída com sucesso!");
                        txtId.SelectedIndex = -1;
                        limpar();
                    }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void limpar()
        {
            txtDia.Text = "";
            txtAlunos.Text = "";
            txtHora.Text = "";
            txtId.Text = "";
            txtModalidade.Text = "";
            txtProfessor.Text = "";
        }

        private void txtId_SelectedIndexChanged(object sender, EventArgs e)
        {
            Turma turma = new Turma(int.Parse(txtId.Text));
            MySqlDataReader r = turma.consultarTurma();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    txtHora.Text = r["horaTurma"].ToString();
                    txtProfessor.Text = r["professorTurma"].ToString();
                    txtAlunos.Text = r["nAlunosMatriculados"].ToString();
                    txtDia.Text = r["diaSemanaTurma"].ToString();
                    txtModalidade.Text = r["idModalidade"].ToString();
                }
                DAO_Conexão.con.Close();
            }
        }
    }
}
