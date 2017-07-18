using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DFuncionario
    {
        private int _Id;
        private string _Nome;
        private string _Sobrenome;
        private string _Sexo;
        private DateTime _DataNascimento;
        private string _NumDocumento;
        private string _Endereco;
        private string _Telefone;
        private string _Email;
        private string _Acesso;
        private string _Usuario;
        private string _Senha;
        private string _TextoBuscar;

        public int Id
        {
            get
            {
                return _Id;
            }

            set
            {
                _Id = value;
            }
        }

        public string Nome
        {
            get
            {
                return _Nome;
            }

            set
            {
                _Nome = value;
            }
        }

        public string Sobrenome
        {
            get
            {
                return _Sobrenome;
            }

            set
            {
                _Sobrenome = value;
            }
        }

        public string Sexo
        {
            get
            {
                return _Sexo;
            }

            set
            {
                _Sexo = value;
            }
        }

        public DateTime DataNascimento
        {
            get
            {
                return _DataNascimento;
            }

            set
            {
                _DataNascimento = value;
            }
        }

        public string NumDocumento
        {
            get
            {
                return _NumDocumento;
            }

            set
            {
                _NumDocumento = value;
            }
        }

        public string Endereco
        {
            get
            {
                return _Endereco;
            }

            set
            {
                _Endereco = value;
            }
        }

        public string Telefone
        {
            get
            {
                return _Telefone;
            }

            set
            {
                _Telefone = value;
            }
        }

        public string Email
        {
            get
            {
                return _Email;
            }

            set
            {
                _Email = value;
            }
        }

        public string Acesso
        {
            get
            {
                return _Acesso;
            }

            set
            {
                _Acesso = value;
            }
        }

        public string Usuario
        {
            get
            {
                return _Usuario;
            }

            set
            {
                _Usuario = value;
            }
        }

        public string Senha
        {
            get
            {
                return _Senha;
            }

            set
            {
                _Senha = value;
            }
        }

        public string TextoBuscar
        {
            get
            {
                return _TextoBuscar;
            }

            set
            {
                _TextoBuscar = value;
            }
        }

        public DFuncionario()
        {

        }

        public DFuncionario(int id, string nome, string sobrenome, string sexo, DateTime data_nasc, string num_documento, string endereco, string telefone, string email, string acesso, string usuario, string senha)
        {
            this.Id = id;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Sexo = sexo;
            this.DataNascimento = data_nasc;
            this.NumDocumento = num_documento;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Email = email;
            this.Acesso = acesso;
            this.Usuario = usuario;
            this.Senha = senha;
        }

        //metodo inserir
        public string Inserir(DFuncionario Funcionario)
        {
            string resp = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                //codigo
                sqlCon.ConnectionString = Conexao.Cn;
                sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "spinserir_funcionario";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId = new SqlParameter();
                parId.ParameterName = "@id";
                parId.SqlDbType = SqlDbType.Int;
                parId.Direction = ParameterDirection.Output;
                sqlCmd.Parameters.Add(parId);

                SqlParameter parNome = new SqlParameter();
                parNome.ParameterName = "@nome";
                parNome.SqlDbType = SqlDbType.VarChar;
                parNome.Size = 50;
                parNome.Value = Funcionario.Nome;
                sqlCmd.Parameters.Add(parNome);

                SqlParameter parSobrenome = new SqlParameter();
                parSobrenome.ParameterName = "@sobrenome";
                parSobrenome.SqlDbType = SqlDbType.VarChar;
                parSobrenome.Size = 50;
                parSobrenome.Value = Funcionario.Sobrenome;
                sqlCmd.Parameters.Add(parSobrenome);

                SqlParameter parSexo = new SqlParameter();
                parSexo.ParameterName = "@sexo";
                parSexo.SqlDbType = SqlDbType.VarChar;
                parSexo.Size = 1;
                parSexo.Value = Funcionario.Sexo;
                sqlCmd.Parameters.Add(parSexo);

                SqlParameter parData = new SqlParameter();
                parData.ParameterName = "@data_nasc";
                parData.SqlDbType = SqlDbType.Date;
                parData.Value = Funcionario.DataNascimento;
                sqlCmd.Parameters.Add(parData);

                SqlParameter parNumDocumento = new SqlParameter();
                parNumDocumento.ParameterName = "@num_documento";
                parNumDocumento.SqlDbType = SqlDbType.VarChar;
                parNumDocumento.Size = 9;
                parNumDocumento.Value = Funcionario.NumDocumento;
                sqlCmd.Parameters.Add(parNumDocumento);

                SqlParameter parEndereco = new SqlParameter();
                parEndereco.ParameterName = "@endereco";
                parEndereco.SqlDbType = SqlDbType.VarChar;
                parEndereco.Size = 150;
                parEndereco.Value = Funcionario.Endereco;
                sqlCmd.Parameters.Add(parEndereco);

                SqlParameter parTelefone = new SqlParameter();
                parTelefone.ParameterName = "@telefone";
                parTelefone.SqlDbType = SqlDbType.VarChar;
                parTelefone.Size = 14;
                parTelefone.Value = Funcionario.Telefone;
                sqlCmd.Parameters.Add(parTelefone);

                SqlParameter parEmail = new SqlParameter();
                parEmail.ParameterName = "@email";
                parEmail.SqlDbType = SqlDbType.VarChar;
                parEmail.Size = 50;
                parEmail.Value = Funcionario.Email;
                sqlCmd.Parameters.Add(parEmail);

                SqlParameter parAcesso = new SqlParameter();
                parAcesso.ParameterName = "@acesso";
                parAcesso.SqlDbType = SqlDbType.VarChar;
                parAcesso.Size = 20;
                parAcesso.Value = Funcionario.Acesso;
                sqlCmd.Parameters.Add(parAcesso);

                SqlParameter parUsuario = new SqlParameter();
                parUsuario.ParameterName = "@usuario";
                parUsuario.SqlDbType = SqlDbType.VarChar;
                parUsuario.Size = 20;
                parUsuario.Value = Funcionario.Usuario;
                sqlCmd.Parameters.Add(parUsuario);

                SqlParameter parSenha = new SqlParameter();
                parSenha.ParameterName = "@senha";
                parSenha.SqlDbType = SqlDbType.VarChar;
                parSenha.Size = 20;
                parSenha.Value = Funcionario.Senha;
                sqlCmd.Parameters.Add(parSenha);

                //executar o comando
                resp = sqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Registro não foi Inserido";
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return resp;
        }

        //metodo editar
        public string Editar(DFuncionario Funcionario)
        {
            string resp = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                //codigo
                sqlCon.ConnectionString = Conexao.Cn;
                sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "speditar_funcionario";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId = new SqlParameter();
                parId.ParameterName = "@id";
                parId.SqlDbType = SqlDbType.Int;
                parId.Value = Funcionario.Id;
                sqlCmd.Parameters.Add(parId);

                SqlParameter parNome = new SqlParameter();
                parNome.ParameterName = "@nome";
                parNome.SqlDbType = SqlDbType.VarChar;
                parNome.Size = 50;
                parNome.Value = Funcionario.Nome;
                sqlCmd.Parameters.Add(parNome);

                SqlParameter parSobrenome = new SqlParameter();
                parSobrenome.ParameterName = "@sobrenome";
                parSobrenome.SqlDbType = SqlDbType.VarChar;
                parSobrenome.Size = 50;
                parSobrenome.Value = Funcionario.Sobrenome;
                sqlCmd.Parameters.Add(parSobrenome);

                SqlParameter parSexo = new SqlParameter();
                parSexo.ParameterName = "@sexo";
                parSexo.SqlDbType = SqlDbType.VarChar;
                parSexo.Size = 1;
                parSexo.Value = Funcionario.Sexo;
                sqlCmd.Parameters.Add(parSexo);

                SqlParameter parData = new SqlParameter();
                parData.ParameterName = "@data_nasc";
                parData.SqlDbType = SqlDbType.Date;
                parData.Value = Funcionario.DataNascimento;
                sqlCmd.Parameters.Add(parData);

                SqlParameter parNumDocumento = new SqlParameter();
                parNumDocumento.ParameterName = "@num_documento";
                parNumDocumento.SqlDbType = SqlDbType.VarChar;
                parNumDocumento.Size = 20;
                parNumDocumento.Value = Funcionario.NumDocumento;
                sqlCmd.Parameters.Add(parNumDocumento);

                SqlParameter parEndereco = new SqlParameter();
                parEndereco.ParameterName = "@endereco";
                parEndereco.SqlDbType = SqlDbType.VarChar;
                parEndereco.Size = 150;
                parEndereco.Value = Funcionario.Endereco;
                sqlCmd.Parameters.Add(parEndereco);

                SqlParameter parTelefone = new SqlParameter();
                parTelefone.ParameterName = "@telefone";
                parTelefone.SqlDbType = SqlDbType.VarChar;
                parTelefone.Size = 15;
                parTelefone.Value = Funcionario.Telefone;
                sqlCmd.Parameters.Add(parTelefone);

                SqlParameter parEmail = new SqlParameter();
                parEmail.ParameterName = "@email";
                parEmail.SqlDbType = SqlDbType.VarChar;
                parEmail.Size = 50;
                parEmail.Value = Funcionario.Email;
                sqlCmd.Parameters.Add(parEmail);

                SqlParameter parAcesso = new SqlParameter();
                parAcesso.ParameterName = "@acesso";
                parAcesso.SqlDbType = SqlDbType.VarChar;
                parAcesso.Size = 20;
                parAcesso.Value = Funcionario.Acesso;
                sqlCmd.Parameters.Add(parAcesso);

                SqlParameter parUsuario = new SqlParameter();
                parUsuario.ParameterName = "@usuario";
                parUsuario.SqlDbType = SqlDbType.VarChar;
                parUsuario.Size = 20;
                parUsuario.Value = Funcionario.Usuario;
                sqlCmd.Parameters.Add(parUsuario);

                SqlParameter parSenha = new SqlParameter();
                parSenha.ParameterName = "@senha";
                parSenha.SqlDbType = SqlDbType.VarChar;
                parSenha.Size = 20;
                parSenha.Value = Funcionario.Senha;
                sqlCmd.Parameters.Add(parSenha);

                //executar o comando
                resp = sqlCmd.ExecuteNonQuery() == 1 ? "OK" : "A edição não foi Feita";
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return resp;
        }

        //metodo excluir
        public string Excluir(DFuncionario Funcionario)
        {
            string resp = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                //codigo
                sqlCon.ConnectionString = Conexao.Cn;
                sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "spdeletar_funcionario";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId = new SqlParameter();
                parId.ParameterName = "@id";
                parId.SqlDbType = SqlDbType.Int;
                parId.Value = Funcionario.Id;
                sqlCmd.Parameters.Add(parId);



                //executar o comando
                resp = sqlCmd.ExecuteNonQuery() == 1 ? "OK" : "A exclusão não foi Feita";
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return resp;
        }

        //metodo Mostrar
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("funcionario");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "spmostrar_funcionario";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                sqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        //metodo buscar Nome
        public DataTable BuscarNome(DFuncionario Funcionario)
        {
            DataTable DtResultado = new DataTable("funcionario");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "spbuscar_funcionario_nome";
                sqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter parTextoBuscar = new SqlParameter();
                parTextoBuscar.ParameterName = "@textobuscar";
                parTextoBuscar.SqlDbType = SqlDbType.VarChar;
                parTextoBuscar.Size = 150;
                parTextoBuscar.Value = Funcionario.TextoBuscar;
                sqlCmd.Parameters.Add(parTextoBuscar);

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                sqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }

            return DtResultado;
        }

        //metodo Login
        public DataTable Login(DFuncionario Funcionario)
        {
            DataTable DtResultado = new DataTable("funcionario");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "splogin";
                sqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter parUsuario = new SqlParameter();
                parUsuario.ParameterName = "@usuario";
                parUsuario.SqlDbType = SqlDbType.VarChar;
                parUsuario.Size = 20;
                parUsuario.Value = Funcionario.Usuario;
                sqlCmd.Parameters.Add(parUsuario);

                SqlParameter parSenha = new SqlParameter();
                parSenha.ParameterName = "@senha";
                parSenha.SqlDbType = SqlDbType.VarChar;
                parSenha.Size = 20;
                parSenha.Value = Funcionario.Senha;
                sqlCmd.Parameters.Add(parSenha);

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                sqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }

            return DtResultado;
        }


        //metodo buscar Funcionario Documento
        public DataTable BuscarDocumento(DFuncionario Funcionario)
        {
            DataTable DtResultado = new DataTable("funcionario");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "spbuscar_funcionario_documento";
                sqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter parTextoBuscar = new SqlParameter();
                parTextoBuscar.ParameterName = "@textobuscar";
                parTextoBuscar.SqlDbType = SqlDbType.VarChar;
                parTextoBuscar.Size = 150;
                parTextoBuscar.Value = Funcionario.TextoBuscar;
                sqlCmd.Parameters.Add(parTextoBuscar);

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                sqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }

            return DtResultado;
        }
    }
}
