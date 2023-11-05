using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiozinho
{
    class Classe
    {
        int idTurma;
        string cpfAluno;

        public Classe()
        {

        }

        public Classe(int idTurma, string cpfAluno)
        {
            this.idTurma = idTurma;
            this.cpfAluno = cpfAluno;
        }

        public Classe(string cpfAluno)
        {
            this.cpfAluno = cpfAluno;
        }

        public Classe(int idTurma)
        {
            this.idTurma = idTurma;
        }

        public int IdTurma { get => idTurma; set => idTurma = value; }
        public string IdAluno { get => cpfAluno; set => cpfAluno = value; }

        public bool cadastrarAluno()
        {
            bool cad = false;
            try
            {
                DAO_Conexão.con.Open();
                MySqlCommand cadastra = new MySqlCommand("insert into Estudio_Classe (idTurma, cpfAluno) " +
                    "values (" + idTurma + ",'" + cpfAluno + "')", DAO_Conexão.con);
                cadastra.ExecuteNonQuery();
                cad = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DAO_Conexão.con.Close();
            }
            return cad;
        }

        public MySqlDataReader consultaMatriculas()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexão.con.Open();
                MySqlCommand consulta = new MySqlCommand("select * from Estudio_Classe where cpfAluno = '" + cpfAluno + "'", DAO_Conexão.con);
                resultado = consulta.ExecuteReader();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return resultado;
        }


        public MySqlDataReader consultaTodasClasses()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexão.con.Open();
                MySqlCommand consulta = new MySqlCommand("select * from Estudio_Classe", DAO_Conexão.con);
                resultado = consulta.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return resultado;
        }

        public bool desmatriculaAluno()
        {
            bool desmatriculou = false;
            try
            {
                DAO_Conexão.con.Open();
                MySqlCommand desmatricula = new MySqlCommand("delete from Estudio_Classe where idTurma = " + idTurma +
                    " and cpfAluno = '" + cpfAluno + "'", DAO_Conexão.con);
                desmatricula.ExecuteNonQuery();
                desmatriculou = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DAO_Conexão.con.Close();
            }

            return desmatriculou;
        }

        public MySqlDataReader consultaTurmas()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexão.con.Open();
                MySqlCommand busca = new MySqlCommand("select * from Estudio_Classe where idTurma = " + idTurma, DAO_Conexão.con);
                resultado = busca.ExecuteReader();
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

            return resultado;
        }

        public int consultaMatriculados()
        {
            MySqlDataReader resultado = null;
            int qnt = 0;
            try
            {
                DAO_Conexão.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT count(cpfAluno) from Estudio_Classe where idTurma = " + idTurma, DAO_Conexão.con);
                resultado = consulta.ExecuteReader();
                if (resultado.Read())
                {
                    qnt = int.Parse(resultado["count(cpfAluno)"].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexão.con.Close();
            }

            return qnt;
        }
    }
}
