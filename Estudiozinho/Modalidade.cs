using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Estudiozinho
{
    class Modalidade
    {
        private String descricao;
        private float preco;
        private int qntAlunos, qntAulas, id;

        public string Descricao { get => descricao; set => descricao = value; }
        public float Preco { get => preco; set => preco = value; }
        public int QntAlunos { get => qntAlunos; set => qntAlunos = value; }
        public int QntAulas { get => qntAulas; set => qntAulas = value; }
        public int Id { get => id; set => id = value; }

        public Modalidade(string descricao, float preco, int qntAlunos, int qntAulas)
        {
            this.descricao = descricao;
            this.preco = preco;
            this.qntAlunos = qntAlunos;
            this.qntAulas = qntAulas;
        }

        public Modalidade(string descricao)
        {
            this.descricao = descricao;
        }

        public Modalidade(int id)
        {
            this.Id = id;
        }

        public Modalidade(){}

        public bool cadastrarModalidade()
        {
            bool cad = false;
            try
            {
                DAO_Conexão.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Estudio_Modalidade (descricaoModalidade, precoModalidade, qntAlunos, qntAulas)" +
                    "values ('" + descricao + "','" + preco + "'," + qntAlunos + "," + qntAulas + ")", DAO_Conexão.con);
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

        public MySqlDataReader consultaModalidade()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexão.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Modalidade where descricaoModalidade = '" + descricao +
                    "'", DAO_Conexão.con);
                resultado = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return resultado;
        }

        public bool existeModalidade()
        {
            bool existe = false;
            MySqlDataReader resultado = null;

            try
            {
                DAO_Conexão.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Modalidade where descricaoModalidade = '"
                    + descricao + "'", DAO_Conexão.con);
                resultado = consulta.ExecuteReader();
                if (resultado.Read())
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

        public String consultaDescricao()
        {
            MySqlDataReader resultado = null;
            String modalidade = "penis";
            try
            {
                DAO_Conexão.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Modalidade where idEstudio_Modalidade = " + Id, DAO_Conexão.con);
                resultado = consulta.ExecuteReader();
                resultado.Read();
                modalidade = resultado["descricaoModalidade"].ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexão.con.Close();
            }
            return modalidade;
        }

        public String consultaMaximo()
        {
            MySqlDataReader resultado = null;
            String modalidade = "penis";
            try
            {
                DAO_Conexão.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Modalidade where idEstudio_Modalidade = " + Id, DAO_Conexão.con);
                resultado = consulta.ExecuteReader();
                resultado.Read();
                modalidade = resultado["qntAlunos"].ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexão.con.Close();
            }
            return modalidade;
        }

        public MySqlDataReader consultaTodasModalidade()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexão.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Modalidade where ativa = 0", DAO_Conexão.con);
                resultado = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return resultado;
        }

        public MySqlDataReader consultaTodasModalidadeDesativas()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexão.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Modalidade where ativa = 1", DAO_Conexão.con);
                resultado = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return resultado;
        }

        public bool atualizarModalidade(int id)
        {
            bool cad = false;
            try
            {
                DAO_Conexão.con.Open();
                MySqlCommand atualiza = new MySqlCommand("update Estudio_Modalidade set qntAlunos = " + qntAlunos + ", qntAulas = " + qntAulas +
                    ", precoModalidade = '" + preco + "', descricaoModalidade = '" + descricao + "' where idEstudio_Modalidade = " + id, DAO_Conexão.con);
                atualiza.ExecuteNonQuery();
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

        public bool reativarModalidade()
        {
            bool cad = false;
            try
            {
                DAO_Conexão.con.Open();
                MySqlCommand atualiza = new MySqlCommand("update Estudio_Modalidade set ativa = 0 where descricaoModalidade = '"
                    + descricao + "'", DAO_Conexão.con);
                atualiza.ExecuteNonQuery();
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

        public bool excluirModalidade()
        {
            bool existe = false;
            try
            {
                DAO_Conexão.con.Open();
                MySqlCommand exclui = new MySqlCommand("update Estudio_Modalidade set ativa = 1 where descricaoModalidade = '" +
                    descricao + "'", DAO_Conexão.con);
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
    }
}
