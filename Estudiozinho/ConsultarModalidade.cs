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
    public partial class ConsultarModalidade : Form
    {
        public ConsultarModalidade()
        {
            InitializeComponent();
            atualizaComboBox();
        }

        public void atualizaComboBox()
        {
            Modalidade modalidade = new Modalidade();
            try
            {
                MySqlDataReader r = modalidade.consultaTodasModalidade();
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

        private void txtDescricao_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String descricao = txtDescricao.Text;
                Modalidade escolha = new Modalidade(descricao);
                MySqlDataReader r = escolha.consultaModalidade();
                r.Read();
                txtAlunos.Text = r["qntAlunos"].ToString();
                txtAulas.Text = r["qntAulas"].ToString();
                txtPreco.Text = r["precoModalidade"].ToString();
            }
            finally
            {
                DAO_Conexão.con.Close();
            }
        }
    }
}
