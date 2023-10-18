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
    public partial class AtualizarTurma : Form
    {
        public AtualizarTurma()
        {
            InitializeComponent();
            atualizaComboBoxTurma();
        }

        public void atualizaComboBoxTurma()
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

        private void limpar()
        {
            txtDia.Text = "";
            txtAlunos.Text = "";
            txtHora.Text = "";
            txtId.Text = "";
            txtProfessor.Text = "";
        }

        private void txtId_SelectedIndexChanged(object sender, EventArgs e)
        {
            Turma turma = new Turma(int.Parse(txtId.Text));
            MySqlDataReader r = turma.consultarTurma();
            if (r.HasRows)
            {
                r.Read();
                txtHora.Text = r["horaTurma"].ToString();
                txtProfessor.Text = r["professorTurma"].ToString();
                txtAlunos.Text = r["nAlunosMatriculados"].ToString();
                txtDia.Text = r["diaSemanaTurma"].ToString();
            }

            DAO_Conexão.con.Close();
            }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Turma turma = new Turma(txtProfessor.Text, txtDia.Text, txtHora.Text, 0, int.Parse(txtAlunos.Text));
                turma.atualizarTurma(int.Parse(txtId.Text));
                MessageBox.Show("Turma atualizada com sucesso!");
                limpar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
