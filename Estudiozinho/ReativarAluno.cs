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
    public partial class ReativarAluno : Form
    {
        public ReativarAluno()
        {
            InitializeComponent();
            atualizaComboBox();
        }


        public void atualizaComboBox()
        {
            Aluno aluno = new Aluno();
            try
            {
                MySqlDataReader r = aluno.consultarTodosAlunosDesativos();
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Aluno aluno = new Aluno(txtNome.Text, 0);
                aluno.reativarAluno();
                MessageBox.Show("Aluno reativado com sucesso!");
                txtNome.Text = "";
                atualizaComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao reativar");
            }
        }
    }
}
