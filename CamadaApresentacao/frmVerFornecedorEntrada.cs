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
    public partial class frmVerFornecedorEntrada : Form
    {
        public frmVerFornecedorEntrada()
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
            this.dataLista.DataSource = NFornecedor.Mostrar();
            this.ocultarColunas();
            lblTotal.Text = "Total de Registro: " + Convert.ToString(dataLista.Rows.Count);
        }

        //Buscar pelo Nome empresa
        private void BuscarNome()
        {
            this.dataLista.DataSource = NFornecedor.BuscarNome(this.txtBuscar.Text);
            this.ocultarColunas();
            lblTotal.Text = "Total de Registro: " + Convert.ToString(dataLista.Rows.Count);
        }

        //Buscar pelo Nome documento
        private void BuscarDocumento()
        {
            this.dataLista.DataSource = NFornecedor.BuscarDocumento(this.txtBuscar.Text);
            this.ocultarColunas();
            lblTotal.Text = "Total de Registro: " + Convert.ToString(dataLista.Rows.Count);
        }


        private void frmVerFornecedorEntrada_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cbBusca.Text.Equals("Empresa"))
            {
                this.BuscarNome();
            }
            else if (cbBusca.Text.Equals("Documento"))
            {
                this.BuscarDocumento();
            }
        }

        private void cbBusca_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtBuscar.Text = string.Empty;
        }

        private void dataLista_DoubleClick(object sender, EventArgs e)
        {
            frmEntrada form = frmEntrada.GetInstancia();
            string par1, par2;
            par1 = Convert.ToString(dataLista.CurrentRow.Cells["idfornecedor"].Value);
            par2 = Convert.ToString(dataLista.CurrentRow.Cells["empresa"].Value);
            form.setFornecedor(par1, par2);
            this.Hide();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
