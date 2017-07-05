using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DCategoria
    {
        private int __Idcategoria;
        private string _Nome;
        private string _Descricao;
        private string _TextoBuscar;

        public int Idcategoria
        {
            get
            {
                return __Idcategoria;
            }

            set
            {
                __Idcategoria = value;
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

        public string Descricao
        {
            get
            {
                return _Descricao;
            }

            set
            {
                _Descricao = value;
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

        // construto vazio

        public DCategoria()
        {

        }

        //construtor com parametros
        public DCategoria(int idcategoria, string nome, string descricao, string textobuscar)
        {
            this.Idcategoria = idcategoria;
            this.Nome = nome;
            this.Descricao = descricao;
            this.TextoBuscar = textobuscar;
        }

        //metodo inserir
        public string Inserir(DCategoria categoria)
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
                sqlCmd.CommandText = "spinserir_categoria";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdcategoria = new SqlParameter();
                parIdcategoria.ParameterName = "@idcategoria";
                parIdcategoria.SqlDbType=SqlDbType.Int;
                parIdcategoria.Direction = ParameterDirection.Output;
                sqlCmd.Parameters.Add(parIdcategoria);

                SqlParameter parNome = new SqlParameter();
                parNome.ParameterName = "@nome";
                parNome.SqlDbType = SqlDbType.VarChar;
                parNome.Size = 50;
                parNome.Value = categoria.Nome;
                sqlCmd.Parameters.Add(parNome);

                SqlParameter parDescricao = new SqlParameter();
                parDescricao.ParameterName = "@descricao";
                parDescricao.SqlDbType = SqlDbType.VarChar;
                parDescricao.Size = 256;
                parDescricao.Value = categoria.Descricao;
                sqlCmd.Parameters.Add(parDescricao);

                //executar o comando
                resp = sqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Registro não foi Inserido";
            }
            catch(Exception ex)
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
        public string Editar(DCategoria categoria)
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
                sqlCmd.CommandText = "speditar_categoria";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdcategoria = new SqlParameter();
                parIdcategoria.ParameterName = "@idcategoria";
                parIdcategoria.SqlDbType = SqlDbType.Int;
                parIdcategoria.Value = categoria.Idcategoria;
                sqlCmd.Parameters.Add(parIdcategoria);

                SqlParameter parNome = new SqlParameter();
                parNome.ParameterName = "@nome";
                parNome.SqlDbType = SqlDbType.VarChar;
                parNome.Size = 50;
                parNome.Value = categoria.Nome;
                sqlCmd.Parameters.Add(parNome);

                SqlParameter parDescricao = new SqlParameter();
                parDescricao.ParameterName = "@descricao";
                parDescricao.SqlDbType = SqlDbType.VarChar;
                parDescricao.Size = 256;
                parDescricao.Value = categoria.Descricao;
                sqlCmd.Parameters.Add(parDescricao);

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
        public string Excluir(DCategoria categoria)
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
                sqlCmd.CommandText = "spdeletar_categoria";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdcategoria = new SqlParameter();
                parIdcategoria.ParameterName = "@idcategoria";
                parIdcategoria.SqlDbType = SqlDbType.Int;
                parIdcategoria.Value = categoria.Idcategoria;
                sqlCmd.Parameters.Add(parIdcategoria);

               

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
            DataTable DtResultado = new DataTable("categoria");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "spmostrar_categoria";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                sqlDat.Fill(DtResultado);
            }
            catch(Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        //metodo buscar Nome
        public DataTable BuscarNome(DCategoria categoria)
        {
            DataTable DtResultado = new DataTable("Categoria");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "spbuscar_nome";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                

                SqlParameter parTextoBuscar = new SqlParameter();
                parTextoBuscar.ParameterName = "@textobuscar";
                parTextoBuscar.SqlDbType = SqlDbType.VarChar;
                parTextoBuscar.Size = 50;
                parTextoBuscar.Value = categoria.TextoBuscar;
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
