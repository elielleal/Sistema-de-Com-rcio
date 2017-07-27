using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NCliente
    {
        //metodo inserir
        public static string Inserir(string nome, string sobrenome, string sexo, DateTime data_nasc, string tipo_documento, string num_documento, string endereco, string telefone, string email)
        {

            DCliente Obj = new CamadaDados.DCliente();
            Obj.Nome = nome;
            Obj.Sobrenome = sobrenome;
            Obj.Sexo = sexo;
            Obj.DataNascimento = data_nasc;
            Obj.TipoDocumento = tipo_documento;
            Obj.NumDocumento = num_documento;
            Obj.Endereco = endereco;
            Obj.Telefone = telefone;
            Obj.Email = email;
           
            return Obj.Inserir(Obj);
        }

        //metodo editar
        public static string Editar(int id, string nome, string sobrenome, string sexo, DateTime data_nasc, string tipo_documento, string num_documento, string endereco, string telefone, string email)
        {

            DCliente Obj = new CamadaDados.DCliente();
            Obj.Id = id;
            Obj.Nome = nome;
            Obj.Sobrenome = sobrenome;
            Obj.Sexo = sexo;
            Obj.DataNascimento = data_nasc;
            Obj.TipoDocumento = tipo_documento;
            Obj.NumDocumento = num_documento;
            Obj.Endereco = endereco;
            Obj.Telefone = telefone;
            Obj.Email = email;
            return Obj.Editar(Obj);
        }

        //metodo excluir
        public static string Excluir(int id)
        {

            DCliente Obj = new CamadaDados.DCliente();
            Obj.Id = id;
            return Obj.Excluir(Obj);
        }

        //metodo mostrar
        public static DataTable Mostrar()

        {
            return new DCliente().Mostrar();
        }

        //metodo Buscar nome 
        public static DataTable BuscarNome(string textobuscar)
        {
            DCliente Obj = new DCliente();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNome(Obj);
        }

        //metodo Buscar Num documento
        public static DataTable BuscarDocumento(string textobuscar)
        {
            DCliente Obj = new DCliente();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarDocumento(Obj);
        }

    }
}
