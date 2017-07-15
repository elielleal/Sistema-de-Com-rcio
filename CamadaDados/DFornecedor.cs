using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DFornecedor
    {
        private int __Id;
        private string _Empresa;
        private string _Setor_Comercial;
        private string _Tipo_Documento;
        private string _Num_Documento;
        private string _Endereco;
        private string _Telefone;
        private string _Email;
        private string _Url;
        private string _TextoBuscar;

        public int Id
        {
            get
            {
                return __Id;
            }

            set
            {
                __Id = value;
            }
        }

        public string Empresa
        {
            get
            {
                return _Empresa;
            }

            set
            {
                _Empresa = value;
            }
        }

        public string Setor_Comercial
        {
            get
            {
                return _Setor_Comercial;
            }

            set
            {
                _Setor_Comercial = value;
            }
        }

        public string Tipo_Documento
        {
            get
            {
                return _Tipo_Documento;
            }

            set
            {
                _Tipo_Documento = value;
            }
        }

        public string Num_Documento
        {
            get
            {
                return _Num_Documento;
            }

            set
            {
                _Num_Documento = value;
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

        public string Url
        {
            get
            {
                return _Url;
            }

            set
            {
                _Url = value;
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

        public DFornecedor()
        {

        }

        public DFornecedor(int id, string empresa, string setor_comercial, string tipo_documento, string num_documento, string endereco, string telefone, string email, string url, string textobuscar)
        {
            this.Id = id;
            this.Empresa = empresa;
            this.Setor_Comercial = setor_comercial;
            this.Tipo_Documento = tipo_documento;
            this.Num_Documento = num_documento;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Email = email;
            this.Url = url;
            this.TextoBuscar = textobuscar;
        }

        //metodo inserir
        public string Inserir(DFornecedor Fornecedor)
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
                sqlCmd.CommandText = "spinserir_fornecedor";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId = new SqlParameter();
                parId.ParameterName = "@id";
                parId.SqlDbType = SqlDbType.Int;
                parId.Direction = ParameterDirection.Output;
                sqlCmd.Parameters.Add(parId);

                SqlParameter parEmpresa = new SqlParameter();
                parEmpresa.ParameterName = "@empresa";
                parEmpresa.SqlDbType = SqlDbType.VarChar;
                parEmpresa.Size = 150;
                parEmpresa.Value = Fornecedor.Empresa;
                sqlCmd.Parameters.Add(parEmpresa);

                SqlParameter parSetor_Comercial = new SqlParameter();
                parSetor_Comercial.ParameterName = "@setor_comercial";
                parSetor_Comercial.SqlDbType = SqlDbType.VarChar;
                parSetor_Comercial.Size = 50;
                parSetor_Comercial.Value = Fornecedor.Setor_Comercial;
                sqlCmd.Parameters.Add(parSetor_Comercial);

                SqlParameter parTipo_Documento = new SqlParameter();
                parTipo_Documento.ParameterName = "@tipo_documento";
                parTipo_Documento.SqlDbType = SqlDbType.VarChar;
                parTipo_Documento.Size = 50;
                parTipo_Documento.Value = Fornecedor.Tipo_Documento;
                sqlCmd.Parameters.Add(parTipo_Documento);

                SqlParameter parNum_Documento = new SqlParameter();
                parNum_Documento.ParameterName = "@num_documento";
                parNum_Documento.SqlDbType = SqlDbType.VarChar;
                parNum_Documento.Size = 11;
                parNum_Documento.Value = Fornecedor.Num_Documento;
                sqlCmd.Parameters.Add(parNum_Documento);

                SqlParameter parEndereco = new SqlParameter();
                parEndereco.ParameterName = "@endereco";
                parEndereco.SqlDbType = SqlDbType.VarChar;
                parEndereco.Size = 50;
                parEndereco.Value = Fornecedor.Endereco;
                sqlCmd.Parameters.Add(parEndereco);

                SqlParameter parTelefone = new SqlParameter();
                parTelefone.ParameterName = "@telefone";
                parTelefone.SqlDbType = SqlDbType.VarChar;
                parTelefone.Size = 50;
                parTelefone.Value = Fornecedor.Telefone;
                sqlCmd.Parameters.Add(parTelefone);

                SqlParameter parEmail = new SqlParameter();
                parEmail.ParameterName = "@email";
                parEmail.SqlDbType = SqlDbType.VarChar;
                parEmail.Size = 50;
                parEmail.Value = Fornecedor.Email;
                sqlCmd.Parameters.Add(parEmail);

                SqlParameter parUrl = new SqlParameter();
                parUrl.ParameterName = "@url";
                parUrl.SqlDbType = SqlDbType.VarChar;
                parUrl.Size = 100;
                parUrl.Value = Fornecedor.Url;
                sqlCmd.Parameters.Add(parUrl);

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
        public string Editar(DFornecedor Fornecedor)
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
                sqlCmd.CommandText = "speditar_fornecedor";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId = new SqlParameter();
                parId.ParameterName = "@id";
                parId.SqlDbType = SqlDbType.Int;
                parId.Value = Fornecedor.Id;
                sqlCmd.Parameters.Add(parId);

                SqlParameter parEmpresa = new SqlParameter();
                parEmpresa.ParameterName = "@empresa";
                parEmpresa.SqlDbType = SqlDbType.VarChar;
                parEmpresa.Size = 150;
                parEmpresa.Value = Fornecedor.Empresa;
                sqlCmd.Parameters.Add(parEmpresa);

                SqlParameter parSetor_Comercial = new SqlParameter();
                parSetor_Comercial.ParameterName = "@setor_comercial";
                parSetor_Comercial.SqlDbType = SqlDbType.VarChar;
                parSetor_Comercial.Size = 50;
                parSetor_Comercial.Value = Fornecedor.Setor_Comercial;
                sqlCmd.Parameters.Add(parSetor_Comercial);

                SqlParameter parTipo_Documento = new SqlParameter();
                parTipo_Documento.ParameterName = "@tipo_documento";
                parTipo_Documento.SqlDbType = SqlDbType.VarChar;
                parTipo_Documento.Size = 50;
                parTipo_Documento.Value = Fornecedor.Tipo_Documento;
                sqlCmd.Parameters.Add(parTipo_Documento);

                SqlParameter parNum_Documento = new SqlParameter();
                parNum_Documento.ParameterName = "@num_documento";
                parNum_Documento.SqlDbType = SqlDbType.VarChar;
                parNum_Documento.Size = 11;
                parNum_Documento.Value = Fornecedor.Num_Documento;
                sqlCmd.Parameters.Add(parNum_Documento);

                SqlParameter parEndereco = new SqlParameter();
                parEndereco.ParameterName = "@endereco";
                parEndereco.SqlDbType = SqlDbType.VarChar;
                parEndereco.Size = 50;
                parEndereco.Value = Fornecedor.Endereco;
                sqlCmd.Parameters.Add(parEndereco);

                SqlParameter parTelefone = new SqlParameter();
                parTelefone.ParameterName = "@telefone";
                parTelefone.SqlDbType = SqlDbType.VarChar;
                parTelefone.Size = 50;
                parTelefone.Value = Fornecedor.Telefone;
                sqlCmd.Parameters.Add(parTelefone);

                SqlParameter parEmail = new SqlParameter();
                parEmail.ParameterName = "@email";
                parEmail.SqlDbType = SqlDbType.VarChar;
                parEmail.Size = 50;
                parEmail.Value = Fornecedor.Email;
                sqlCmd.Parameters.Add(parEmail);

                SqlParameter parUrl = new SqlParameter();
                parUrl.ParameterName = "@url";
                parUrl.SqlDbType = SqlDbType.VarChar;
                parUrl.Size = 100;
                parUrl.Value = Fornecedor.Url;
                sqlCmd.Parameters.Add(parUrl);

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
        public string Excluir(DFornecedor Fornecedor)
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
                sqlCmd.CommandText = "spdeletar_fornecedor";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId = new SqlParameter();
                parId.ParameterName = "@id";
                parId.SqlDbType = SqlDbType.Int;
                parId.Value = Fornecedor.Id;
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
            DataTable DtResultado = new DataTable("fornecedor");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "spmostrar_fornecedor";
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

        //metodo buscar Empresa
        public DataTable BuscarNome(DFornecedor Fornecedor)
        {
            DataTable DtResultado = new DataTable("fornecedor");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "spbuscar_fornecedor_empresa";
                sqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter parTextoBuscar = new SqlParameter();
                parTextoBuscar.ParameterName = "@textobuscar";
                parTextoBuscar.SqlDbType = SqlDbType.VarChar;
                parTextoBuscar.Size = 150;
                parTextoBuscar.Value = Fornecedor.TextoBuscar;
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

        //metodo buscar Documento
        public DataTable BuscarDocumento(DFornecedor Fornecedor)
        {
            DataTable DtResultado = new DataTable("fornecedor");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "spbuscar_fornecedor_documento";
                sqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter parTextoBuscar = new SqlParameter();
                parTextoBuscar.ParameterName = "@textobuscar";
                parTextoBuscar.SqlDbType = SqlDbType.VarChar;
                parTextoBuscar.Size = 150;
                parTextoBuscar.Value = Fornecedor.TextoBuscar;
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
