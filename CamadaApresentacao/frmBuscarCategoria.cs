﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaNegocio;

namespace CamadaApresentacao
{
    public partial class frmBuscarCategoria : Form
    {
        public frmBuscarCategoria()
        {
            InitializeComponent();
        }

        //ocultar as colunas do grid view
        private void ocultarColunas()
        {
            this.dataLista.Columns[0].Visible = false;


        }

        //mostrar no data grid
        private void Mostrar()
        {
            this.dataLista.DataSource = NCategoria.Mostrar();
            this.ocultarColunas();
            lblTotal.Text = "Total de Registro: " + Convert.ToString(dataLista.Rows.Count);
        }

        //Buscar pelo Nome
        private void BuscarNome()
        {
            this.dataLista.DataSource = NCategoria.BuscarNome(this.txtBuscar.Text);
            this.ocultarColunas();
            lblTotal.Text = "Total de Registro: " + Convert.ToString(dataLista.Rows.Count);
        }


        private void frmBuscarCategoria_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNome();
        }

        private void dataLista_DoubleClick(object sender, EventArgs e)
        {
            frmProduto form = frmProduto.GetInstancia();
            string par1, par2;
            par1 = Convert.ToString(dataLista.CurrentRow.Cells["idcategoria"].Value);
            par2 = Convert.ToString(dataLista.CurrentRow.Cells["nome"].Value);
            form.setCategoria(par1, par2);
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
