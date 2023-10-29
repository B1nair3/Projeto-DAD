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
    public partial class ConsultarAluno : Form
    {
        public ConsultarAluno()
        {
            InitializeComponent();
            atualizaComboBox();
        }

        public void atualizaComboBox()
        {
            Aluno aluno = new Aluno();
            try
            {
                MySqlDataReader r = aluno.consultarTodosAlunos();
                if (r.HasRows)
                {
                    txtNome.Items.Clear();
                    while (r.Read())
                    {
                        txtNome.Items.Add(r["nomeAluno"].ToString());
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Aluno aluno = new Aluno(txtNome.Text, 0);
                MySqlDataReader r = aluno.consultarAlunoNome();
                r.Read();
                txtBairro.Text = r["bairroAluno"].ToString();
                txtCidade.Text = r["cidadeAluno"].ToString();
                txtComplemento.Text = r["complementoAluno"].ToString();
                txtEmail.Text = r["emailAluno"].ToString();
                txtEndereco.Text = r["ruaAluno"].ToString();
                txtEstado.Text = r["estadoAluno"].ToString();
                txtNumero.Text = r["numeroAluno"].ToString();
                mkdCep.Text = r["CEPAluno"].ToString();
                mkdTelefone.Text = r["telefoneAluno"].ToString();
            }
            finally
            {
                DAO_Conexão.con.Close();
            }
        }
    }
}
