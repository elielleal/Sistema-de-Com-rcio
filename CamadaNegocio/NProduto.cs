using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CamadaDados;

namespace CamadaNegocio
{
    public class NProduto
    {
        //metodo inserir
        public static string Inserir(string codigo, string nome, string descricao, byte[] imagem, int idcategoria, int idapresentacao)
        {

            DProduto Obj = new CamadaDados.DProduto();
            Obj.Codigo = codigo;
            Obj.Nome = nome;
            Obj.Descricao = descricao;
            Obj.Imagem = imagem;
            Obj.IdCategoria = idcategoria;
            Obj.IdApresentacao = idapresentacao;
            return Obj.Inserir(Obj);
        }

        //metodo editar
        public static string Editar(int id, string codigo, string nome, string descricao, byte[] imagem, int idcategoria, int idapresentacao)
        {

            DProduto Obj = new CamadaDados.DProduto();
            Obj.Id = id;
            Obj.Codigo = codigo;
            Obj.Nome = nome;
            Obj.Descricao = descricao;
            Obj.Imagem = imagem;
            Obj.IdCategoria = idcategoria;
            Obj.IdApresentacao = idapresentacao;
            return Obj.Editar(Obj);
        }

        //metodo excluir
        public static string Excluir(int id)
        {

            DProduto Obj = new CamadaDados.DProduto();
            Obj.Id = id;
            return Obj.Excluir(Obj);
        }

        //metodo mostrar
        public static DataTable Mostrar()

        {
            return new DProduto().Mostrar();
        }

        //metodo Buscar Nome
        public static DataTable BuscarNome(string textobuscar)
        {
            DProduto Obj = new DProduto();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNome(Obj);
        }
    }
}
