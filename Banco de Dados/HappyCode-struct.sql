USE [HappyCode]
GO
/****** Object:  Table [dbo].[Aluno] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aluno](
	[Id_Aluno] [int] IDENTITY(1,1) NOT NULL,
	[Tx_Nome] [varchar](250) NOT NULL,
	[Dt_Nascimento] [datetime] NOT NULL,
	[Tx_CPF] [varchar](15) NOT NULL,
	[Tx_Sexo] [varchar](1) NOT NULL,
	[Tx_Rua] [varchar](250) NOT NULL,
	[Tx_Numero] [varchar](15) NOT NULL,
	[Tx_Complemento] [varchar](50) NULL,
	[Tx_Bairro] [varchar](200) NOT NULL,
	[Tx_CEP] [varchar](10) NOT NULL,
	[Tx_Municipio] [varchar](150) NOT NULL,
	[Tx_UF] [varchar](2) NOT NULL,
	[Nu_FoneDDD] [int] NULL,
	[Nu_Fone] [int] NULL,
	[Nu_CelDDD] [int] NULL,
	[Nu_Cel] [int] NULL,
	[Tx_Email] [varchar](250) NULL,
	[Tx_Responsavel] [varchar](250) NULL,
	[Dt_Criacao] [datetime] NOT NULL,
	[St_Ativo] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.Alunoes] PRIMARY KEY CLUSTERED 
(
	[Id_Aluno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Aula] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aula](
	[Id_Aula] [int] IDENTITY(1,1) NOT NULL,
	[Id_Turma] [int] NOT NULL,
	[Dt_Aula] [datetime] NOT NULL,
	[Tx_Assunto] [varchar](50) NOT NULL,
	[Tx_Conteudo] [varchar](max) NULL,
	[Tx_Observacoes] [varchar](max) NULL,
	[St_Avaliacao] [bit] NOT NULL,
	[St_Concluida] [bit] NOT NULL,
 CONSTRAINT [PK_Aula] PRIMARY KEY CLUSTERED 
(
	[Id_Aula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AulaAvaliacao] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AulaAvaliacao](
	[Id_AulaAvaliacao] [int] IDENTITY(1,1) NOT NULL,
	[Id_Aula] [int] NOT NULL,
	[Id_Matricula] [int] NOT NULL,
	[Vl_Avaliacao] [decimal](4, 2) NOT NULL,
 CONSTRAINT [PK_AulaAvaliacao] PRIMARY KEY CLUSTERED 
(
	[Id_AulaAvaliacao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AulaPresenca] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AulaPresenca](
	[Id_AulaPresenca] [int] IDENTITY(1,1) NOT NULL,
	[Id_Aula] [int] NOT NULL,
	[Id_Matricula] [int] NOT NULL,
	[St_Presenca] [bit] NOT NULL,
 CONSTRAINT [PK_AulaPresenca] PRIMARY KEY CLUSTERED 
(
	[Id_AulaPresenca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Curso] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Curso](
	[Id_Curso] [int] IDENTITY(1,1) NOT NULL,
	[Tx_Nome] [varchar](200) NOT NULL,
	[Nu_Aulas] [int] NULL,
	[Nu_CargaHoraria] [int] NULL,
	[Tx_Conteudo] [varchar](max) NULL,
	[Tx_Observacoes] [varchar](max) NULL,
	[Dt_Criacao] [datetime] NOT NULL,
	[St_Ativo] [bit] NOT NULL,
 CONSTRAINT [PK_Curso] PRIMARY KEY CLUSTERED 
(
	[Id_Curso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Matricula] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Matricula](
	[Id_Matricula] [int] IDENTITY(1,1) NOT NULL,
	[Id_Aluno] [int] NOT NULL,
	[Id_Turma] [int] NOT NULL,
	[Dt_Matricula] [datetime] NOT NULL,
	[Vl_NotaFinal] [decimal](4, 2) NULL,
	[Nu_FaltasFinal] [int] NULL,
	[Id_Status] [int] NOT NULL,
 CONSTRAINT [PK_Matricula] PRIMARY KEY CLUSTERED 
(
	[Id_Matricula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Professor] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Professor](
	[Id_Professor] [int] IDENTITY(1,1) NOT NULL,
	[Tx_Nome] [varchar](250) NOT NULL,
	[Dt_Nascimento] [datetime] NOT NULL,
	[Tx_CPF] [varchar](15) NOT NULL,
	[Tx_Sexo] [varchar](1) NOT NULL,
	[Tx_Rua] [varchar](250) NOT NULL,
	[Tx_Numero] [varchar](15) NOT NULL,
	[Tx_Complemento] [varchar](50) NULL,
	[Tx_Bairro] [varchar](200) NOT NULL,
	[Tx_CEP] [varchar](10) NOT NULL,
	[Tx_Municipio] [varchar](150) NOT NULL,
	[Tx_UF] [varchar](2) NOT NULL,
	[Nu_FoneDDD] [int] NULL,
	[Nu_Fone] [int] NULL,
	[Nu_CelDDD] [int] NULL,
	[Nu_Cel] [int] NULL,
	[Tx_Email] [varchar](250) NULL,
	[Tx_Responsavel] [varchar](250) NULL,
	[Dt_Criacao] [datetime] NOT NULL,
	[St_Ativo] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.Professores] PRIMARY KEY CLUSTERED 
(
	[Id_Professor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Turma] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Turma](
	[Id_Turma] [int] IDENTITY(1,1) NOT NULL,
	[Id_Curso] [int] NOT NULL,
	[Id_Professor] [int] NOT NULL,
	[Dt_Inicio] [datetime] NOT NULL,
	[Dt_Termino] [datetime] NOT NULL,
	[St_Concluido] [bit] NOT NULL,
 CONSTRAINT [PK_Turma] PRIMARY KEY CLUSTERED 
(
	[Id_Turma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TurmaDia] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TurmaDia](
	[Id_TurmaDia] [int] IDENTITY(1,1) NOT NULL,
	[Id_Turma] [int] NOT NULL,
	[Nu_DiaSemana] [int] NOT NULL,
	[Tm_Horario] [time](7) NOT NULL,
 CONSTRAINT [PK_TurmaDia] PRIMARY KEY CLUSTERED 
(
	[Id_TurmaDia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[Id_Professor] [int] NULL,
	[Tx_Nome] [varchar](200) NOT NULL,
	[Tx_Login] [varchar](200) NOT NULL,
	[Tx_Senha] [varchar](200) NOT NULL,
	[St_Admin] [bit] NOT NULL,
	[St_Ativo] [bit] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Id_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Aula]  WITH CHECK ADD  CONSTRAINT [FK_Aula_Turma] FOREIGN KEY([Id_Turma])
REFERENCES [dbo].[Turma] ([Id_Turma])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Aula] CHECK CONSTRAINT [FK_Aula_Turma]
GO
ALTER TABLE [dbo].[AulaAvaliacao]  WITH CHECK ADD  CONSTRAINT [FK_AulaAvaliacao_Aula] FOREIGN KEY([Id_Aula])
REFERENCES [dbo].[Aula] ([Id_Aula])
GO
ALTER TABLE [dbo].[AulaAvaliacao] CHECK CONSTRAINT [FK_AulaAvaliacao_Aula]
GO
ALTER TABLE [dbo].[AulaAvaliacao]  WITH CHECK ADD  CONSTRAINT [FK_AulaAvaliacao_Matricula] FOREIGN KEY([Id_Matricula])
REFERENCES [dbo].[Matricula] ([Id_Matricula])
GO
ALTER TABLE [dbo].[AulaAvaliacao] CHECK CONSTRAINT [FK_AulaAvaliacao_Matricula]
GO
ALTER TABLE [dbo].[AulaPresenca]  WITH CHECK ADD  CONSTRAINT [FK_AulaPresenca_Aula] FOREIGN KEY([Id_Aula])
REFERENCES [dbo].[Aula] ([Id_Aula])
GO
ALTER TABLE [dbo].[AulaPresenca] CHECK CONSTRAINT [FK_AulaPresenca_Aula]
GO
ALTER TABLE [dbo].[AulaPresenca]  WITH CHECK ADD  CONSTRAINT [FK_AulaPresenca_Matricula] FOREIGN KEY([Id_Matricula])
REFERENCES [dbo].[Matricula] ([Id_Matricula])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AulaPresenca] CHECK CONSTRAINT [FK_AulaPresenca_Matricula]
GO
ALTER TABLE [dbo].[Matricula]  WITH CHECK ADD  CONSTRAINT [FK_Matricula_Aluno] FOREIGN KEY([Id_Aluno])
REFERENCES [dbo].[Aluno] ([Id_Aluno])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Matricula] CHECK CONSTRAINT [FK_Matricula_Aluno]
GO
ALTER TABLE [dbo].[Matricula]  WITH CHECK ADD  CONSTRAINT [FK_Matricula_Turma] FOREIGN KEY([Id_Turma])
REFERENCES [dbo].[Turma] ([Id_Turma])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Matricula] CHECK CONSTRAINT [FK_Matricula_Turma]
GO
ALTER TABLE [dbo].[Turma]  WITH CHECK ADD  CONSTRAINT [FK_Turma_Curso] FOREIGN KEY([Id_Curso])
REFERENCES [dbo].[Curso] ([Id_Curso])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Turma] CHECK CONSTRAINT [FK_Turma_Curso]
GO
ALTER TABLE [dbo].[Turma]  WITH CHECK ADD  CONSTRAINT [FK_Turma_Professor] FOREIGN KEY([Id_Professor])
REFERENCES [dbo].[Professor] ([Id_Professor])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Turma] CHECK CONSTRAINT [FK_Turma_Professor]
GO
ALTER TABLE [dbo].[TurmaDia]  WITH CHECK ADD  CONSTRAINT [FK_TurmaDia_Turma] FOREIGN KEY([Id_Turma])
REFERENCES [dbo].[Turma] ([Id_Turma])
GO
ALTER TABLE [dbo].[TurmaDia] CHECK CONSTRAINT [FK_TurmaDia_Turma]
GO
ALTER DATABASE [HappyCode] SET  READ_WRITE 
GO
