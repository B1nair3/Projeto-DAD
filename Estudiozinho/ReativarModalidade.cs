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
    public partial class ReativarModalidade : Form
    {
        public ReativarModalidade()
        {
            InitializeComponent();
            atualizaComboBox();
        }

        public void atualizaComboBox()
        {
            Modalidade modalidade = new Modalidade();
            try
            {
                MySqlDataReader r = modalidade.consultaTodasModalidadeDesativas();
                if (r.HasRows)
                {
                    txtDescricao.Items.Clear();
                    while (r.Read())
                    {
                        txtDescricao.Items.Add(r["descricaoModalidade"].ToString());
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
                Modalidade modalidade = new Modalidade(txtDescricao.Text);
                modalidade.reativarModalidade();
                MessageBox.Show("Modalidade reativada com sucesso!");
                atualizaComboBox();
                txtDescricao.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao reativar modalidade!");
            }
        }
    }
}
