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
    public partial class CadastrarAluno : Form
    {
        DialogResult resultado = DialogResult.No;
        public CadastrarAluno()
        {
            InitializeComponent();
        }

        private void btmCadastrar_Click(object sender, EventArgs e)
        {
            byte[] foto = ConverterFotoParaByteArray();
            Aluno aluno = new Aluno(mkdCpf.Text, txtNome.Text, txtEndereco.Text, txtNumero.Text, txtBairro.Text, txtComplemento.Text, mkdCep.Text,
            txtCidade.Text, txtEstado.Text, mkdTelefone.Text, txtEmail.Text, foto);

            if (resultado == DialogResult.Yes)
            {
                if (aluno.atualizarAluno())
                {
                    MessageBox.Show("Dados atualizados com sucesso!");
                    resultado = DialogResult.No;
                    limpar();
                    mkdCpf.Enabled = true;
                    btnLimpar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Falha ao atualizar dados!");
                }
                btmCadastrar.Text = "Cadastrar";
            }
            else
            {
                if (aluno.cadastrarAluno())
                {
                    MessageBox.Show("Cadastro concluido!");
                    limpar();
                }
                else
                {
                    MessageBox.Show("Falha no cadastro! CPF já cadastrado!");
                }
            }
        }
        private void mkdCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            Aluno aluno = new Aluno(mkdCpf.Text);
            if (e.KeyChar == 13)
            {
                if (aluno.verificaCPF())
                {
                    if (aluno.consultarAluno())
                    {
                        DialogResult result = MessageBox.Show("Aluno já cadastrado! Você deseja atualizar os dados?", "Aluno já existente",
                            MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            MySqlDataReader r = aluno.consultarAluno01();
                            r.Read();
                            txtNome.Text = r["nomeAluno"].ToString();
                            txtEndereco.Text = r["ruaAluno"].ToString();
                            txtNumero.Text = r["numeroAluno"].ToString();
                            txtBairro.Text = r["bairroAluno"].ToString();
                            txtComplemento.Text = r["complementoAluno"].ToString();
                            mkdCep.Text = r["cepAluno"].ToString();
                            txtCidade.Text = r["cidadeAluno"].ToString();
                            txtEstado.Text = r["estadoAluno"].ToString();
                            mkdTelefone.Text = r["telefoneAluno"].ToString();
                            txtEmail.Text = r["emailAluno"].ToString();
                            mkdCpf.Enabled = false;
                            resultado = result;
                            btnLimpar.Enabled = false;
                            btmCadastrar.Text = "Atualizar";
                        }
                    }
                    else
                    {
                        txtNome.Focus();
                    }
                    DAO_Conexão.con.Close(); //somente fecha depois de retornar
                }
                else
                {
                    MessageBox.Show("Numero de CPF inválido!");
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        public void limpar()
        {
                mkdCpf.Text = "";
                mkdTelefone.Text = "";
                mkdCep.Text = "";
                txtNome.Text = "";
                txtBairro.Text = "";
                txtComplemento.Text = "";
                txtNumero.Text = "";
                txtCidade.Text = "";
                txtEstado.Text = "";
                txtEmail.Text = "";
                txtEndereco.Text = "";
        }

        private void btmFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Title = "Abrir Foto";
            dialog.Filter = "JPG (*.jpg)|*.jpg" + "|All files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(dialog.OpenFile());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel carregar a foto: " + ex.Message);
                }
            }
            dialog.Dispose();
        }

        private byte[] ConverterFotoParaByteArray()
        {
            using (var stream = new System.IO.MemoryStream()) 
            {
                pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                stream.Seek(0, System.IO.SeekOrigin.Begin);
                byte[] bArray = new byte[stream.Length];
                stream.Read(bArray, 0, System.Convert.ToInt32(stream.Length));
                return bArray;
            }
        }
    }
}