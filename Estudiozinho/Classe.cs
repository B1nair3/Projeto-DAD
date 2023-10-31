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
    }
}
