using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiozinho
{
    class Aluno
    {
        #region
        private string cpf;
        private string nome;
        private string rua;
        private string numero;
        private string bairro;
        private string complemento;
        private string cep;
        private string cidade;
        private string estado;
        private string telefone;
        private string email;
        private byte[] foto;
        private bool ativo;

        public Aluno(string cpf, string nome, string rua, string numero, string bairro, string complemento, string cep,
            string cidade, string estado, string telefone, string email, byte[] foto, bool ativo)
        {
            setCpf(cpf);
            setNome(nome);
            setRua(rua);
            setNumero(numero);
            setBairro(bairro);
            setComplemento(complemento);
            setCep(cep);
            setCidade(cidade);
            setEstado(estado);
            setTelefone(telefone);
            setEmail(email);
            setFoto(foto);
            setAtivo(ativo);
        }

        public Aluno(string cpf)
        {
            setCpf(cpf);
        }

        public Aluno(string cpf, string nome, string rua, string numero, string bairro, string complemento, string cep,
            string cidade, string estado, string telefone, string email)
        {
            setCpf(cpf);
            setNome(nome);
            setRua(rua);
            setNumero(numero);
            setBairro(bairro);
            setComplemento(complemento);
            setCep(cep);
            setCidade(cidade);
            setEstado(estado);
            setTelefone(telefone);
            setEmail(email);
        }

        public Aluno(){}

        public Aluno(string nome, int gambiarra)
        {
            this.nome = nome;
        }

        public bool verificaCPF() //string CPF - sem parâmetro
        {
            int soma, resto, cont = 0;
            soma = 0;

            cpf = cpf.Trim();
            cpf = cpf.Replace(",", "");
            cpf = cpf.Replace("-", "");

            for (int i = 0; i < cpf.Length; i++)
            {
                int a = cpf[0] - '0';
                int b = cpf[i] - '0';

                if (a == b) cont++;
            }

            if (cont == 11) return false;

            for (int i = 1; i <= 9; i++) soma += int.Parse(cpf.Substring(i - 1, 1)) * (11 - i);

            resto = (soma * 10) % 11;

            if ((resto == 10) || (resto == 11)) resto = 0;

            if (resto != int.Parse(cpf.Substring(9, 1))) return false;

            soma = 0;

            for (int i = 1; i <= 10; i++) soma += int.Parse(cpf.Substring(i - 1, 1)) * (12 - i);

            resto = (soma * 10) % 11;

            if ((resto == 10) || (resto == 11)) resto = 0;

            if (resto != int.Parse(cpf.Substring(10, 1))) return false;

            return true;
        }

        public bool cadastrarAluno() {
            bool cad = false;
            try
            {
                DAO_Conexão.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Estudio_Aluno (CPFAluno, nomeAluno, ruaAluno, numeroAluno, bairroAluno," +
                    "complementoAluno, CEPAluno, cidadeAluno, estadoAluno, telefoneAluno, emailAluno) values ('" + cpf + "','" + nome +
                    "','" + rua + "','" + numero + "','" + bairro + "','" + complemento + "','" + cep + "','" + cidade + "','" + estado + "','" +
                    telefone + "','" + email + "')", DAO_Conexão.con);
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

        public bool consultarAluno() {
            bool existe = false;
            try 
            {
                DAO_Conexão.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Aluno where cpfAluno = '" + cpf + "'", DAO_Conexão.con);
                MySqlDataReader resultado = consulta.ExecuteReader(); 

                if (resultado.Read())
                    existe = true;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
            finally {
                DAO_Conexão.con.Close();
            }

            return existe;
        }

        public MySqlDataReader consultarAlunoNome()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexão.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Aluno where nomeAluno = '" + nome + "'", DAO_Conexão.con);
                resultado = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return resultado;
        }

        public MySqlDataReader consultarTodosAlunos()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexão.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Aluno where ativo = 0", DAO_Conexão.con);
                resultado = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return resultado;
        }
        public MySqlDataReader consultarTodosAlunosDesativos()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexão.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Aluno where ativo = 1", DAO_Conexão.con);
                resultado = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return resultado;
        }
        public bool reativarAluno()
        {
            bool cad = false;
            try
            {
                DAO_Conexão.con.Open();
                MySqlCommand atualiza = new MySqlCommand("update Estudio_Aluno set ativo = 0 where nomeAluno = '" + nome + "'", DAO_Conexão.con);
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

        public bool atualizarAluno()
        {
            bool cad = false;
            try
            {
                DAO_Conexão.con.Open();
                MySqlCommand atualiza = new MySqlCommand("update Estudio_Aluno set nomeAluno = '" + nome + "', ruaAluno = '" + rua + "', numeroAluno = '" + numero + 
                    "', bairroAluno = '" + bairro + "', complementoAluno = '" + complemento + "', CEPAluno = '" + cep + "', cidadeAluno = '" + cidade + "', estadoAluno = '" + estado + 
                    "', telefoneAluno = '" + telefone + "', emailAluno = '" + email + "' where cpfAluno = '" + cpf + "';", DAO_Conexão.con);
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

        public MySqlDataReader consultarAluno01()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexão.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Aluno where cpfAluno = '" + cpf + "'", DAO_Conexão.con);
                resultado = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return resultado;
        }

        public bool excluirAluno()
        {
            bool exc = false;
            try
            {
                DAO_Conexão.con.Open();
                MySqlCommand exclui = new MySqlCommand("update Estudio_Aluno set Ativo = 1 where cpfAluno = '" + cpf + "'", DAO_Conexão.con);
                exclui.ExecuteNonQuery();
                exc = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexão.con.Close();
            }
            return exc;
        }

        public String getCpf()
        {
            return cpf;
        }

        public void setCpf(String cpf)
        {
            this.cpf = cpf;
        }

        public String getNome()
        {
            return nome;
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public String getRua()
        {
            return rua;
        }

        public void setRua(String rua)
        {
            this.rua = rua;
        }

        public String getNumero()
        {
            return numero;
        }

        public void setNumero(String numero)
        {
            this.numero = numero;
        }

        public String getBairro()
        {
            return bairro;
        }

        public void setBairro(String bairro)
        {
            this.bairro = bairro;
        }

        public String getComplemento()
        {
            return complemento;
        }

        public void setComplemento(String complemento)
        {
            this.complemento = complemento;
        }

        public String getCep()
        {
            return cep;
        }

        public void setCep(String cep)
        {
            this.cep = cep;
        }

        public String getCidade()
        {
            return cidade;
        }

        public void setCidade(String cidade)
        {
            this.cidade = cidade;
        }

        public String getEstado()
        {
            return estado;
        }

        public void setEstado(String estado)
        {
            this.estado = estado;
        }

        public String getTelefone()
        {
            return telefone;
        }

        public void setTelefone(String telefone)
        {
            this.telefone = telefone;
        }

        public String getEmail()
        {
            return email;
        }

        public void setEmail(String email)
        {
            this.email = email;
        }

        public byte[] getFoto()
        {
            return foto;
        }

        public void setFoto(byte[] foto)
        {
            this.foto = foto;
        }

        public bool isAtivo()
        {
            return ativo;
        }

        public void setAtivo(bool ativo)
        {
            this.ativo = ativo;
        }
        #endregion
    }
}