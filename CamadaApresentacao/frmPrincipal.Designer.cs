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
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSCompras = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSVendas = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apresentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaPoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasPorDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFerramentas = new System.Windows.Forms.ToolStripMenuItem();
            this.bDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pxAcesso = new System.Windows.Forms.PictureBox();
            this.pxUsuario = new System.Windows.Forms.PictureBox();
            this.lbAcesso = new System.Windows.Forms.Label();
            this.lbSobrenome = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxAcesso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.Tomato;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.TSCompras,
            this.toolStripSeparator2,
            this.TSVendas});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(802, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(802, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "Sistema de Gerenciamento de Comércio";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
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
            this.toolStripMenuItem1,
            this.MenuSistema});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(802, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // MenuProdutos
            // 
            this.MenuProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem1,
            this.categoriasToolStripMenuItem,
            this.apresentaçãoToolStripMenuItem});
            this.MenuProdutos.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuProdutos.Image = global::CamadaApresentacao.Properties.Resources._1481080190_deliverables;
            this.MenuProdutos.Name = "MenuProdutos";
            this.MenuProdutos.Size = new System.Drawing.Size(84, 20);
            this.MenuProdutos.Text = "Produtos";
            // 
            // produtosToolStripMenuItem1
            // 
            this.produtosToolStripMenuItem1.Name = "produtosToolStripMenuItem1";
            this.produtosToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.produtosToolStripMenuItem1.Text = "Produtos";
            this.produtosToolStripMenuItem1.Click += new System.EventHandler(this.produtosToolStripMenuItem1_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // apresentaçãoToolStripMenuItem
            // 
            this.apresentaçãoToolStripMenuItem.Name = "apresentaçãoToolStripMenuItem";
            this.apresentaçãoToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.apresentaçãoToolStripMenuItem.Text = "Apresentação";
            this.apresentaçãoToolStripMenuItem.Click += new System.EventHandler(this.apresentaçãoToolStripMenuItem_Click);
            // 
            // MenuVendas
            // 
            this.MenuVendas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendaToolStripMenuItem,
            this.clienteToolStripMenuItem});
            this.MenuVendas.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuVendas.Image = global::CamadaApresentacao.Properties.Resources._1481080265_shopping_cart;
            this.MenuVendas.Name = "MenuVendas";
            this.MenuVendas.Size = new System.Drawing.Size(75, 20);
            this.MenuVendas.Text = "Vendas";
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.vendaToolStripMenuItem.Text = "Venda";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // MenuCompras
            // 
            this.MenuCompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaToolStripMenuItem,
            this.fornecedoresToolStripMenuItem});
            this.MenuCompras.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuCompras.Image = global::CamadaApresentacao.Properties.Resources._1481080293_Money;
            this.MenuCompras.Name = "MenuCompras";
            this.MenuCompras.Size = new System.Drawing.Size(85, 20);
            this.MenuCompras.Text = "Compras";
            // 
            // entradaToolStripMenuItem
            // 
            this.entradaToolStripMenuItem.Name = "entradaToolStripMenuItem";
            this.entradaToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.entradaToolStripMenuItem.Text = "Entrada";
            this.entradaToolStripMenuItem.Click += new System.EventHandler(this.entradaToolStripMenuItem_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem_Click);
            // 
            // MenuConsultas
            // 
            this.MenuConsultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendaPoToolStripMenuItem,
            this.comprasPorDataToolStripMenuItem,
            this.estoqueDeProdutosToolStripMenuItem});
            this.MenuConsultas.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuConsultas.Image = global::CamadaApresentacao.Properties.Resources._1481080316_system_search;
            this.MenuConsultas.Name = "MenuConsultas";
            this.MenuConsultas.Size = new System.Drawing.Size(88, 20);
            this.MenuConsultas.Text = "Consultas";
            // 
            // vendaPoToolStripMenuItem
            // 
            this.vendaPoToolStripMenuItem.Name = "vendaPoToolStripMenuItem";
            this.vendaPoToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.vendaPoToolStripMenuItem.Text = "Vendas por Data";
            // 
            // comprasPorDataToolStripMenuItem
            // 
            this.comprasPorDataToolStripMenuItem.Name = "comprasPorDataToolStripMenuItem";
            this.comprasPorDataToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.comprasPorDataToolStripMenuItem.Text = "Compras por Data";
            // 
            // estoqueDeProdutosToolStripMenuItem
            // 
            this.estoqueDeProdutosToolStripMenuItem.Name = "estoqueDeProdutosToolStripMenuItem";
            this.estoqueDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.estoqueDeProdutosToolStripMenuItem.Text = "Estoque de Produtos";
            // 
            // MenuFerramentas
            // 
            this.MenuFerramentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bDToolStripMenuItem});
            this.MenuFerramentas.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuFerramentas.Image = global::CamadaApresentacao.Properties.Resources.tool_edit_icon1;
            this.MenuFerramentas.Name = "MenuFerramentas";
            this.MenuFerramentas.Size = new System.Drawing.Size(104, 20);
            this.MenuFerramentas.Text = "Ferramentas";
            // 
            // bDToolStripMenuItem
            // 
            this.bDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupToolStripMenuItem});
            this.bDToolStripMenuItem.Name = "bDToolStripMenuItem";
            this.bDToolStripMenuItem.Size = new System.Drawing.Size(90, 22);
            this.bDToolStripMenuItem.Text = "BD";
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.backupToolStripMenuItem.Text = "Backup";
            // 
            // MenuConfiguracoes
            // 
            this.MenuConfiguracoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionáriosToolStripMenuItem});
            this.MenuConfiguracoes.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuConfiguracoes.Image = global::CamadaApresentacao.Properties.Resources.Categories_preferences_system_icon;
            this.MenuConfiguracoes.Name = "MenuConfiguracoes";
            this.MenuConfiguracoes.Size = new System.Drawing.Size(113, 20);
            this.MenuConfiguracoes.Text = "Configurações";
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            // 
            // MenuExibir
            // 
            this.MenuExibir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBarToolStripMenuItem,
            this.statusBarToolStripMenuItem});
            this.MenuExibir.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuExibir.Image = global::CamadaApresentacao.Properties.Resources.CinemaDisplay_icon;
            this.MenuExibir.Name = "MenuExibir";
            this.MenuExibir.Size = new System.Drawing.Size(65, 20);
            this.MenuExibir.Text = "Exibir";
            // 
            // toolBarToolStripMenuItem
            // 
            this.toolBarToolStripMenuItem.Checked = true;
            this.toolBarToolStripMenuItem.CheckOnClick = true;
            this.toolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
            this.toolBarToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.toolBarToolStripMenuItem.Text = "&Barra de Ferramentas";
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckOnClick = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.statusBarToolStripMenuItem.Text = "Barra de Status";
            // 
            // MenuJanelas
            // 
            this.MenuJanelas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem,
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem});
            this.MenuJanelas.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuJanelas.Image = global::CamadaApresentacao.Properties.Resources.Windows_Media_Center_icon1;
            this.MenuJanelas.Name = "MenuJanelas";
            this.MenuJanelas.Size = new System.Drawing.Size(75, 20);
            this.MenuJanelas.Text = "Janelas";
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.newWindowToolStripMenuItem.Text = "Nova Janela";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.cascadeToolStripMenuItem.Text = "Cascata";
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.tileVerticalToolStripMenuItem.Text = "Empilhar Vertical";
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.tileHorizontalToolStripMenuItem.Text = "Tile &Horizontal";
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.closeAllToolStripMenuItem.Text = "F&echar Todos";
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.arrangeIconsToolStripMenuItem.Text = "&Organizar Ícones";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // MenuSistema
            // 
            this.MenuSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.MenuSistema.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuSistema.Image = global::CamadaApresentacao.Properties.Resources.File_System_icon;
            this.MenuSistema.Name = "MenuSistema";
            this.MenuSistema.Size = new System.Drawing.Size(77, 20);
            this.MenuSistema.Text = "Sistema";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::CamadaApresentacao.Properties.Resources.Alarm_Error_icon;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // pxAcesso
            // 
            this.pxAcesso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pxAcesso.BackColor = System.Drawing.Color.Tomato;
            this.pxAcesso.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Keys_icon2;
            this.pxAcesso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pxAcesso.Location = new System.Drawing.Point(691, 24);
            this.pxAcesso.Name = "pxAcesso";
            this.pxAcesso.Size = new System.Drawing.Size(23, 22);
            this.pxAcesso.TabIndex = 21;
            this.pxAcesso.TabStop = false;
            // 
            // pxUsuario
            // 
            this.pxUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pxUsuario.BackColor = System.Drawing.Color.Tomato;
            this.pxUsuario.BackgroundImage = global::CamadaApresentacao.Properties.Resources.default_icon6;
            this.pxUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pxUsuario.Location = new System.Drawing.Point(559, 24);
            this.pxUsuario.Name = "pxUsuario";
            this.pxUsuario.Size = new System.Drawing.Size(23, 22);
            this.pxUsuario.TabIndex = 20;
            this.pxUsuario.TabStop = false;
            // 
            // lbAcesso
            // 
            this.lbAcesso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAcesso.AutoSize = true;
            this.lbAcesso.BackColor = System.Drawing.Color.Tomato;
            this.lbAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAcesso.Location = new System.Drawing.Point(720, 30);
            this.lbAcesso.Name = "lbAcesso";
            this.lbAcesso.Size = new System.Drawing.Size(35, 12);
            this.lbAcesso.TabIndex = 19;
            this.lbAcesso.Text = "label1";
            // 
            // lbSobrenome
            // 
            this.lbSobrenome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSobrenome.AutoSize = true;
            this.lbSobrenome.BackColor = System.Drawing.Color.Tomato;
            this.lbSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSobrenome.Location = new System.Drawing.Point(629, 30);
            this.lbSobrenome.Name = "lbSobrenome";
            this.lbSobrenome.Size = new System.Drawing.Size(35, 12);
            this.lbSobrenome.TabIndex = 18;
            this.lbSobrenome.Text = "label1";
            // 
            // lbNome
            // 
            this.lbNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNome.AutoSize = true;
            this.lbNome.BackColor = System.Drawing.Color.Tomato;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(588, 30);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 12);
            this.lbNome.TabIndex = 17;
            this.lbNome.Text = "label1";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 453);
            this.Controls.Add(this.pxAcesso);
            this.Controls.Add(this.pxUsuario);
            this.Controls.Add(this.lbAcesso);
            this.Controls.Add(this.lbSobrenome);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmPrincipal";
            this.Text = "Sistema de Comércio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxAcesso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuProdutos;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apresentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuVendas;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuCompras;
        private System.Windows.Forms.ToolStripMenuItem entradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuConsultas;
        private System.Windows.Forms.ToolStripMenuItem vendaPoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasPorDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuFerramentas;
        private System.Windows.Forms.ToolStripMenuItem bDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuConfiguracoes;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuExibir;
        private System.Windows.Forms.ToolStripMenuItem toolBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuJanelas;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuSistema;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton TSCompras;
        private System.Windows.Forms.ToolStripButton TSVendas;
        private System.Windows.Forms.PictureBox pxAcesso;
        private System.Windows.Forms.PictureBox pxUsuario;
        private System.Windows.Forms.Label lbAcesso;
        private System.Windows.Forms.Label lbSobrenome;
        private System.Windows.Forms.Label lbNome;
    }
}



