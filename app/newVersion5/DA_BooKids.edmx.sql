
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/23/2021 22:42:47
-- Generated from EDMX file: C:\Users\Eduardo-PC\Desktop\IPL\PSI\1º ano\2ºsemestre_1ºano\DA\Projeto\PSI_DA_PL-newVersion4\app\newVersion4\DA_BooKids.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BooKids_DB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'PessoaSet'
CREATE TABLE [dbo].[PessoaSet] (
    [IdPessoa] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [Localidade] nvarchar(max)  NOT NULL,
    [CodPostal] int  NOT NULL,
    [Telefone] int  NOT NULL,
    [Telemovel] int  NOT NULL,
    [Email] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CompraSet'
CREATE TABLE [dbo].[CompraSet] (
    [Data] datetime  NOT NULL,
    [UtilizouCartao] bit  NOT NULL,
    [ProdutosCodProduto] int  NOT NULL,
    [NrCompra] int  NOT NULL,
    [IdCliente] int  NOT NULL
);
GO

-- Creating table 'InscricaoSet'
CREATE TABLE [dbo].[InscricaoSet] (
    [Confirmada] bit  NOT NULL,
    [FilhoIdPessoa] int  NOT NULL,
    [EventoNrEvento] int  NOT NULL
);
GO

-- Creating table 'EscolaSet'
CREATE TABLE [dbo].[EscolaSet] (
    [IdEscola] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [Telefone] int  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [CodPostal] int  NOT NULL,
    [Localidade] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DetalheCompraSet'
CREATE TABLE [dbo].[DetalheCompraSet] (
    [Quantidade] int  NOT NULL,
    [CompraNrCompra] int  NOT NULL,
    [ProdutoCodProduto] int  NOT NULL
);
GO

-- Creating table 'ProdutoSet'
CREATE TABLE [dbo].[ProdutoSet] (
    [CodProduto] int IDENTITY(1,1) NOT NULL,
    [Designacao] nvarchar(max)  NOT NULL,
    [Preco] float  NOT NULL,
    [StockExistente] nvarchar(max)  NOT NULL,
    [CodTipoProduto] int  NOT NULL
);
GO

-- Creating table 'TipoProdutoSet'
CREATE TABLE [dbo].[TipoProdutoSet] (
    [CodTipoProduto] int  NOT NULL,
    [Tipo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'EventoSet'
CREATE TABLE [dbo].[EventoSet] (
    [NrEvento] int IDENTITY(1,1) NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [Local] nvarchar(max)  NOT NULL,
    [DataHora] datetime  NOT NULL,
    [LimiteParticipacao] int  NOT NULL,
    [IdadeInferior] int  NOT NULL,
    [IdadeSuperior] int  NOT NULL,
    [TipoEvento] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ParticipacaoSet'
CREATE TABLE [dbo].[ParticipacaoSet] (
    [IdEscola] int  NOT NULL,
    [NrEvento] int  NOT NULL
);
GO

-- Creating table 'ColaboracaoSet'
CREATE TABLE [dbo].[ColaboracaoSet] (
    [IdAnimador] int  NOT NULL,
    [NrEvento] int  NOT NULL
);
GO

-- Creating table 'PessoaSet_Cliente'
CREATE TABLE [dbo].[PessoaSet_Cliente] (
    [ValorOferta] float  NOT NULL,
    [NrCartao] int  NOT NULL,
    [IdPessoa] int  NOT NULL
);
GO

-- Creating table 'PessoaSet_Filho'
CREATE TABLE [dbo].[PessoaSet_Filho] (
    [Sexo] nvarchar(max)  NOT NULL,
    [DataNascimento] datetime  NOT NULL,
    [IdProgenitor] int  NOT NULL,
    [IdEscola] int  NOT NULL,
    [IdPessoa] int  NOT NULL
);
GO

-- Creating table 'PessoaSet_Animador'
CREATE TABLE [dbo].[PessoaSet_Animador] (
    [Especialidade] nvarchar(max)  NOT NULL,
    [IdPessoa] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdPessoa] in table 'PessoaSet'
ALTER TABLE [dbo].[PessoaSet]
ADD CONSTRAINT [PK_PessoaSet]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- Creating primary key on [NrCompra] in table 'CompraSet'
ALTER TABLE [dbo].[CompraSet]
ADD CONSTRAINT [PK_CompraSet]
    PRIMARY KEY CLUSTERED ([NrCompra] ASC);
GO

-- Creating primary key on [FilhoIdPessoa], [EventoNrEvento] in table 'InscricaoSet'
ALTER TABLE [dbo].[InscricaoSet]
ADD CONSTRAINT [PK_InscricaoSet]
    PRIMARY KEY CLUSTERED ([FilhoIdPessoa], [EventoNrEvento] ASC);
GO

-- Creating primary key on [IdEscola] in table 'EscolaSet'
ALTER TABLE [dbo].[EscolaSet]
ADD CONSTRAINT [PK_EscolaSet]
    PRIMARY KEY CLUSTERED ([IdEscola] ASC);
GO

-- Creating primary key on [CompraNrCompra], [ProdutoCodProduto] in table 'DetalheCompraSet'
ALTER TABLE [dbo].[DetalheCompraSet]
ADD CONSTRAINT [PK_DetalheCompraSet]
    PRIMARY KEY CLUSTERED ([CompraNrCompra], [ProdutoCodProduto] ASC);
GO

-- Creating primary key on [CodProduto] in table 'ProdutoSet'
ALTER TABLE [dbo].[ProdutoSet]
ADD CONSTRAINT [PK_ProdutoSet]
    PRIMARY KEY CLUSTERED ([CodProduto] ASC);
GO

-- Creating primary key on [CodTipoProduto] in table 'TipoProdutoSet'
ALTER TABLE [dbo].[TipoProdutoSet]
ADD CONSTRAINT [PK_TipoProdutoSet]
    PRIMARY KEY CLUSTERED ([CodTipoProduto] ASC);
GO

-- Creating primary key on [NrEvento] in table 'EventoSet'
ALTER TABLE [dbo].[EventoSet]
ADD CONSTRAINT [PK_EventoSet]
    PRIMARY KEY CLUSTERED ([NrEvento] ASC);
GO

-- Creating primary key on [IdEscola], [NrEvento] in table 'ParticipacaoSet'
ALTER TABLE [dbo].[ParticipacaoSet]
ADD CONSTRAINT [PK_ParticipacaoSet]
    PRIMARY KEY CLUSTERED ([IdEscola], [NrEvento] ASC);
GO

-- Creating primary key on [IdAnimador], [NrEvento] in table 'ColaboracaoSet'
ALTER TABLE [dbo].[ColaboracaoSet]
ADD CONSTRAINT [PK_ColaboracaoSet]
    PRIMARY KEY CLUSTERED ([IdAnimador], [NrEvento] ASC);
GO

-- Creating primary key on [IdPessoa] in table 'PessoaSet_Cliente'
ALTER TABLE [dbo].[PessoaSet_Cliente]
ADD CONSTRAINT [PK_PessoaSet_Cliente]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- Creating primary key on [IdPessoa] in table 'PessoaSet_Filho'
ALTER TABLE [dbo].[PessoaSet_Filho]
ADD CONSTRAINT [PK_PessoaSet_Filho]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- Creating primary key on [IdPessoa] in table 'PessoaSet_Animador'
ALTER TABLE [dbo].[PessoaSet_Animador]
ADD CONSTRAINT [PK_PessoaSet_Animador]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdProgenitor] in table 'PessoaSet_Filho'
ALTER TABLE [dbo].[PessoaSet_Filho]
ADD CONSTRAINT [FK_ClienteFilho]
    FOREIGN KEY ([IdProgenitor])
    REFERENCES [dbo].[PessoaSet_Cliente]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteFilho'
CREATE INDEX [IX_FK_ClienteFilho]
ON [dbo].[PessoaSet_Filho]
    ([IdProgenitor]);
GO

-- Creating foreign key on [IdEscola] in table 'PessoaSet_Filho'
ALTER TABLE [dbo].[PessoaSet_Filho]
ADD CONSTRAINT [FK_EscolaFilho]
    FOREIGN KEY ([IdEscola])
    REFERENCES [dbo].[EscolaSet]
        ([IdEscola])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EscolaFilho'
CREATE INDEX [IX_FK_EscolaFilho]
ON [dbo].[PessoaSet_Filho]
    ([IdEscola]);
GO

-- Creating foreign key on [IdCliente] in table 'CompraSet'
ALTER TABLE [dbo].[CompraSet]
ADD CONSTRAINT [FK_ClienteCompra]
    FOREIGN KEY ([IdCliente])
    REFERENCES [dbo].[PessoaSet_Cliente]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteCompra'
CREATE INDEX [IX_FK_ClienteCompra]
ON [dbo].[CompraSet]
    ([IdCliente]);
GO

-- Creating foreign key on [CompraNrCompra] in table 'DetalheCompraSet'
ALTER TABLE [dbo].[DetalheCompraSet]
ADD CONSTRAINT [FK_CompraDetalheCompra]
    FOREIGN KEY ([CompraNrCompra])
    REFERENCES [dbo].[CompraSet]
        ([NrCompra])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ProdutoCodProduto] in table 'DetalheCompraSet'
ALTER TABLE [dbo].[DetalheCompraSet]
ADD CONSTRAINT [FK_ProdutoDetalheCompra]
    FOREIGN KEY ([ProdutoCodProduto])
    REFERENCES [dbo].[ProdutoSet]
        ([CodProduto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProdutoDetalheCompra'
CREATE INDEX [IX_FK_ProdutoDetalheCompra]
ON [dbo].[DetalheCompraSet]
    ([ProdutoCodProduto]);
GO

-- Creating foreign key on [CodTipoProduto] in table 'ProdutoSet'
ALTER TABLE [dbo].[ProdutoSet]
ADD CONSTRAINT [FK_TipoProdutoProduto]
    FOREIGN KEY ([CodTipoProduto])
    REFERENCES [dbo].[TipoProdutoSet]
        ([CodTipoProduto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TipoProdutoProduto'
CREATE INDEX [IX_FK_TipoProdutoProduto]
ON [dbo].[ProdutoSet]
    ([CodTipoProduto]);
GO

-- Creating foreign key on [FilhoIdPessoa] in table 'InscricaoSet'
ALTER TABLE [dbo].[InscricaoSet]
ADD CONSTRAINT [FK_FilhoInscricao]
    FOREIGN KEY ([FilhoIdPessoa])
    REFERENCES [dbo].[PessoaSet_Filho]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [EventoNrEvento] in table 'InscricaoSet'
ALTER TABLE [dbo].[InscricaoSet]
ADD CONSTRAINT [FK_EventoInscricao]
    FOREIGN KEY ([EventoNrEvento])
    REFERENCES [dbo].[EventoSet]
        ([NrEvento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EventoInscricao'
CREATE INDEX [IX_FK_EventoInscricao]
ON [dbo].[InscricaoSet]
    ([EventoNrEvento]);
GO

-- Creating foreign key on [IdAnimador] in table 'ColaboracaoSet'
ALTER TABLE [dbo].[ColaboracaoSet]
ADD CONSTRAINT [FK_AnimadorColaboracao]
    FOREIGN KEY ([IdAnimador])
    REFERENCES [dbo].[PessoaSet_Animador]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [NrEvento] in table 'ColaboracaoSet'
ALTER TABLE [dbo].[ColaboracaoSet]
ADD CONSTRAINT [FK_EventoColaboracao]
    FOREIGN KEY ([NrEvento])
    REFERENCES [dbo].[EventoSet]
        ([NrEvento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EventoColaboracao'
CREATE INDEX [IX_FK_EventoColaboracao]
ON [dbo].[ColaboracaoSet]
    ([NrEvento]);
GO

-- Creating foreign key on [IdEscola] in table 'ParticipacaoSet'
ALTER TABLE [dbo].[ParticipacaoSet]
ADD CONSTRAINT [FK_EscolaParticipacao]
    FOREIGN KEY ([IdEscola])
    REFERENCES [dbo].[EscolaSet]
        ([IdEscola])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [NrEvento] in table 'ParticipacaoSet'
ALTER TABLE [dbo].[ParticipacaoSet]
ADD CONSTRAINT [FK_EventoParticipacao]
    FOREIGN KEY ([NrEvento])
    REFERENCES [dbo].[EventoSet]
        ([NrEvento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EventoParticipacao'
CREATE INDEX [IX_FK_EventoParticipacao]
ON [dbo].[ParticipacaoSet]
    ([NrEvento]);
GO

-- Creating foreign key on [IdPessoa] in table 'PessoaSet_Cliente'
ALTER TABLE [dbo].[PessoaSet_Cliente]
ADD CONSTRAINT [FK_Cliente_inherits_Pessoa]
    FOREIGN KEY ([IdPessoa])
    REFERENCES [dbo].[PessoaSet]
        ([IdPessoa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdPessoa] in table 'PessoaSet_Filho'
ALTER TABLE [dbo].[PessoaSet_Filho]
ADD CONSTRAINT [FK_Filho_inherits_Pessoa]
    FOREIGN KEY ([IdPessoa])
    REFERENCES [dbo].[PessoaSet]
        ([IdPessoa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdPessoa] in table 'PessoaSet_Animador'
ALTER TABLE [dbo].[PessoaSet_Animador]
ADD CONSTRAINT [FK_Animador_inherits_Pessoa]
    FOREIGN KEY ([IdPessoa])
    REFERENCES [dbo].[PessoaSet]
        ([IdPessoa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------