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
    public partial class MatricularAluno : Form
    {
        public MatricularAluno()
        {
            InitializeComponent();
            Aluno aluno = new Aluno();
            MySqlDataReader rAluno = aluno.consultarTodosAlunos();
            while (rAluno.Read())
            {
                dgwAluno.Rows.Add(rAluno["nomeAluno"].ToString(), rAluno["cpfAluno"].ToString());
            }
            DAO_Conexão.con.Close();

            Turma turma = new Turma();
            MySqlDataReader rTurma = turma.consultaTodasTurmas();
            while (rTurma.Read())
            {
                Modalidade modalidade = new Modalidade(int.Parse(rTurma["idModalidade"].ToString()));
                dgwTurma.Rows.Add(rTurma["professorTurma"].ToString(), modalidade.consultaDescricao(),
                    rTurma["diaSemanaTurma"].ToString(), rTurma["horaTurma"].ToString(), rTurma["nAlunosMatriculados"].ToString(),
                    modalidade.consultaMaximo());
            }
            DAO_Conexão.con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
