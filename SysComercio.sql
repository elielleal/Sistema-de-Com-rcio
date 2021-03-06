USE [master]
GO
/****** Object:  Database [dbcomercio]    Script Date: 04/07/2017 11:38:09 ******/
CREATE DATABASE [dbcomercio]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbcomercio', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\dbcomercio.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'dbcomercio_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\dbcomercio_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [dbcomercio] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbcomercio].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbcomercio] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbcomercio] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbcomercio] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbcomercio] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbcomercio] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbcomercio] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbcomercio] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbcomercio] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbcomercio] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbcomercio] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbcomercio] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbcomercio] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbcomercio] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbcomercio] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbcomercio] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dbcomercio] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbcomercio] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbcomercio] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbcomercio] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbcomercio] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbcomercio] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbcomercio] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbcomercio] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dbcomercio] SET  MULTI_USER 
GO
ALTER DATABASE [dbcomercio] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbcomercio] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbcomercio] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbcomercio] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [dbcomercio] SET DELAYED_DURABILITY = DISABLED 
GO
USE [dbcomercio]
GO
/****** Object:  Table [dbo].[Apresentacao]    Script Date: 04/07/2017 11:38:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Apresentacao](
	[idapresetacao] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[descricao] [varchar](100) NULL,
 CONSTRAINT [PK_Apresentacao] PRIMARY KEY CLUSTERED 
(
	[idapresetacao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 04/07/2017 11:38:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categoria](
	[idcategoria] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[descricao] [varchar](100) NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[idcategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 04/07/2017 11:38:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cliente](
	[idcliente] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[sobrenome] [varchar](50) NULL,
	[sexo] [varchar](1) NULL,
	[tipo_documento] [varchar](50) NULL,
	[num_documento] [varchar](50) NULL,
	[endereco] [varchar](150) NULL,
	[telefone] [varchar](50) NULL,
	[email] [varchar](50) NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[idcliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Detalhe_Entrada]    Script Date: 04/07/2017 11:38:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalhe_Entrada](
	[iddetalhe_entrada] [int] IDENTITY(1,1) NOT NULL,
	[identrada] [int] NOT NULL,
	[idproduto] [int] NOT NULL,
	[preco_compra] [money] NOT NULL,
	[preco_venda] [money] NOT NULL,
	[estoque_inicial] [int] NOT NULL,
	[estoque_atual] [int] NOT NULL,
	[data_producao] [date] NULL,
	[data_vencimento] [date] NOT NULL,
 CONSTRAINT [PK_Detalhe_Entrada] PRIMARY KEY CLUSTERED 
(
	[iddetalhe_entrada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Detalhe_Venda]    Script Date: 04/07/2017 11:38:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalhe_Venda](
	[iddetalhe_venda] [int] IDENTITY(1,1) NOT NULL,
	[idvenda] [int] NOT NULL,
	[iddetalhe_entrada] [int] NOT NULL,
	[quantidade] [int] NOT NULL,
	[preco_venda] [money] NOT NULL,
	[desconto] [money] NULL,
 CONSTRAINT [PK_Detalhe_Venda] PRIMARY KEY CLUSTERED 
(
	[iddetalhe_venda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Entrada]    Script Date: 04/07/2017 11:38:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Entrada](
	[identrada] [int] IDENTITY(1,1) NOT NULL,
	[idfuncionario] [int] NOT NULL,
	[idfornecedor] [int] NOT NULL,
	[data] [date] NOT NULL,
	[tipo_comprovante] [varchar](50) NOT NULL,
	[serie] [varchar](4) NOT NULL,
	[correlativo] [varchar](7) NOT NULL,
	[imposto] [decimal](4, 2) NULL,
 CONSTRAINT [PK_Entrada] PRIMARY KEY CLUSTERED 
(
	[identrada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Fornecedor]    Script Date: 04/07/2017 11:38:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Fornecedor](
	[idfornecedor] [int] IDENTITY(1,1) NOT NULL,
	[empresa] [varchar](50) NOT NULL,
	[setor_comercial] [varchar](50) NOT NULL,
	[tipo_documento] [varchar](50) NOT NULL,
	[num_documento] [varchar](50) NOT NULL,
	[endereco] [varchar](150) NOT NULL,
	[telefone] [varchar](50) NOT NULL,
	[email] [varbinary](50) NULL,
	[url] [varchar](50) NULL,
 CONSTRAINT [PK_Fornecedor] PRIMARY KEY CLUSTERED 
(
	[idfornecedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Funcionario]    Script Date: 04/07/2017 11:38:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Funcionario](
	[idfuncionario] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[sobrenome] [varchar](50) NOT NULL,
	[sexo] [varchar](1) NOT NULL,
	[data_nascimento] [date] NOT NULL,
	[num_documento] [varchar](50) NOT NULL,
	[endereco] [varchar](150) NOT NULL,
	[telefone] [varchar](50) NOT NULL,
	[email] [varchar](50) NULL,
	[acesso] [varchar](50) NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[senha] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Funcionarios] PRIMARY KEY CLUSTERED 
(
	[idfuncionario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Produto]    Script Date: 04/07/2017 11:38:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Produto](
	[idproduto] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [varchar](50) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[descricao] [varchar](500) NULL,
	[imagem] [image] NULL,
	[idcategoria] [int] NOT NULL,
	[idapresentacao] [int] NOT NULL,
 CONSTRAINT [PK_Produtos] PRIMARY KEY CLUSTERED 
(
	[idproduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Venda]    Script Date: 04/07/2017 11:38:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Venda](
	[idvenda] [int] IDENTITY(1,1) NOT NULL,
	[idcliente] [int] NOT NULL,
	[idfuncionario] [int] NOT NULL,
	[data] [date] NOT NULL,
	[tipo_comprovante] [varchar](50) NOT NULL,
	[serie] [varchar](4) NOT NULL,
	[correlativo] [varchar](7) NULL,
	[imposto] [decimal](4, 2) NULL,
 CONSTRAINT [PK_Vendas] PRIMARY KEY CLUSTERED 
(
	[idvenda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Detalhe_Entrada]  WITH CHECK ADD  CONSTRAINT [FK_Detalhe_Entrada_Entrada] FOREIGN KEY([identrada])
REFERENCES [dbo].[Entrada] ([identrada])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Detalhe_Entrada] CHECK CONSTRAINT [FK_Detalhe_Entrada_Entrada]
GO
ALTER TABLE [dbo].[Detalhe_Entrada]  WITH CHECK ADD  CONSTRAINT [FK_Detalhe_Entrada_Produtos] FOREIGN KEY([idproduto])
REFERENCES [dbo].[Produto] ([idproduto])
GO
ALTER TABLE [dbo].[Detalhe_Entrada] CHECK CONSTRAINT [FK_Detalhe_Entrada_Produtos]
GO
ALTER TABLE [dbo].[Detalhe_Venda]  WITH CHECK ADD  CONSTRAINT [FK_Detalhe_Venda_Detalhe_Entrada] FOREIGN KEY([iddetalhe_entrada])
REFERENCES [dbo].[Detalhe_Entrada] ([iddetalhe_entrada])
GO
ALTER TABLE [dbo].[Detalhe_Venda] CHECK CONSTRAINT [FK_Detalhe_Venda_Detalhe_Entrada]
GO
ALTER TABLE [dbo].[Detalhe_Venda]  WITH CHECK ADD  CONSTRAINT [FK_Detalhe_Venda_Vendas] FOREIGN KEY([idvenda])
REFERENCES [dbo].[Venda] ([idvenda])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Detalhe_Venda] CHECK CONSTRAINT [FK_Detalhe_Venda_Vendas]
GO
ALTER TABLE [dbo].[Entrada]  WITH CHECK ADD  CONSTRAINT [FK_Entrada_Fornecedor] FOREIGN KEY([idfornecedor])
REFERENCES [dbo].[Fornecedor] ([idfornecedor])
GO
ALTER TABLE [dbo].[Entrada] CHECK CONSTRAINT [FK_Entrada_Fornecedor]
GO
ALTER TABLE [dbo].[Entrada]  WITH CHECK ADD  CONSTRAINT [FK_Entrada_Funcionarios] FOREIGN KEY([idfuncionario])
REFERENCES [dbo].[Funcionario] ([idfuncionario])
GO
ALTER TABLE [dbo].[Entrada] CHECK CONSTRAINT [FK_Entrada_Funcionarios]
GO
ALTER TABLE [dbo].[Produto]  WITH CHECK ADD  CONSTRAINT [FK_Produtos_Apresentacao] FOREIGN KEY([idapresentacao])
REFERENCES [dbo].[Apresentacao] ([idapresetacao])
GO
ALTER TABLE [dbo].[Produto] CHECK CONSTRAINT [FK_Produtos_Apresentacao]
GO
ALTER TABLE [dbo].[Produto]  WITH CHECK ADD  CONSTRAINT [FK_Produtos_Categoria] FOREIGN KEY([idcategoria])
REFERENCES [dbo].[Categoria] ([idcategoria])
GO
ALTER TABLE [dbo].[Produto] CHECK CONSTRAINT [FK_Produtos_Categoria]
GO
ALTER TABLE [dbo].[Venda]  WITH CHECK ADD  CONSTRAINT [FK_Vendas_Clientes] FOREIGN KEY([idcliente])
REFERENCES [dbo].[Cliente] ([idcliente])
GO
ALTER TABLE [dbo].[Venda] CHECK CONSTRAINT [FK_Vendas_Clientes]
GO
ALTER TABLE [dbo].[Venda]  WITH CHECK ADD  CONSTRAINT [FK_Vendas_Funcionarios] FOREIGN KEY([idfuncionario])
REFERENCES [dbo].[Funcionario] ([idfuncionario])
GO
ALTER TABLE [dbo].[Venda] CHECK CONSTRAINT [FK_Vendas_Funcionarios]
GO
USE [master]
GO
ALTER DATABASE [dbcomercio] SET  READ_WRITE 
GO
