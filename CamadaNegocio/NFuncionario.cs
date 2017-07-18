using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NFuncionario
    {
        //metodo inserir
        public static string Inserir(string nome, string sobrenome, string sexo, DateTime data_nasc, string num_documento, string endereco, string telefone, string email, string acesso, string usuario, string senha)
        {

            DFuncionario Obj = new CamadaDados.DFuncionario();
            Obj.Nome = nome;
            Obj.Sobrenome = sobrenome;
            Obj.Sexo = sexo;
            Obj.DataNascimento = data_nasc;
            Obj.NumDocumento = num_documento;
            Obj.Endereco = endereco;
            Obj.Telefone = telefone;
            Obj.Email = email;
            Obj.Acesso = acesso;
            Obj.Usuario = usuario;
            Obj.Senha = senha;
            return Obj.Inserir(Obj);
        }

        //metodo editar
        public static string Editar(int id, string nome, string sobrenome, string sexo, DateTime data_nasc, string num_documento, string endereco, string telefone, string email, string acesso, string usuario, string senha)
        {

            DFuncionario Obj = new CamadaDados.DFuncionario();
            Obj.Id = id;
            Obj.Nome = nome;
            Obj.Sobrenome = sobrenome;
            Obj.Sexo = sexo;
            Obj.DataNascimento = data_nasc;
            Obj.NumDocumento = num_documento;
            Obj.Endereco = endereco;
            Obj.Telefone = telefone;
            Obj.Email = email;
            Obj.Acesso = acesso;
            Obj.Usuario = usuario;
            Obj.Senha = senha;
            return Obj.Editar(Obj);
        }

        //metodo excluir
        public static string Excluir(int id)
        {

            DFuncionario Obj = new CamadaDados.DFuncionario();
            Obj.Id = id;
            return Obj.Excluir(Obj);
        }

        //metodo mostrar
        public static DataTable Mostrar()

        {
            return new DFuncionario().Mostrar();
        }

        //metodo Buscar nome empresa
        public static DataTable BuscarNome(string textobuscar)
        {
           DFuncionario Obj = new DFuncionario();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNome(Obj);
        }

        //metodo Buscar nome documento
        public static DataTable BuscarDocumento(string textobuscar)
        {
            DFuncionario Obj = new DFuncionario();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarDocumento(Obj);
        }

        //metodo Login
        public static DataTable Login(string usuario, string senha)
        {
            DFuncionario Obj = new DFuncionario();
            Obj.Usuario = usuario;
            Obj.Senha = senha;
            return Obj.Login(Obj);
        }
    }
}
