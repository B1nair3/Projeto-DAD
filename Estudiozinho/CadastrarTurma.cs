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
    public partial class CadastrarTurma : Form
    {
        public CadastrarTurma()
        {
            InitializeComponent();
            Modalidade conMod = new Modalidade();
            MySqlDataReader r = conMod.consultaTodasModalidade();
            while (r.Read())
            {
                dgwTurma.Rows.Add(r["descricaoModalidade"].ToString());
            }
            DAO_Conexão.con.Close();
        }

        private void btnCadastar_Click(object sender, EventArgs e)
        {
            Modalidade modalidadeEscolhida = new Modalidade(txtModalidade.Text);
            MySqlDataReader r = modalidadeEscolhida.consultaModalidade();
            r.Read();
            int idModalidadeEscolhida = int.Parse(r["idEstudio_Modalidade"].ToString());
            int maxAlunos = int.Parse(txtMaximoAluno.Text);
            Turma turma = new Turma(txtProfessor.Text, txtDia.Text, mkdHora.Text, idModalidadeEscolhida, maxAlunos);
            DAO_Conexão.con.Close();

            if (turma.cadastrarTurma())
            {
                MessageBox.Show("Turma cadastrada com sucesso!");
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar Turma!");
            }
        }

        /*
        private void dgwTurma_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            dgwTurma.SelectedRows;
        }
        */
    }
}
