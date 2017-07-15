using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NFornecedor
    {
        //metodo inserir
        public static string Inserir(string empresa, string setor_comercial, string tipo_documento, string num_documento, string endereco, string telefone, string email, string url)
        {

            DFornecedor Obj = new CamadaDados.DFornecedor();
            Obj.Empresa = empresa;
            Obj.Setor_Comercial = setor_comercial;
            Obj.Tipo_Documento = tipo_documento;
            Obj.Num_Documento = num_documento;
            Obj.Endereco = endereco;
            Obj.Telefone = telefone;
            Obj.Email = email;
            Obj.Url = url;
            return Obj.Inserir(Obj);
        }

        //metodo editar
        public static string Editar(int id, string empresa, string setor_comercial, string tipo_documento, string num_documento, string endereco, string telefone, string email, string url)
        {

            DFornecedor Obj = new CamadaDados.DFornecedor();
            Obj.Id = id;
            Obj.Empresa = empresa;
            Obj.Setor_Comercial = setor_comercial;
            Obj.Tipo_Documento = tipo_documento;
            Obj.Num_Documento = num_documento;
            Obj.Endereco = endereco;
            Obj.Telefone = telefone;
            Obj.Email = email;
            Obj.Url = url;
            return Obj.Editar(Obj);
        }

        //metodo excluir
        public static string Excluir(int id)
        {

            DFornecedor Obj = new CamadaDados.DFornecedor();
            Obj.Id = id;
            return Obj.Excluir(Obj);
        }

        //metodo mostrar
        public static DataTable Mostrar()

        {
            return new DFornecedor().Mostrar();
        }

        //metodo Buscar nome empresa
        public static DataTable BuscarNome(string textobuscar)
        {
            DFornecedor Obj = new DFornecedor();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNome(Obj);
        }

        //metodo Buscar nome documento
        public static DataTable BuscarDocumento(string textobuscar)
        {
            DFornecedor Obj = new DFornecedor();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarDocumento(Obj);
        }
    }
}
