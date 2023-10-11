using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiozinho
{
    class Turma
    {
        private string professor, diaSemana, hora;
        private int modalidade, alunos, idTurma;

        public string Professor { get => professor; set => professor = value; }
        public string DiaSemana { get => diaSemana; set => diaSemana = value; }
        public string Hora { get => hora; set => hora = value; }
        public int Modalidade { get => modalidade; set => modalidade = value; }
        public int Alunos { get => alunos; set => alunos = value; }

        public Turma() { }

        public Turma(int idTurma)
        {
            this.idTurma = idTurma;
        } 

        public Turma(int modalidade, string diaSemana)
        {
            this.diaSemana = diaSemana;
            this.modalidade = modalidade;
        }

        public Turma(string professor, string diaSemana, string hora, int modalidade, int alunos)
        {
            this.professor = professor;
            this.diaSemana = diaSemana;
            this.hora = hora;
            this.modalidade = modalidade;
            this.alunos = alunos;
        }

        public bool cadastrarTurma()
        {
            bool cad = false;
            try
            {
                DAO_Conexão.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Estudio_Turma (professorTurma, diaSemanaTurma, horaTurma" +
                    ", idModalidade, nAlunosMatriculados) values ('" + professor + "', '" + diaSemana + "', '" + hora + 
                    "', " + modalidade + ", " + alunos + ");", DAO_Conexão.con);
                insere.ExecuteNonQuery();
                cad = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexão.con.Close();
            }
            return cad;
        }

        public bool excluirTurma()
        {
            bool existe = false;
            try
            {
                DAO_Conexão.con.Open();
                MySqlCommand exclui = new MySqlCommand("update Estudio_Turma set ativa = 1 where idEstudio_Turma = " +
                    idTurma, DAO_Conexão.con);
                exclui.ExecuteNonQuery();
                existe = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexão.con.Close();
            }

            return existe;
        }

        public MySqlDataReader consultaTodasTurmas()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexão.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Turma where ativa = 0", DAO_Conexão.con);
                resultado = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return resultado;
        }

        public MySqlDataReader consultarTurma()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexão.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Turma where idEstudio_Turma = " + idTurma, DAO_Conexão.con);
                resultado = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return resultado;
        }
    }
}
