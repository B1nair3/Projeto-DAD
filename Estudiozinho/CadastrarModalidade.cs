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
    public partial class CadastrarModalidade : Form
    {
        DialogResult atualizar = DialogResult.No;
        int modalidadeEscolhida = -20;
        public CadastrarModalidade()
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            float preco = float.Parse(txtPreco.Text);
            int qntAlunos = int.Parse(txtAlunos.Text), qntAulas = int.Parse(txtAulas.Text);
            String descricao = txtDescricao.Text;
            Modalidade modalidade = new Modalidade(descricao, preco, qntAlunos, qntAulas);

            if (atualizar == DialogResult.No)
            {
                if (modalidade.cadastrarModalidade())
                {
                    MessageBox.Show("Cadastro concluido!");
                    atualizaComboBox();
                    limpar();
                }
                else
                {
                    MessageBox.Show("Falha no cadastro!");
                }
            }
            else
            {
                if (modalidade.atualizarModalidade(modalidadeEscolhida))
                {
                    MessageBox.Show("Modalidade atualizada com sucesso!");
                    atualizaComboBox();
                    limpar();
                    atualizar = DialogResult.No;
                }
                else
                {
                    MessageBox.Show("Falha ao atualizar");
                }
            }
        }

        public void limpar()
        {
            txtAulas.Text = "";
            txtAlunos.Text = "";
            txtDescricao.Text = "";
            txtPreco.Text = "";
        }

        private void txtDescricao_SelectedIndexChanged(object sender, EventArgs e)
        {
            atualizar = MessageBox.Show("Você deseja atualizar a modalidade escolhida?", "Escolha", MessageBoxButtons.YesNo);
            if (atualizar == DialogResult.Yes)
            {
                try
                {
                    String descricao = txtDescricao.Text;
                    Modalidade escolha = new Modalidade(descricao);
                    MySqlDataReader r = escolha.consultaModalidade();
                    r.Read();
                    modalidadeEscolhida = int.Parse(r["idEstudio_Modalidade"].ToString());
                    txtAlunos.Text = r["qntAlunos"].ToString();
                    txtAulas.Text = r["qntAulas"].ToString();
                    txtPreco.Text = r["precoModalidade"].ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    DAO_Conexão.con.Close();
                }
            }    
        }
    }
}
