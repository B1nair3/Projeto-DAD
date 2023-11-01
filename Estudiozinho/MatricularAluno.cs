﻿using MySql.Data.MySqlClient;
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
            List<int> listaValidacao = new List<int>();

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
                if (listaValidacao.Contains(modalidade.Id) == false)
                {
                    listaModalidades.Add(modalidade);
                    listaValidacao.Add(int.Parse(rTurmaMod["idModalidade"].ToString()));
                }
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
            try
            {
                int idTurma = -91;
                int idModalidade = -91;
                string cpf = mkdCpfAluno.Text;
                int maximo = int.Parse(txtMaximo.Text);
                int matriculados = int.Parse(txtMatriculados.Text);

                Modalidade modalidade = new Modalidade(txtModalidade.Text);
                MySqlDataReader m = modalidade.consultaModalidade();
                m.Read();
                idModalidade = int.Parse(m["idEstudio_Modalidade"].ToString());
                DAO_Conexão.con.Close();

                Turma turma = new Turma(txtProfessor.Text, txtDia.Text, mkdHora.Text, idModalidade);
                Console.WriteLine("\n\n" + txtProfessor.Text + "\n" + txtDia.Text + "\n" + mkdHora.Text + "\n" + idModalidade);
                MySqlDataReader t = turma.consultarIdTurma();
                while (t.Read())
                {
                     idTurma = int.Parse(t["idEstudio_Turma"].ToString());
                }
                DAO_Conexão.con.Close();

                Classe classe = new Classe(idTurma, cpf);
                if (matriculados < maximo)
                {
                    if (classe.cadastrarAluno())
                    {
                        MySqlDataReader c = classe.consultaMatriculados();
                        c.Read();
                        Turma matricular 
                        MessageBox.Show("Aluno cadastrado na turma!");
                    }
                    else
                    {
                        MessageBox.Show("Falha ao cadastrar aluno na turma!");
                    }
                }
                else
                {
                    MessageBox.Show("Sinto muito, mas aparentemente essa turma já esta cheia!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DAO_Conexão.con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpar();
        }

        public void limpar()
        {
            txtDia.Text = "";
            txtMatriculados.Text = "";
            txtMaximo.Text = "";
            txtModalidade.Text = "";
            txtNomeAluno.Text = "";
            txtProfessor.Text = "";
            mkdCpfAluno.Text = "";
            mkdHora.Text = "";
        }

        private void dgwTurma_SelectionChanged(object sender, EventArgs e)
        {
            String professor = dgwTurma.SelectedRows[0].Cells[0].Value.ToString();
            txtProfessor.Text = professor;
            String modalidade = dgwTurma.SelectedRows[0].Cells[1].Value.ToString();
            txtModalidade.Text = modalidade;
            String dia = dgwTurma.SelectedRows[0].Cells[2].Value.ToString();
            txtDia.Text = dia;
            String hora = dgwTurma.SelectedRows[0].Cells[3].Value.ToString();
            mkdHora.Text = hora;
            String matriculados = dgwTurma.SelectedRows[0].Cells[4].Value.ToString();
            txtMatriculados.Text = matriculados;
            String maximo = dgwTurma.SelectedRows[0].Cells[5].Value.ToString();
            txtMaximo.Text = maximo;
        }

        private void dgwAluno_SelectionChanged(object sender, EventArgs e)
        {
            String nome = dgwAluno.SelectedRows[0].Cells[0].Value.ToString();
            txtNomeAluno.Text = nome;
            String cpf = dgwAluno.SelectedRows[0].Cells[1].Value.ToString();
            mkdCpfAluno.Text = cpf;
        }
    }
}
