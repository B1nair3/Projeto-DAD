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
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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
            DAO_Conexão.con.Close();
        }
    }
}
