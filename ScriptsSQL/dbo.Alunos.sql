CREATE TABLE [dbo].[Alunos] (
    [Id]             INT         IDENTITY (1, 1) NOT NULL,
    [Nome]           VARCHAR (255) NOT NULL,
    [Idade]          INT         NOT NULL,
    [Cpf]            VARCHAR (12) NOT NULL,
    [Rg]             VARCHAR (20) NOT NULL,
    [TelCelular]     VARCHAR (12) NOT NULL,
    [Email]          VARCHAR (200) NOT NULL,
    [Sexo]           VARCHAR (30) NOT NULL,
    [DataNascimento] DATE          NOT NULL,
    [DataCadastro]   DATE          NOT NULL,
    [IdResponsavel]  INT         NOT NULL,
    [Status]         BIT         NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

