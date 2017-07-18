namespace CamadaApresentacao
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apresentaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasPorDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasPorDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFerramentas = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConfiguracoes = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExibir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuJanelas = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TS = new System.Windows.Forms.ToolStrip();
            this.TSCompras = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSVendas = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lbNome = new System.Windows.Forms.Label();
            this.lbSobrenome = new System.Windows.Forms.Label();
            this.lbAcesso = new System.Windows.Forms.Label();
            this.pxAcesso = new System.Windows.Forms.PictureBox();
            this.pxUsuario = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            this.TS.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxAcesso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Tomato;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuProdutos,
            this.MenuVendas,
            this.MenuCompras,
            this.MenuConsultas,
            this.MenuFerramentas,
            this.MenuConfiguracoes,
            this.MenuExibir,
            this.MenuJanelas,
            this.MenuSistema});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.MenuJanelas;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1354, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // MenuProdutos
            // 
            this.MenuProdutos.BackColor = System.Drawing.Color.Tomato;
            this.MenuProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem1,
            this.categoriasToolStripMenuItem,
            this.apresentaçõesToolStripMenuItem});
            this.MenuProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuProdutos.Image = global::CamadaApresentacao.Properties.Resources._1481080190_deliverables;
            this.MenuProdutos.Name = "MenuProdutos";
            this.MenuProdutos.Size = new System.Drawing.Size(109, 24);
            this.MenuProdutos.Text = "Produtos";
            // 
            // produtosToolStripMenuItem1
            // 
            this.produtosToolStripMenuItem1.Name = "produtosToolStripMenuItem1";
            this.produtosToolStripMenuItem1.Size = new System.Drawing.Size(199, 24);
            this.produtosToolStripMenuItem1.Text = "Produtos";
            this.produtosToolStripMenuItem1.Click += new System.EventHandler(this.produtosToolStripMenuItem1_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // apresentaçõesToolStripMenuItem
            // 
            this.apresentaçõesToolStripMenuItem.Name = "apresentaçõesToolStripMenuItem";
            this.apresentaçõesToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.apresentaçõesToolStripMenuItem.Text = "Apresentações";
            this.apresentaçõesToolStripMenuItem.Click += new System.EventHandler(this.apresentaçõesToolStripMenuItem_Click);
            // 
            // MenuVendas
            // 
            this.MenuVendas.BackColor = System.Drawing.Color.Tomato;
            this.MenuVendas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem1,
            this.clientesToolStripMenuItem});
            this.MenuVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuVendas.Image = global::CamadaApresentacao.Properties.Resources._1481080265_shopping_cart;
            this.MenuVendas.Name = "MenuVendas";
            this.MenuVendas.Size = new System.Drawing.Size(98, 24);
            this.MenuVendas.Text = "Vendas";
            // 
            // vendasToolStripMenuItem1
            // 
            this.vendasToolStripMenuItem1.Name = "vendasToolStripMenuItem1";
            this.vendasToolStripMenuItem1.Size = new System.Drawing.Size(143, 24);
            this.vendasToolStripMenuItem1.Text = "Vendas";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // MenuCompras
            // 
            this.MenuCompras.BackColor = System.Drawing.Color.Tomato;
            this.MenuCompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaToolStripMenuItem,
            this.fornecedoresToolStripMenuItem});
            this.MenuCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuCompras.Image = global::CamadaApresentacao.Properties.Resources._1481080293_Money;
            this.MenuCompras.Name = "MenuCompras";
            this.MenuCompras.Size = new System.Drawing.Size(108, 24);
            this.MenuCompras.Text = "Compras";
            // 
            // entradaToolStripMenuItem
            // 
            this.entradaToolStripMenuItem.Name = "entradaToolStripMenuItem";
            this.entradaToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.entradaToolStripMenuItem.Text = "Entrada";
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // MenuConsultas
            // 
            this.MenuConsultas.BackColor = System.Drawing.Color.Tomato;
            this.MenuConsultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasPorDataToolStripMenuItem,
            this.comprasPorDataToolStripMenuItem,
            this.estoqueDeProdutosToolStripMenuItem});
            this.MenuConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuConsultas.Image = global::CamadaApresentacao.Properties.Resources._1481080316_system_search;
            this.MenuConsultas.Name = "MenuConsultas";
            this.MenuConsultas.Size = new System.Drawing.Size(117, 24);
            this.MenuConsultas.Text = "Consultas";
            // 
            // vendasPorDataToolStripMenuItem
            // 
            this.vendasPorDataToolStripMenuItem.Name = "vendasPorDataToolStripMenuItem";
            this.vendasPorDataToolStripMenuItem.Size = new System.Drawing.Size(247, 24);
            this.vendasPorDataToolStripMenuItem.Text = "Vendas por Data";
            // 
            // comprasPorDataToolStripMenuItem
            // 
            this.comprasPorDataToolStripMenuItem.Name = "comprasPorDataToolStripMenuItem";
            this.comprasPorDataToolStripMenuItem.Size = new System.Drawing.Size(247, 24);
            this.comprasPorDataToolStripMenuItem.Text = "Compras por Data";
            // 
            // estoqueDeProdutosToolStripMenuItem
            // 
            this.estoqueDeProdutosToolStripMenuItem.Name = "estoqueDeProdutosToolStripMenuItem";
            this.estoqueDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(247, 24);
            this.estoqueDeProdutosToolStripMenuItem.Text = "Estoque de Produtos";
            // 
            // MenuFerramentas
            // 
            this.MenuFerramentas.BackColor = System.Drawing.Color.Tomato;
            this.MenuFerramentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.MenuFerramentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuFerramentas.Image = global::CamadaApresentacao.Properties.Resources.tool_edit_icon1;
            this.MenuFerramentas.Name = "MenuFerramentas";
            this.MenuFerramentas.Size = new System.Drawing.Size(139, 24);
            this.MenuFerramentas.Text = "&Ferramentas";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.optionsToolStripMenuItem.Text = "&BD";
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.bToolStripMenuItem.Text = "Backup";
            // 
            // MenuConfiguracoes
            // 
            this.MenuConfiguracoes.BackColor = System.Drawing.Color.Tomato;
            this.MenuConfiguracoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionáriosToolStripMenuItem});
            this.MenuConfiguracoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuConfiguracoes.Image = global::CamadaApresentacao.Properties.Resources.Categories_preferences_system_icon;
            this.MenuConfiguracoes.Name = "MenuConfiguracoes";
            this.MenuConfiguracoes.Size = new System.Drawing.Size(153, 24);
            this.MenuConfiguracoes.Text = "Configurações";
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            // 
            // MenuExibir
            // 
            this.MenuExibir.BackColor = System.Drawing.Color.Tomato;
            this.MenuExibir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBarToolStripMenuItem,
            this.statusBarToolStripMenuItem});
            this.MenuExibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuExibir.Image = global::CamadaApresentacao.Properties.Resources.CinemaDisplay_icon;
            this.MenuExibir.Name = "MenuExibir";
            this.MenuExibir.Size = new System.Drawing.Size(81, 24);
            this.MenuExibir.Text = "&Exibir";
            // 
            // toolBarToolStripMenuItem
            // 
            this.toolBarToolStripMenuItem.Checked = true;
            this.toolBarToolStripMenuItem.CheckOnClick = true;
            this.toolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
            this.toolBarToolStripMenuItem.Size = new System.Drawing.Size(254, 24);
            this.toolBarToolStripMenuItem.Text = "&Barra de Ferramentas";
            this.toolBarToolStripMenuItem.Click += new System.EventHandler(this.ToolBarToolStripMenuItem_Click);
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckOnClick = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(254, 24);
            this.statusBarToolStripMenuItem.Text = "Barra de Status";
            this.statusBarToolStripMenuItem.Click += new System.EventHandler(this.StatusBarToolStripMenuItem_Click);
            // 
            // MenuJanelas
            // 
            this.MenuJanelas.BackColor = System.Drawing.Color.Tomato;
            this.MenuJanelas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem,
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem});
            this.MenuJanelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuJanelas.Image = global::CamadaApresentacao.Properties.Resources.Windows_Media_Center_icon1;
            this.MenuJanelas.Name = "MenuJanelas";
            this.MenuJanelas.Size = new System.Drawing.Size(99, 24);
            this.MenuJanelas.Text = "&Janelas";
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(215, 24);
            this.newWindowToolStripMenuItem.Text = "Nova Janela";
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(215, 24);
            this.cascadeToolStripMenuItem.Text = "Cascata";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(215, 24);
            this.tileVerticalToolStripMenuItem.Text = "Empilhar Vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(215, 24);
            this.tileHorizontalToolStripMenuItem.Text = "Tile &Horizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(215, 24);
            this.closeAllToolStripMenuItem.Text = "F&echar Todos";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(215, 24);
            this.arrangeIconsToolStripMenuItem.Text = "&Organizar Ícones";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
            // 
            // MenuSistema
            // 
            this.MenuSistema.BackColor = System.Drawing.Color.Tomato;
            this.MenuSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.MenuSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuSistema.Image = global::CamadaApresentacao.Properties.Resources.File_System_icon1;
            this.MenuSistema.Name = "MenuSistema";
            this.MenuSistema.Size = new System.Drawing.Size(102, 24);
            this.MenuSistema.Text = "Sistema";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::CamadaApresentacao.Properties.Resources.Alarm_Error_icon3;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // TS
            // 
            this.TS.BackColor = System.Drawing.Color.Tomato;
            this.TS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSCompras,
            this.toolStripSeparator1,
            this.TSVendas});
            this.TS.Location = new System.Drawing.Point(0, 28);
            this.TS.Name = "TS";
            this.TS.Size = new System.Drawing.Size(1354, 25);
            this.TS.TabIndex = 1;
            this.TS.Text = "ToolStrip";
            // 
            // TSCompras
            // 
            this.TSCompras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSCompras.Image = global::CamadaApresentacao.Properties.Resources._1481080293_Money;
            this.TSCompras.ImageTransparentColor = System.Drawing.Color.Black;
            this.TSCompras.Name = "TSCompras";
            this.TSCompras.Size = new System.Drawing.Size(23, 22);
            this.TSCompras.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // TSVendas
            // 
            this.TSVendas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSVendas.Image = global::CamadaApresentacao.Properties.Resources._1481080265_shopping_cart;
            this.TSVendas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSVendas.Name = "TSVendas";
            this.TSVendas.Size = new System.Drawing.Size(23, 22);
            this.TSVendas.Text = "toolStripButton1";
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Snow;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 536);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(1354, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "Sistema de Gerenciamento de Comércio";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.BackColor = System.Drawing.Color.Snow;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.BackColor = System.Drawing.Color.Tomato;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(1147, 35);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 12);
            this.lbNome.TabIndex = 12;
            this.lbNome.Text = "label1";
            // 
            // lbSobrenome
            // 
            this.lbSobrenome.AutoSize = true;
            this.lbSobrenome.BackColor = System.Drawing.Color.Tomato;
            this.lbSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSobrenome.Location = new System.Drawing.Point(1188, 35);
            this.lbSobrenome.Name = "lbSobrenome";
            this.lbSobrenome.Size = new System.Drawing.Size(35, 12);
            this.lbSobrenome.TabIndex = 13;
            this.lbSobrenome.Text = "label1";
            // 
            // lbAcesso
            // 
            this.lbAcesso.AutoSize = true;
            this.lbAcesso.BackColor = System.Drawing.Color.Tomato;
            this.lbAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAcesso.Location = new System.Drawing.Point(1279, 35);
            this.lbAcesso.Name = "lbAcesso";
            this.lbAcesso.Size = new System.Drawing.Size(35, 12);
            this.lbAcesso.TabIndex = 14;
            this.lbAcesso.Text = "label1";
            // 
            // pxAcesso
            // 
            this.pxAcesso.BackColor = System.Drawing.Color.Tomato;
            this.pxAcesso.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Keys_icon2;
            this.pxAcesso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pxAcesso.Location = new System.Drawing.Point(1250, 28);
            this.pxAcesso.Name = "pxAcesso";
            this.pxAcesso.Size = new System.Drawing.Size(23, 22);
            this.pxAcesso.TabIndex = 16;
            this.pxAcesso.TabStop = false;
            // 
            // pxUsuario
            // 
            this.pxUsuario.BackColor = System.Drawing.Color.Tomato;
            this.pxUsuario.BackgroundImage = global::CamadaApresentacao.Properties.Resources.default_icon6;
            this.pxUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pxUsuario.Location = new System.Drawing.Point(1118, 28);
            this.pxUsuario.Name = "pxUsuario";
            this.pxUsuario.Size = new System.Drawing.Size(23, 22);
            this.pxUsuario.TabIndex = 15;
            this.pxUsuario.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(1354, 558);
            this.Controls.Add(this.pxAcesso);
            this.Controls.Add(this.pxUsuario);
            this.Controls.Add(this.lbAcesso);
            this.Controls.Add(this.lbSobrenome);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.TS);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.Text = "Sistema de Comércio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.TS.ResumeLayout(false);
            this.TS.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxAcesso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip TS;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuExibir;
        private System.Windows.Forms.ToolStripMenuItem toolBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuFerramentas;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuJanelas;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem MenuProdutos;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apresentaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuVendas;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuCompras;
        private System.Windows.Forms.ToolStripMenuItem entradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuConsultas;
        private System.Windows.Forms.ToolStripMenuItem vendasPorDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasPorDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuSistema;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuConfiguracoes;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton TSCompras;
        private System.Windows.Forms.ToolStripButton TSVendas;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbSobrenome;
        private System.Windows.Forms.Label lbAcesso;
        private System.Windows.Forms.PictureBox pxUsuario;
        private System.Windows.Forms.PictureBox pxAcesso;
    }
}



