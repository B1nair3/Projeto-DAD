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
    public partial class DesmatricularAluno : Form
    {
        public DesmatricularAluno()
        {
            InitializeComponent();
            atualizaDataGridViewAluno();
        }

        private void atualizaDataGridViewAluno()
        {
            Aluno aluno = new Aluno();
            MySqlDataReader rAluno = aluno.consultarTodosAlunos();

            dgwAluno.Rows.Clear();
            while (rAluno.Read())
            {
                dgwAluno.Rows.Add(rAluno["nomeAluno"].ToString(), rAluno["cpfAluno"].ToString());
            }
            DAO_Conexão.con.Close();
        }

        private void atualizaTurmaPorAluno(String cpf)
        {
            List<Turma> listaTurma = new List<Turma>();

            Classe classe = new Classe(cpf);
            MySqlDataReader rClasse = classe.consultaMatriculas();
            while (rClasse.Read())
            {
                Turma turma = new Turma(int.Parse(rClasse["idTurma"].ToString()));
                listaTurma.Add(turma);
            }
            DAO_Conexão.con.Close();

            dgwTurma.Rows.Clear();
            foreach (Turma t in listaTurma)
            {
                MySqlDataReader rTurma = t.consultarTurma();
                while (rTurma.Read())
                {
                    dgwTurma.Rows.Add(rTurma["professorTurma"].ToString(), rTurma["diaSemanaTurma"].ToString(),
                        rTurma["horaTurma"].ToString());
                }
                DAO_Conexão.con.Close();
            }
        }

        private void atualizaMatriculados()
        {
            List<Classe> listaClasse = new List<Classe>();
            Turma turma = new Turma();

            MySqlDataReader rTurma = turma.consultaTodasTurmas();
            while (rTurma.Read())
            {
                int idTurma = int.Parse(rTurma["idEstudio_Turma"].ToString());
                Classe classe = new Classe(idTurma);
                listaClasse.Add(classe);
            }
            DAO_Conexão.con.Close();

            foreach (Classe c in listaClasse)
            {
                int qntMatriculados = c.consultaMatriculados();
                Turma definir = new Turma(c.IdTurma, qntMatriculados);
                if (definir.defineMatriculados())
                {
                    Console.WriteLine("Turma com id " + c.IdTurma + " matriculas definidas");
                }
            }
        }

        private void btnDesmatricular_Click(object sender, EventArgs e)
        {

        }

        private void dgwAluno_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                String nome = dgwAluno.SelectedRows[0].Cells[0].Value.ToString();
                txtNomeAluno.Text = nome;
                String cpf = dgwAluno.SelectedRows[0].Cells[1].Value.ToString();
                mkdCpfAluno.Text = cpf;

                atualizaTurmaPorAluno(cpf);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void dgwTurma_SelectionChanged_1(object sender, EventArgs e)
        {
            try
            {
                String professor = dgwTurma.SelectedRows[0].Cells[0].Value.ToString();
                txtProfessor.Text = professor;
                String dia = dgwTurma.SelectedRows[0].Cells[2].Value.ToString();
                txtDia.Text = dia;
                String hora = dgwTurma.SelectedRows[0].Cells[3].Value.ToString();
                mkdHora.Text = hora;
                String maximo = dgwTurma.SelectedRows[0].Cells[5].Value.ToString();
                txtMaximo.Text = maximo;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
