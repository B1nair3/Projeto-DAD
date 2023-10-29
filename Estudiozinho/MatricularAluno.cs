using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
            string maximo = "Falha";
            string descricao = "Falha";
            List<Modalidade> listaModalidades = new List<Modalidade>();
            List<Turma> listaTurmas = new List<Turma>();

            Aluno aluno = new Aluno();
            MySqlDataReader rAluno = aluno.consultarTodosAlunos();
            while (rAluno.Read())
            {
                dgwAluno.Rows.Add(rAluno["nomeAluno"].ToString(), rAluno["cpfAluno"].ToString());
            }
            DAO_Conexão.con.Close();

            Turma turmaMod = new Turma();
            MySqlDataReader rTurmaMod = turmaMod.consultaTodasTurmas();
            while (rTurmaMod.Read())
            {
                Modalidade modalidade = new Modalidade(int.Parse(rTurmaMod["idModalidade"].ToString()));
                listaModalidades.Add(modalidade);
            }
            DAO_Conexão.con.Close();

            foreach (Modalidade m in listaModalidades)
            {
                descricao = m.consultaDescricao();
                maximo = m.consultaMaximo();

                Turma turma = new Turma(m.Id);
                MySqlDataReader rTurma = turma.consultarTurmaModalidade();
                while (rTurma.Read())
                {
                    dgwTurma.Rows.Add(rTurma["professorTurma"].ToString(), descricao, rTurma["diaSemanaTurma"].ToString(),
                        rTurma["horaTurma"].ToString(), rTurma["nAlunosMatriculados"].ToString(), maximo);
                }
                DAO_Conexão.con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
