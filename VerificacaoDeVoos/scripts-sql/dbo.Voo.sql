CREATE TABLE [dbo].[Voo] (
    [Id]              INT      IDENTITY (1, 1) NOT NULL,
    [data]            DATE NOT NULL,
    [horario]         TIME NOT NULL,
    [duracao]         INT      NOT NULL,
    [idAviao]         INT      NOT NULL,
    [idCidadeOrigem]  INT      NOT NULL,
    [idCidadeDestino] INT      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([idAviao]) REFERENCES [dbo].[Aviao] ([Id]),
    FOREIGN KEY ([idCidadeOrigem]) REFERENCES [dbo].[Cidade] ([Id]),
    FOREIGN KEY ([idCidadeDestino]) REFERENCES [dbo].[Cidade] ([Id])
);

