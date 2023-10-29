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
    public partial class ConsultarTurma : Form
    {
        public ConsultarTurma()
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

        private void txtId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                Turma turma = new Turma(id);
                MySqlDataReader r = turma.consultarTurma();
                r.Read();
                txtProfessor.Text = r["professorTurma"].ToString();
                txtDia.Text = r["diaSemanaTurma"].ToString();
                mkdHora.Text = r["horaTurma"].ToString();
                txtMatriculados.Text = r["nAlunosMatriculados"].ToString();

                Modalidade idModalidade = new Modalidade(int.Parse(r["idModalidade"].ToString()));
                DAO_Conexão.con.Close();
                String descricao = idModalidade.consultaDescricao();
                Modalidade modalidade = new Modalidade(descricao);
                MySqlDataReader m = modalidade.consultaModalidade();
                m.Read();
                txtModalidade.Text = m["descricaoModalidade"].ToString();
                txtMaximoAluno.Text = m["qntAlunos"].ToString();
            }
            finally
            {
                DAO_Conexão.con.Close();
            }
        }
    }
}
