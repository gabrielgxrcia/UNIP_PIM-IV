using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using Bunifu.UI.WinForms;

namespace Windows_Forms_DeskTop
{
    internal class Validate
    {
        public string NomeCompleto { get; private set; }
        public string CPF { get; private set; }
        public string RG { get; private set; }
        public string Email { get; private set; }
        public string DataNasc { get; private set; }
        public string Reservista { get; private set; }
        public string TituloEleitor { get; private set; }
        public string Celular { get; private set; }
        public string Sexo { get; private set; }
        public string EstadoCivil { get; private set; }
        public string DataAdmissao { get; private set; }
        public string Cargo { get; private set; }
        public string Funcao { get; private set; }
        public string SalarioBase { get; private set; }
        public string Banco { get; private set; }
        public string Agencia { get; private set; }
        public string CC { get; private set; }
        public string Endereco { get; private set; }
        public string Bairro { get; private set; }
        public string Numero { get; private set; }
        public string CEP { get; private set; }
        public string Complemento { get; private set; }
        public string Estado { get; private set; }
        public string Escolaridade { get; private set; }
        public string Filhos { get; private set; }
        public string PCD { get; private set; }
        public byte[] ImagemFuncionario { get; private set; }

        private string connectionString = "Data Source=Tagliacolli;Initial Catalog=DESKTOP;Integrated Security=True";

        public bool Validate_Login(string email, string password)
        {
            bool isValid = false;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Usuarios WHERE Email = @email AND Senha = @senha";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@senha", password);

                    try
                    {
                        conn.Open();
                        int count = (int)cmd.ExecuteScalar();
                        isValid = (count > 0);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erro na Pesquisa");
                        Console.WriteLine(ex.Message);
                        throw;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            return isValid;
        }

        public bool SearchFuncionario(string name)
        {
            var valid = false;

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("SELECT * FROM Funcionarios WHERE NomeCompleto = @nome", conn);

            try
            {
                conn.Open();
                command.Parameters.Add(new SqlParameter("@nome", name));
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    NomeCompleto = reader.GetString(1);
                    CPF = reader.GetString(4);
                    RG = reader.GetString(6);
                    Email = reader.GetString(9);
                    DataNasc = reader.GetDateTime(3).ToString();
                    Reservista = reader.GetString(8);
                    TituloEleitor = reader.GetString(7);
                    Celular = reader.GetString(10);
                    Sexo = reader.GetString(2);
                    EstadoCivil = reader.GetString(5);
                    DataAdmissao = reader.GetDateTime(21).ToString();
                    Cargo = reader.GetString(22);
                    Funcao = reader.GetString(23);
                    SalarioBase = reader.GetDecimal(24).ToString();
                    Banco = reader.GetString(25);
                    Agencia = reader.GetString(26);
                    CC = reader.GetString(27);
                    Endereco = reader.GetString(12);
                    Bairro = reader.GetString(13);
                    Numero = reader.GetString(14);
                    CEP = reader.GetString(15);
                    Complemento = reader.GetString(16);
                    Estado = reader.GetString(17);
                    Escolaridade = reader.GetString(18);
                    Filhos = reader.GetString(19);
                    PCD = reader.GetString(20);
                    if(!reader.IsDBNull(28))
                    {
                        ImagemFuncionario = (byte[])(reader[28]);
                    }
                    else
                    {
                        ImagemFuncionario = null;
                    }
                    valid = true;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro" + ex);
                throw;
            }
            finally
            {
                conn.Close();
            }
            return valid;
        }

        public bool UpdateDataInDatabase(string nomeCompleto, string cpf, string rg, string email, string dataNasc, string reservista, string tituloEleitor,
                               string celular, string sexo, string estadoCivil, string dataAdmissao, string cargo, string funcao, string salarioBase,
                               string banco, string agencia, string cc, string endereco, string bairro, string numero, string cep, string complemento,
                               string estado, string escolaridade, string filhos, string pcd)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Funcionarios SET NomeCompleto = @NomeCompleto, CPF = @CPF, RG = @RG, Email = @Email, DataNascimento = @DataNasc, " +
               "Reservista = @Reservista, TituloEleitor = @TituloEleitor, Celular = @Celular, Sexo = @Sexo, EstadoCivil = @EstadoCivil, " +
               "DataContratacao = @DataAdmissao, Cargo = @Cargo, Funcao = @Funcao, SalarioBase = @SalarioBase, Banco = @Banco, Agencia = @Agencia, " +
               "ContaCorrente = @CC, Endereco = @Endereco, Bairro = @Bairro, Numero = @Numero, CEP = @CEP, Complemento = @Complemento, Estado = @Estado, " +
               "Escolaridade = @Escolaridade, Filhos = @Filhos, PCD = @PCD WHERE NomeCompleto = @NomeCompleto";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NomeCompleto", nomeCompleto);
                    cmd.Parameters.AddWithValue("@CPF", cpf);
                    cmd.Parameters.AddWithValue("@RG", rg);
                    cmd.Parameters.AddWithValue("@Email", email);

                    DateTime dataNascimento;
                    if (DateTime.TryParseExact(dataNasc, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataNascimento))
                    {
                        cmd.Parameters.AddWithValue("@DataNasc", dataNascimento);
                    }
                    else
                    {
                        MessageBox.Show("Data de nascimento inválida.");
                        return false;
                    }

                    cmd.Parameters.AddWithValue("@Reservista", reservista);
                    cmd.Parameters.AddWithValue("@TituloEleitor", tituloEleitor);
                    cmd.Parameters.AddWithValue("@Celular", celular);
                    cmd.Parameters.AddWithValue("@Sexo", sexo);
                    cmd.Parameters.AddWithValue("@EstadoCivil", estadoCivil);

                    DateTime dataContratacao;
                    if (DateTime.TryParseExact(dataAdmissao, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataContratacao))
                    {
                        cmd.Parameters.AddWithValue("@DataAdmissao", dataContratacao);
                    }
                    else
                    {
                        MessageBox.Show("Data de admissão inválida.");
                        return false;
                    }
                    cmd.Parameters.AddWithValue("@Cargo", cargo);
                    cmd.Parameters.AddWithValue("@Funcao", funcao);

                    string salaryFormatted = salarioBase.Replace(",", ".");

                    decimal salario;
                    if (decimal.TryParse(salaryFormatted, NumberStyles.Number, CultureInfo.InvariantCulture, out salario))
                    {
                        cmd.Parameters.AddWithValue("@SalarioBase", salario); 
                    }
                    else
                    {
                        MessageBox.Show("Salário inválido.");
                        return false;
                    }

                    cmd.Parameters.AddWithValue("@Banco", banco);
                    cmd.Parameters.AddWithValue("@Agencia", agencia);
                    cmd.Parameters.AddWithValue("@CC", cc);
                    cmd.Parameters.AddWithValue("@Endereco", endereco);
                    cmd.Parameters.AddWithValue("@Bairro", bairro);
                    cmd.Parameters.AddWithValue("@Numero", numero);
                    cmd.Parameters.AddWithValue("@CEP", cep);
                    cmd.Parameters.AddWithValue("@Complemento", complemento);
                    cmd.Parameters.AddWithValue("@Estado", estado);
                    cmd.Parameters.AddWithValue("@Escolaridade", escolaridade);
                    cmd.Parameters.AddWithValue("@Filhos", filhos);
                    cmd.Parameters.AddWithValue("@PCD", pcd);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erro ao atualizar dados: " + ex.Message);
                        return false;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        public bool InsertDataInDatabase(string nomeCompleto, string cpf, string rg, string email, string dataNasc, string reservista, string tituloEleitor,
                               string celular, string sexo, string estadoCivil, string dataAdmissao, string cargo, string funcao, string salarioBase,
                               string banco, string agencia, string cc, string endereco, string bairro, string numero, string cep, string complemento,
                               string estado, string escolaridade, string filhos, string pcd)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Funcionarios (NomeCompleto,Sexo,DataNascimento,CPF,EstadoCivil,RG,TituloEleitor,Reservista,Email," +
                    "Celular,Endereco,Bairro,Numero,CEP,Complemento,Filhos,PCD,DataContratacao,Cargo,Funcao,SalarioBase,Banco,Agencia,ContaCorrente)" +
                    "VALUES (@NOME,@SEXO,@DATANASC,@CPF,@ESTADOCIVIL,@RG,@TITULOELEITOR,@RESERVISTA,@EMAIL,@CELULAR,@ENDERECO,@BAIRRO,@NUMERO,@CEP," +
                    "@COMPLEMENTO,@ESTADO,@ESCOLARIDADE,@FILHOS,@PCD,@DATACONTRATACAO,@CARGO,@FUNCAO,@SALARIOBASE,@BANCO,@AGENCIA,@CONTACORRENTE)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@NOME", nomeCompleto));
                    cmd.Parameters.Add(new SqlParameter("@SEXO", sexo));
                    cmd.Parameters.Add(new SqlParameter("@DATANASC", dataNasc));
                    cmd.Parameters.Add(new SqlParameter("@CPF", cpf));
                    cmd.Parameters.Add(new SqlParameter("@ESTADOCIVIL", estadoCivil));
                    cmd.Parameters.Add(new SqlParameter("@RG", rg));
                    cmd.Parameters.Add(new SqlParameter("@TITULOELEITOR", tituloEleitor));
                    cmd.Parameters.Add(new SqlParameter("@RESERVISTA", reservista));
                    cmd.Parameters.Add(new SqlParameter("@EMAIL", email));
                    cmd.Parameters.Add(new SqlParameter("@CELULAR", celular));
                    cmd.Parameters.Add(new SqlParameter("@ENDERECO", endereco));
                    cmd.Parameters.Add(new SqlParameter("@BAIRRO", bairro));
                    cmd.Parameters.Add(new SqlParameter("@NUMERO", numero));
                    cmd.Parameters.Add(new SqlParameter("@CEP", cep));
                    cmd.Parameters.Add(new SqlParameter("@COMPLEMENTO", complemento));
                    cmd.Parameters.Add(new SqlParameter("@ESTADO", estado));
                    cmd.Parameters.Add(new SqlParameter("ESCOLARIDADE", escolaridade));
                    cmd.Parameters.Add(new SqlParameter("@FILHOS", filhos));
                    cmd.Parameters.Add(new SqlParameter("@PCD", pcd));
                    cmd.Parameters.Add(new SqlParameter("@DATACONTRATACAO", dataAdmissao));
                    cmd.Parameters.Add(new SqlParameter("@CARGO", cargo));
                    cmd.Parameters.Add(new SqlParameter("@FUNCAO", funcao));
                    cmd.Parameters.Add(new SqlParameter("@SALARIOBASE", salarioBase));
                    cmd.Parameters.Add(new SqlParameter("@BANCO", banco));
                    cmd.Parameters.Add(new SqlParameter("@AGENCIA", agencia));
                    cmd.Parameters.Add(new SqlParameter("@CONTACORRENTE", cc));

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (SqlException Ex)
                    {
                        MessageBox.Show(Ex.Message);
                        return false;
                        throw;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        public bool SaveImageInDatabase(byte[] imagemBytes, string nomeCompleto)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Funcionarios SET ImagemFuncionario = @Imagem WHERE NomeCompleto = @NomeCompleto";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Imagem", imagemBytes);
                    cmd.Parameters.AddWithValue("@NomeCompleto", nomeCompleto);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erro ao salvar imagem" + ex.Message);
                        return false;
                    }
                }
            }
        }
    }
}