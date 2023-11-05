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
    public partial class ConsultarClasse : Form
    {
        public ConsultarClasse()
        {
            InitializeComponent();
            atualizaDgwClasses();
        }

        public void atualizaDgwClasses()
        {
            List<int> listaIds = new List<int>();

            Classe classe = new Classe();
            MySqlDataReader rClasse = classe.consultaTodasClasses();

            while (rClasse.Read())
            {
                if(listaIds.Contains(int.Parse(rClasse["idTurma"].ToString())) != true)
                {
                    dgwClasses.Rows.Add(rClasse["idTurma"].ToString());
                    listaIds.Add(int.Parse(rClasse["idTurma"].ToString()));
                }
                else
                {
                    Console.WriteLine("Turma com id " + rClasse["idTurma"].ToString() + " já esta na lista. Pulando elemento...");
                }
            }
            DAO_Conexão.con.Close();
        }

        public void atualizaDgwAlunos(int idTurma)
        {
            List<Aluno> listaAlunos = new List<Aluno>();

            Classe classe = new Classe(idTurma);
            MySqlDataReader rClasse = classe.consultaTurmas();
            while (rClasse.Read())
            {
                Aluno aluno = new Aluno(rClasse["cpfAluno"].ToString());
                listaAlunos.Add(aluno);
            }
            DAO_Conexão.con.Close();

            dgwNomes.Rows.Clear();
            foreach(Aluno a in listaAlunos)
            {
                MySqlDataReader rAluno = a.consultarAluno01();
                if (rAluno.Read())
                {
                    dgwNomes.Rows.Add(rAluno["nomeAluno"].ToString());
                }
                DAO_Conexão.con.Close();
            }
        }

        private void dgwClasses_SelectionChanged(object sender, EventArgs e)
        {
            int idTurma = int.Parse(dgwClasses.SelectedRows[0].Cells[0].Value.ToString());
            Turma turma = new Turma(idTurma);
            MySqlDataReader rTurma = turma.consultarTurma();
            if(rTurma.Read())
            {
                txtDia.Text = rTurma["diaSemanaTurma"].ToString();
                txtProfessor.Text = rTurma["professorTurma"].ToString();
                txtMatriculados.Text = rTurma["nAlunosMatriculados"].ToString();
                mkdHora.Text = rTurma["horaTurma"].ToString();
                DAO_Conexão.con.Close();

                atualizaDgwAlunos(idTurma);
            }
        }
    }
}
