using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DCliente
    {
        private int _Id;
        private string _Nome;
        private string _Sobrenome;
        private string _Sexo;
        private DateTime _DataNascimento;
        private string _TipoDocumento;
        private string _NumDocumento;
        private string _Endereco;
        private string _Telefone;
        private string _Email;
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

        public string TipoDocumento
        {
            get
            {
                return _TipoDocumento;
            }

            set
            {
                _TipoDocumento = value;
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

        public DCliente()
        {

        }

        public DCliente(int id, string nome, string sobrenome, string sexo, DateTime data_nasc, string tipo_documento, string num_documento, string endereco, string telefone, string email)
        {
            this.Id = id;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Sexo = sexo;
            this.DataNascimento = data_nasc;
            this.TipoDocumento = tipo_documento;
            this.NumDocumento = num_documento;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Email = email;
        }


        //metodo inserir
        public string Inserir(DCliente Cliente)
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
                sqlCmd.CommandText = "spinserir_cliente";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId = new SqlParameter();
                parId.ParameterName = "@id";
                parId.SqlDbType = SqlDbType.Int;
                parId.Direction = ParameterDirection.Output;
                sqlCmd.Parameters.Add(parId);

                SqlParameter parNome = new SqlParameter();
                parNome.ParameterName = "@nome";
                parNome.SqlDbType = SqlDbType.VarChar;
                parNome.Size = 35;
                parNome.Value = Cliente.Nome;
                sqlCmd.Parameters.Add(parNome);

                SqlParameter parSobrenome = new SqlParameter();
                parSobrenome.ParameterName = "@sobrenome";
                parSobrenome.SqlDbType = SqlDbType.VarChar;
                parSobrenome.Size = 25;
                parSobrenome.Value = Cliente.Sobrenome;
                sqlCmd.Parameters.Add(parSobrenome);

                SqlParameter parSexo = new SqlParameter();
                parSexo.ParameterName = "@sexo";
                parSexo.SqlDbType = SqlDbType.VarChar;
                parSexo.Size = 1;
                parSexo.Value = Cliente.Sexo;
                sqlCmd.Parameters.Add(parSexo);

                SqlParameter parData = new SqlParameter();
                parData.ParameterName = "@data_nasc";
                parData.SqlDbType = SqlDbType.Date;
                parData.Value = Cliente.DataNascimento;
                sqlCmd.Parameters.Add(parData);

                SqlParameter parTipoDocumento = new SqlParameter();
                parTipoDocumento.ParameterName = "@tipo_documento";
                parTipoDocumento.SqlDbType = SqlDbType.VarChar;
                parTipoDocumento.Size = 20;
                parTipoDocumento.Value = Cliente.TipoDocumento;
                sqlCmd.Parameters.Add(parTipoDocumento);

                SqlParameter parNumDocumento = new SqlParameter();
                parNumDocumento.ParameterName = "@num_documento";
                parNumDocumento.SqlDbType = SqlDbType.VarChar;
                parNumDocumento.Size = 20;
                parNumDocumento.Value = Cliente.NumDocumento;
                sqlCmd.Parameters.Add(parNumDocumento);

                SqlParameter parEndereco = new SqlParameter();
                parEndereco.ParameterName = "@endereco";
                parEndereco.SqlDbType = SqlDbType.VarChar;
                parEndereco.Size = 40;
                parEndereco.Value = Cliente.Endereco;
                sqlCmd.Parameters.Add(parEndereco);

                SqlParameter parTelefone = new SqlParameter();
                parTelefone.ParameterName = "@telefone";
                parTelefone.SqlDbType = SqlDbType.VarChar;
                parTelefone.Size = 16;
                parTelefone.Value = Cliente.Telefone;
                sqlCmd.Parameters.Add(parTelefone);

                SqlParameter parEmail = new SqlParameter();
                parEmail.ParameterName = "@email";
                parEmail.SqlDbType = SqlDbType.VarChar;
                parEmail.Size = 50;
                parEmail.Value = Cliente.Email;
                sqlCmd.Parameters.Add(parEmail);


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
        public string Editar(DCliente Cliente)
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
                sqlCmd.CommandText = "speditar_cliente";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId = new SqlParameter();
                parId.ParameterName = "@id";
                parId.SqlDbType = SqlDbType.Int;
                parId.Value = Cliente.Id;
                sqlCmd.Parameters.Add(parId);

                SqlParameter parNome = new SqlParameter();
                parNome.ParameterName = "@nome";
                parNome.SqlDbType = SqlDbType.VarChar;
                parNome.Size = 35;
                parNome.Value = Cliente.Nome;
                sqlCmd.Parameters.Add(parNome);

                SqlParameter parSobrenome = new SqlParameter();
                parSobrenome.ParameterName = "@sobrenome";
                parSobrenome.SqlDbType = SqlDbType.VarChar;
                parSobrenome.Size = 25;
                parSobrenome.Value = Cliente.Sobrenome;
                sqlCmd.Parameters.Add(parSobrenome);

                SqlParameter parSexo = new SqlParameter();
                parSexo.ParameterName = "@sexo";
                parSexo.SqlDbType = SqlDbType.VarChar;
                parSexo.Size = 1;
                parSexo.Value = Cliente.Sexo;
                sqlCmd.Parameters.Add(parSexo);

                SqlParameter parData = new SqlParameter();
                parData.ParameterName = "@data_nasc";
                parData.SqlDbType = SqlDbType.Date;
                parData.Value = Cliente.DataNascimento;
                sqlCmd.Parameters.Add(parData);

                SqlParameter parTipoDocumento = new SqlParameter();
                parTipoDocumento.ParameterName = "@tipo_documento";
                parTipoDocumento.SqlDbType = SqlDbType.VarChar;
                parTipoDocumento.Size = 20;
                parTipoDocumento.Value = Cliente.TipoDocumento;
                sqlCmd.Parameters.Add(parTipoDocumento);

                SqlParameter parNumDocumento = new SqlParameter();
                parNumDocumento.ParameterName = "@num_documento";
                parNumDocumento.SqlDbType = SqlDbType.VarChar;
                parNumDocumento.Size = 20;
                parNumDocumento.Value = Cliente.NumDocumento;
                sqlCmd.Parameters.Add(parNumDocumento);

                SqlParameter parEndereco = new SqlParameter();
                parEndereco.ParameterName = "@endereco";
                parEndereco.SqlDbType = SqlDbType.VarChar;
                parEndereco.Size = 40;
                parEndereco.Value = Cliente.Endereco;
                sqlCmd.Parameters.Add(parEndereco);

                SqlParameter parTelefone = new SqlParameter();
                parTelefone.ParameterName = "@telefone";
                parTelefone.SqlDbType = SqlDbType.VarChar;
                parTelefone.Size = 16;
                parTelefone.Value = Cliente.Telefone;
                sqlCmd.Parameters.Add(parTelefone);

                SqlParameter parEmail = new SqlParameter();
                parEmail.ParameterName = "@email";
                parEmail.SqlDbType = SqlDbType.VarChar;
                parEmail.Size = 50;
                parEmail.Value = Cliente.Email;
                sqlCmd.Parameters.Add(parEmail);

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
        public string Excluir(DCliente Cliente)
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
                sqlCmd.CommandText = "spdeletar_cliente";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId = new SqlParameter();
                parId.ParameterName = "@id";
                parId.SqlDbType = SqlDbType.Int;
                parId.Value = Cliente.Id;
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
            DataTable DtResultado = new DataTable("cliente");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "spmostrar_cliente";
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
        public DataTable BuscarNome(DCliente Cliente)
        {
            DataTable DtResultado = new DataTable("cliente");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "spbuscar_cliente_nome";
                sqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter parTextoBuscar = new SqlParameter();
                parTextoBuscar.ParameterName = "@textobuscar";
                parTextoBuscar.SqlDbType = SqlDbType.VarChar;
                parTextoBuscar.Size = 150;
                parTextoBuscar.Value = Cliente.TextoBuscar;
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

        //metodo buscar  Documento
        public DataTable BuscarDocumento(DCliente Cliente)
        {
            DataTable DtResultado = new DataTable("cliente");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "spbuscar_cliente_documento";
                sqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter parTextoBuscar = new SqlParameter();
                parTextoBuscar.ParameterName = "@textobuscar";
                parTextoBuscar.SqlDbType = SqlDbType.VarChar;
                parTextoBuscar.Size = 150;
                parTextoBuscar.Value = Cliente.TextoBuscar;
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
