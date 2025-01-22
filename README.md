Projeto de faculdade: protótipo de um sistema de controle de estoque.

Escrito em .NET com windows forms com a utilização da EntityFramework para a criação das models,

Requesitos: .NET 8 e SQL server

Script sql:


USE [FluxControl]
GO
/****** Object:  Table [dbo].[Entrada]    Script Date: 22/01/2025 19:22:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entrada](
	[idEntradaProduto] [int] IDENTITY(1,1) NOT NULL,
	[Produto_idProduto] [int] NOT NULL,
	[DataEntrada] [datetime] NOT NULL,
	[PrecoCompra] [float] NOT NULL,
	[PrecoVenda] [float] NOT NULL,
	[QuantidadeEntrada] [int] NOT NULL,
	[Lote] [int] NOT NULL,
	[DescricaoEntrada] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[idEntradaProduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estoque]    Script Date: 22/01/2025 19:22:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estoque](
	[idEstoque] [int] IDENTITY(1,1) NOT NULL,
	[Produto_idProduto] [int] NOT NULL,
	[Descricao] [varchar](255) NOT NULL,
	[PrecoVendaEstoque] [float] NOT NULL,
	[QuantidadeEstoque] [int] NOT NULL,
	[LoteEstoque] [int] NOT NULL,
	[DataValidadeEstoque] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idEstoque] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Produto]    Script Date: 22/01/2025 19:22:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produto](
	[idProduto] [int] IDENTITY(1,1) NOT NULL,
	[TipoProduto_idTipoProduto] [int] NOT NULL,
	[Nome] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idProduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Saida]    Script Date: 22/01/2025 19:22:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Saida](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Produto_idProduto] [int] NOT NULL,
	[DataSaida] [datetime] NOT NULL,
	[PrecoSaida] [float] NOT NULL,
	[QuantidadeSaida] [int] NOT NULL,
	[LoteSaida] [int] NOT NULL,
	[Desconto] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoProduto]    Script Date: 22/01/2025 19:22:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoProduto](
	[idTipoProduto] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idTipoProduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 22/01/2025 19:22:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](255) NOT NULL,
	[Email] [varchar](255) NOT NULL,
	[Senha] [varchar](255) NOT NULL,
	[Admin] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Saida] ADD  DEFAULT ((0)) FOR [Desconto]
GO
ALTER TABLE [dbo].[Entrada]  WITH CHECK ADD  CONSTRAINT [FK_Entrada_Produto] FOREIGN KEY([Produto_idProduto])
REFERENCES [dbo].[Produto] ([idProduto])
GO
ALTER TABLE [dbo].[Entrada] CHECK CONSTRAINT [FK_Entrada_Produto]
GO
ALTER TABLE [dbo].[Estoque]  WITH CHECK ADD  CONSTRAINT [FK_Estoque_Produto] FOREIGN KEY([Produto_idProduto])
REFERENCES [dbo].[Produto] ([idProduto])
GO
ALTER TABLE [dbo].[Estoque] CHECK CONSTRAINT [FK_Estoque_Produto]
GO
ALTER TABLE [dbo].[Produto]  WITH CHECK ADD  CONSTRAINT [FK_Produto_TipoProduto] FOREIGN KEY([TipoProduto_idTipoProduto])
REFERENCES [dbo].[TipoProduto] ([idTipoProduto])
GO
ALTER TABLE [dbo].[Produto] CHECK CONSTRAINT [FK_Produto_TipoProduto]
GO
ALTER TABLE [dbo].[Saida]  WITH CHECK ADD  CONSTRAINT [FK_Saida_Produto] FOREIGN KEY([Produto_idProduto])
REFERENCES [dbo].[Produto] ([idProduto])
GO
ALTER TABLE [dbo].[Saida] CHECK CONSTRAINT [FK_Saida_Produto]
GO
