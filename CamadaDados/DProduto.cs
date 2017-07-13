using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DProduto
    {
        private int _Id;
        private string _Codigo;
        private string _Nome;
        private string _Descricao;
        private byte[] _Imagem;
        private int _IdCategoria;
        private int _IdApresentacao;
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

        public string Codigo
        {
            get
            {
                return _Codigo;
            }

            set
            {
                _Codigo = value;
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

        public byte[] Imagem
        {
            get
            {
                return _Imagem;
            }

            set
            {
                _Imagem = value;
            }
        }

        public int IdCategoria
        {
            get
            {
                return _IdCategoria;
            }

            set
            {
                _IdCategoria = value;
            }
        }

        public int IdApresentacao
        {
            get
            {
                return _IdApresentacao;
            }

            set
            {
                _IdApresentacao = value;
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

        public DProduto()
        {

        }

        public DProduto(int id, string codigo, string nome, string descricao, byte[] imagem, int idcateogria, int idapresentacao, string textobuscar)
        {
            this.Id = id;
            this.Codigo = codigo;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Imagem = imagem;
            this.IdCategoria = idcateogria;
            this.IdApresentacao = idapresentacao;
            this.TextoBuscar = textobuscar;

        }

        //metodo inserir
        public string Inserir(DProduto Produto)
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
                sqlCmd.CommandText = "spinserir_produto";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId = new SqlParameter();
                parId.ParameterName = "@id";
                parId.SqlDbType = SqlDbType.Int;
                parId.Direction = ParameterDirection.Output;
                sqlCmd.Parameters.Add(parId);

                SqlParameter parCodigo = new SqlParameter();
                parCodigo.ParameterName = "@codigo";
                parCodigo.SqlDbType = SqlDbType.VarChar;
                parCodigo.Size = 50;
                parCodigo.Value = Produto.Codigo;
                sqlCmd.Parameters.Add(parCodigo);

                SqlParameter parNome = new SqlParameter();
                parNome.ParameterName = "@nome";
                parNome.SqlDbType = SqlDbType.VarChar;
                parNome.Size = 50;
                parNome.Value = Produto.Nome;
                sqlCmd.Parameters.Add(parNome);

                SqlParameter parDescricao = new SqlParameter();
                parDescricao.ParameterName = "@descricao";
                parDescricao.SqlDbType = SqlDbType.VarChar;
                parDescricao.Size = 500;
                parDescricao.Value = Produto.Descricao;
                sqlCmd.Parameters.Add(parDescricao);

                SqlParameter parImagem = new SqlParameter();
                parImagem.ParameterName = "@imagem";
                parImagem.SqlDbType = SqlDbType.Image;
                parImagem.Value = Produto.Imagem;
                sqlCmd.Parameters.Add(parImagem);

                SqlParameter parIdCategoria = new SqlParameter();
                parIdCategoria.ParameterName = "@idcategoria";
                parIdCategoria.SqlDbType = SqlDbType.Int;
                parIdCategoria.Value = Produto.IdCategoria;
                sqlCmd.Parameters.Add(parIdCategoria);

                SqlParameter parIdApresentacao = new SqlParameter();
                parIdApresentacao.ParameterName = "@idapresentacao";
                parIdApresentacao.SqlDbType = SqlDbType.Int;
                parIdApresentacao.Value = Produto.IdApresentacao;
                sqlCmd.Parameters.Add(parIdApresentacao);

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
        public string Editar(DProduto Produto)
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
                sqlCmd.CommandText = "speditar_produto";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId = new SqlParameter();
                parId.ParameterName = "@id";
                parId.SqlDbType = SqlDbType.Int;
                parId.Value = Produto.Id;
                sqlCmd.Parameters.Add(parId);

                SqlParameter parCodigo = new SqlParameter();
                parCodigo.ParameterName = "@codigo";
                parCodigo.SqlDbType = SqlDbType.VarChar;
                parCodigo.Size = 50;
                parCodigo.Value = Produto.Codigo;
                sqlCmd.Parameters.Add(parCodigo);

                SqlParameter parNome = new SqlParameter();
                parNome.ParameterName = "@nome";
                parNome.SqlDbType = SqlDbType.VarChar;
                parNome.Size = 50;
                parNome.Value = Produto.Nome;
                sqlCmd.Parameters.Add(parNome);

                SqlParameter parDescricao = new SqlParameter();
                parDescricao.ParameterName = "@descricao";
                parDescricao.SqlDbType = SqlDbType.VarChar;
                parDescricao.Size = 500;
                parDescricao.Value = Produto.Descricao;
                sqlCmd.Parameters.Add(parDescricao);

                SqlParameter parImagem = new SqlParameter();
                parImagem.ParameterName = "@imagem";
                parImagem.SqlDbType = SqlDbType.Image;
                parImagem.Value = Produto.Imagem;
                sqlCmd.Parameters.Add(parImagem);

                SqlParameter parIdCategoria = new SqlParameter();
                parIdCategoria.ParameterName = "@idcategoria";
                parIdCategoria.SqlDbType = SqlDbType.Int;
                parIdCategoria.Value = Produto.IdCategoria;
                sqlCmd.Parameters.Add(parIdCategoria);

                SqlParameter parIdApresentacao = new SqlParameter();
                parIdApresentacao.ParameterName = "@idapresentacao";
                parIdApresentacao.SqlDbType = SqlDbType.Int;
                parIdApresentacao.Value = Produto.IdApresentacao;
                sqlCmd.Parameters.Add(parIdApresentacao);

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
        public string Excluir(DProduto Produto)
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
                sqlCmd.CommandText = "spdeletar_produto";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId = new SqlParameter();
                parId.ParameterName = "@id";
                parId.SqlDbType = SqlDbType.Int;
                parId.Value = Produto.Id;
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
            DataTable DtResultado = new DataTable("produto");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "spmostrar_produto";
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
        public DataTable BuscarNome(DProduto Produto)
        {
            DataTable DtResultado = new DataTable("produto");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "spbuscar_produto_nome";
                sqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter parTextoBuscar = new SqlParameter();
                parTextoBuscar.ParameterName = "@textobuscar";
                parTextoBuscar.SqlDbType = SqlDbType.VarChar;
                parTextoBuscar.Size = 50;
                parTextoBuscar.Value = Produto.TextoBuscar;
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
