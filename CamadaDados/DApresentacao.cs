using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DApresentacao
    {
        private int __Idapresentacao;
        private string _Nome;
        private string _Descricao;
        private string _TextoBuscar;

        

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

        public int Idapresentacao
        {
            get
            {
                return __Idapresentacao;
            }

            set
            {
                __Idapresentacao = value;
            }
        }

        // construto vazio

        public DApresentacao()
        {

        }

        //construtor com parametros
        public DApresentacao(int idapresentacao, string nome, string descricao, string textobuscar)
        {
            this.Idapresentacao = idapresentacao;
            this.Nome = nome;
            this.Descricao = descricao;
            this.TextoBuscar = textobuscar;
        }

        //metodo inserir
        public string Inserir(DApresentacao apresentacao)
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
                sqlCmd.CommandText = "spinserir_apresentacao";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdapresentacao = new SqlParameter();
                parIdapresentacao.ParameterName = "@idapresentacao";
                parIdapresentacao.SqlDbType = SqlDbType.Int;
                parIdapresentacao.Direction = ParameterDirection.Output;
                sqlCmd.Parameters.Add(parIdapresentacao);

                SqlParameter parNome = new SqlParameter();
                parNome.ParameterName = "@nome";
                parNome.SqlDbType = SqlDbType.VarChar;
                parNome.Size = 50;
                parNome.Value = apresentacao.Nome;
                sqlCmd.Parameters.Add(parNome);

                SqlParameter parDescricao = new SqlParameter();
                parDescricao.ParameterName = "@descricao";
                parDescricao.SqlDbType = SqlDbType.VarChar;
                parDescricao.Size = 100;
                parDescricao.Value = apresentacao.Descricao;
                sqlCmd.Parameters.Add(parDescricao);

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
        public string Editar(DApresentacao apresentacao)
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
                sqlCmd.CommandText = "speditar_apresentacao";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdapresentacao = new SqlParameter();
                parIdapresentacao.ParameterName = "@idapresentacao";
                parIdapresentacao.SqlDbType = SqlDbType.Int;
                parIdapresentacao.Value = apresentacao.Idapresentacao;
                sqlCmd.Parameters.Add(parIdapresentacao);

                SqlParameter parNome = new SqlParameter();
                parNome.ParameterName = "@nome";
                parNome.SqlDbType = SqlDbType.VarChar;
                parNome.Size = 50;
                parNome.Value = apresentacao.Nome;
                sqlCmd.Parameters.Add(parNome);

                SqlParameter parDescricao = new SqlParameter();
                parDescricao.ParameterName = "@descricao";
                parDescricao.SqlDbType = SqlDbType.VarChar;
                parDescricao.Size = 100;
                parDescricao.Value = apresentacao.Descricao;
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
        public string Excluir(DApresentacao apresentacao)
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
                sqlCmd.CommandText = "spdeletar_apresentacao";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdapresentacao = new SqlParameter();
                parIdapresentacao.ParameterName = "@idapresentacao";
                parIdapresentacao.SqlDbType = SqlDbType.Int;
                parIdapresentacao.Value = apresentacao.Idapresentacao;
                sqlCmd.Parameters.Add(parIdapresentacao);



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
            DataTable DtResultado = new DataTable("apresentacao");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "spmostrar_apresentacao";
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
        public DataTable BuscarNome(DApresentacao apresentacao)
        {
            DataTable DtResultado = new DataTable("apresentacao");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "spbuscar_apresentacao_nome";
                sqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter parTextoBuscar = new SqlParameter();
                parTextoBuscar.ParameterName = "@textobuscar";
                parTextoBuscar.SqlDbType = SqlDbType.VarChar;
                parTextoBuscar.Size = 50;
                parTextoBuscar.Value = apresentacao.TextoBuscar;
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
