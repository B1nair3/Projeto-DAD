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
    public partial class ExcluirModalidade : Form
    {
        public ExcluirModalidade()
        {
            InitializeComponent();

            atualizaComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Modalidade modalidade = new Modalidade(comboBox1.SelectedItem.ToString());

                if (modalidade.excluirModalidade())
                {
                    MessageBox.Show("Modalidade excluída com sucesso!");
                    comboBox1.SelectedIndex = -1;

                    MySqlDataReader r = modalidade.consultaModalidade();
                    r.Read();
                    int idModalidade = int.Parse(r["idEstudio_Modalidade"].ToString());
                    DAO_Conexão.con.Close();
                    Turma turma = new Turma();
                    if (turma.excluirTurmaModalidade(idModalidade))
                    {
                        MessageBox.Show("Todas as turmas ligadas a essa modalidade foram desativadas!");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao desativar turmas ligadas a essa modalidade!");
                    }
                }
                else
                {
                    MessageBox.Show("Falha ao excluir modalidade!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                atualizaComboBox();
            }
        }
        public void atualizaComboBox()
        {
            Modalidade modalidade = new Modalidade();
            try
            {
                MySqlDataReader r = modalidade.consultaTodasModalidade();
                if (r.HasRows)
                {
                    comboBox1.Items.Clear();
                    while (r.Read())
                    {
                        comboBox1.Items.Add(r["descricaoModalidade"].ToString());
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
    }
}
