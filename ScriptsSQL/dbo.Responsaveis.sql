CREATE TABLE [dbo].[Responsaveis] (
    [Id]             INT           IDENTITY (1, 1) NOT NULL,
    [Nome]           VARCHAR (255) NOT NULL,
    [Idade]          INT           NOT NULL,
    [Cpf]            VARCHAR (12) NOT NULL,
    [Rg]             VARCHAR (20) NOT NULL,
    [TelCelular]     VARCHAR (12) NOT NULL,
    [Email]          VARCHAR (200) NOT NULL,
    [Sexo]           VARCHAR (30) NOT NULL,
    [DataNascimento] DATE          NOT NULL,
    [DataCadastro]   DATE          NOT NULL,
    [GrauParentesco] VARCHAR (20) NOT NULL,
    [Ocupacao]       VARCHAR (200) NOT NULL,
    [Renda]          REAL          NOT NULL,
    [NomeContato]    VARCHAR (255) NOT NULL,
    [TelContato]     VARCHAR (12) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

