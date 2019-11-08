CREATE TABLE [dbo].[Enderecos] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [Cep]          VARCHAR (55)  NOT NULL,
    [Numero]       VARCHAR (10)  NOT NULL,
    [Complemento]  VARCHAR (30)  NOT NULL,
    [Bairro]       VARCHAR (200) NOT NULL,
    [Cidade]       VARCHAR (200) NOT NULL,
    [Estado]       VARCHAR (3)   NOT NULL,
    [IdPessoa]     INT           NOT NULL,
    [DataCadastro] DATE          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([IdPessoa]) REFERENCES [dbo].[Responsaveis] ([IdPessoa]),
    CONSTRAINT [FK_dbo.Enderecos_dbo.Responsaveis_Id] FOREIGN KEY ([IdPessoa]) REFERENCES [dbo].[Responsaveis] ([IdPessoa]) ON DELETE CASCADE
);

