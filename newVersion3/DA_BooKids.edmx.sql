
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/31/2021 20:35:47
-- Generated from EDMX file: C:\Users\2202418\Desktop\PSI_DA_PL\newVersion2\DA_BooKids.edmx
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

IF OBJECT_ID(N'[dbo].[FK_FilhoCliente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PessoaSet_Filho] DROP CONSTRAINT [FK_FilhoCliente];
GO
IF OBJECT_ID(N'[dbo].[FK_FilhoInscricao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InscricaoSet] DROP CONSTRAINT [FK_FilhoInscricao];
GO
IF OBJECT_ID(N'[dbo].[FK_FilhoEscola]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PessoaSet_Filho] DROP CONSTRAINT [FK_FilhoEscola];
GO
IF OBJECT_ID(N'[dbo].[FK_ProdutoTipoProduto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProdutoSet] DROP CONSTRAINT [FK_ProdutoTipoProduto];
GO
IF OBJECT_ID(N'[dbo].[FK_EventoInscricao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InscricaoSet] DROP CONSTRAINT [FK_EventoInscricao];
GO
IF OBJECT_ID(N'[dbo].[FK_EscolaParticipacao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ParticipacaoSet] DROP CONSTRAINT [FK_EscolaParticipacao];
GO
IF OBJECT_ID(N'[dbo].[FK_ParticipacaoEvento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ParticipacaoSet] DROP CONSTRAINT [FK_ParticipacaoEvento];
GO
IF OBJECT_ID(N'[dbo].[FK_DetalheCompraCompra]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetalheCompraSet] DROP CONSTRAINT [FK_DetalheCompraCompra];
GO
IF OBJECT_ID(N'[dbo].[FK_DetalheCompraProduto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetalheCompraSet] DROP CONSTRAINT [FK_DetalheCompraProduto];
GO
IF OBJECT_ID(N'[dbo].[FK_ClienteCompra]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CompraSet] DROP CONSTRAINT [FK_ClienteCompra];
GO
IF OBJECT_ID(N'[dbo].[FK_EventoColaboracao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ColaboracaoSet] DROP CONSTRAINT [FK_EventoColaboracao];
GO
IF OBJECT_ID(N'[dbo].[FK_AnimadorColaboracao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ColaboracaoSet] DROP CONSTRAINT [FK_AnimadorColaboracao];
GO
IF OBJECT_ID(N'[dbo].[FK_Filho_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PessoaSet_Filho] DROP CONSTRAINT [FK_Filho_inherits_Pessoa];
GO
IF OBJECT_ID(N'[dbo].[FK_Cliente_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PessoaSet_Cliente] DROP CONSTRAINT [FK_Cliente_inherits_Pessoa];
GO
IF OBJECT_ID(N'[dbo].[FK_Animador_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PessoaSet_Animador] DROP CONSTRAINT [FK_Animador_inherits_Pessoa];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[PessoaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PessoaSet];
GO
IF OBJECT_ID(N'[dbo].[CompraSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CompraSet];
GO
IF OBJECT_ID(N'[dbo].[InscricaoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[InscricaoSet];
GO
IF OBJECT_ID(N'[dbo].[EscolaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EscolaSet];
GO
IF OBJECT_ID(N'[dbo].[DetalheCompraSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DetalheCompraSet];
GO
IF OBJECT_ID(N'[dbo].[ProdutoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProdutoSet];
GO
IF OBJECT_ID(N'[dbo].[TipoProdutoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TipoProdutoSet];
GO
IF OBJECT_ID(N'[dbo].[EventoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EventoSet];
GO
IF OBJECT_ID(N'[dbo].[ParticipacaoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ParticipacaoSet];
GO
IF OBJECT_ID(N'[dbo].[ColaboracaoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ColaboracaoSet];
GO
IF OBJECT_ID(N'[dbo].[PessoaSet_Filho]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PessoaSet_Filho];
GO
IF OBJECT_ID(N'[dbo].[PessoaSet_Cliente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PessoaSet_Cliente];
GO
IF OBJECT_ID(N'[dbo].[PessoaSet_Animador]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PessoaSet_Animador];
GO

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
    [IdPessoa] int  NOT NULL
);
GO

-- Creating table 'InscricaoSet'
CREATE TABLE [dbo].[InscricaoSet] (
    [FilhoIdPessoa] int  NOT NULL,
    [EventoNrEvento] int  NOT NULL,
    [Confirmada] bit  NOT NULL
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
    [NrCompra] int  NOT NULL,
    [ProdutoCodProduto] int  NOT NULL
);
GO

-- Creating table 'ProdutoSet'
CREATE TABLE [dbo].[ProdutoSet] (
    [CodProduto] int IDENTITY(1,1) NOT NULL,
    [Designacao] nvarchar(max)  NOT NULL,
    [Preco] float  NOT NULL,
    [CodTipoProduto] int  NOT NULL,
    [StockExistente] nvarchar(max)  NOT NULL,
    [TipoProduto_CodTipoProduto] int  NOT NULL
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
    [NrEvento] int  NOT NULL,
    [AnimadorIdPessoa] int  NOT NULL
);
GO

-- Creating table 'PessoaSet_Filho'
CREATE TABLE [dbo].[PessoaSet_Filho] (
    [Sexo] nvarchar(max)  NOT NULL,
    [DataNascimento] datetime  NOT NULL,
    [IdEscola] int  NOT NULL,
    [IdProgenitor] int  NOT NULL,
    [IdPessoa] int  NOT NULL,
    [Clientes_IdPessoa] int  NOT NULL,
    [Escolas_IdEscola] int  NOT NULL
);
GO

-- Creating table 'PessoaSet_Cliente'
CREATE TABLE [dbo].[PessoaSet_Cliente] (
    [ValorOferta] float  NOT NULL,
    [NrCartao] int  NOT NULL,
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

-- Creating primary key on [NrCompra], [ProdutoCodProduto] in table 'DetalheCompraSet'
ALTER TABLE [dbo].[DetalheCompraSet]
ADD CONSTRAINT [PK_DetalheCompraSet]
    PRIMARY KEY CLUSTERED ([NrCompra], [ProdutoCodProduto] ASC);
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

-- Creating primary key on [NrEvento], [AnimadorIdPessoa] in table 'ColaboracaoSet'
ALTER TABLE [dbo].[ColaboracaoSet]
ADD CONSTRAINT [PK_ColaboracaoSet]
    PRIMARY KEY CLUSTERED ([NrEvento], [AnimadorIdPessoa] ASC);
GO

-- Creating primary key on [IdPessoa] in table 'PessoaSet_Filho'
ALTER TABLE [dbo].[PessoaSet_Filho]
ADD CONSTRAINT [PK_PessoaSet_Filho]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- Creating primary key on [IdPessoa] in table 'PessoaSet_Cliente'
ALTER TABLE [dbo].[PessoaSet_Cliente]
ADD CONSTRAINT [PK_PessoaSet_Cliente]
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

-- Creating foreign key on [Clientes_IdPessoa] in table 'PessoaSet_Filho'
ALTER TABLE [dbo].[PessoaSet_Filho]
ADD CONSTRAINT [FK_FilhoCliente]
    FOREIGN KEY ([Clientes_IdPessoa])
    REFERENCES [dbo].[PessoaSet_Cliente]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FilhoCliente'
CREATE INDEX [IX_FK_FilhoCliente]
ON [dbo].[PessoaSet_Filho]
    ([Clientes_IdPessoa]);
GO

-- Creating foreign key on [FilhoIdPessoa] in table 'InscricaoSet'
ALTER TABLE [dbo].[InscricaoSet]
ADD CONSTRAINT [FK_FilhoInscricao]
    FOREIGN KEY ([FilhoIdPessoa])
    REFERENCES [dbo].[PessoaSet_Filho]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Escolas_IdEscola] in table 'PessoaSet_Filho'
ALTER TABLE [dbo].[PessoaSet_Filho]
ADD CONSTRAINT [FK_FilhoEscola]
    FOREIGN KEY ([Escolas_IdEscola])
    REFERENCES [dbo].[EscolaSet]
        ([IdEscola])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FilhoEscola'
CREATE INDEX [IX_FK_FilhoEscola]
ON [dbo].[PessoaSet_Filho]
    ([Escolas_IdEscola]);
GO

-- Creating foreign key on [TipoProduto_CodTipoProduto] in table 'ProdutoSet'
ALTER TABLE [dbo].[ProdutoSet]
ADD CONSTRAINT [FK_ProdutoTipoProduto]
    FOREIGN KEY ([TipoProduto_CodTipoProduto])
    REFERENCES [dbo].[TipoProdutoSet]
        ([CodTipoProduto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProdutoTipoProduto'
CREATE INDEX [IX_FK_ProdutoTipoProduto]
ON [dbo].[ProdutoSet]
    ([TipoProduto_CodTipoProduto]);
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
ADD CONSTRAINT [FK_ParticipacaoEvento]
    FOREIGN KEY ([NrEvento])
    REFERENCES [dbo].[EventoSet]
        ([NrEvento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ParticipacaoEvento'
CREATE INDEX [IX_FK_ParticipacaoEvento]
ON [dbo].[ParticipacaoSet]
    ([NrEvento]);
GO

-- Creating foreign key on [NrCompra] in table 'DetalheCompraSet'
ALTER TABLE [dbo].[DetalheCompraSet]
ADD CONSTRAINT [FK_DetalheCompraCompra]
    FOREIGN KEY ([NrCompra])
    REFERENCES [dbo].[CompraSet]
        ([NrCompra])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ProdutoCodProduto] in table 'DetalheCompraSet'
ALTER TABLE [dbo].[DetalheCompraSet]
ADD CONSTRAINT [FK_DetalheCompraProduto]
    FOREIGN KEY ([ProdutoCodProduto])
    REFERENCES [dbo].[ProdutoSet]
        ([CodProduto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetalheCompraProduto'
CREATE INDEX [IX_FK_DetalheCompraProduto]
ON [dbo].[DetalheCompraSet]
    ([ProdutoCodProduto]);
GO

-- Creating foreign key on [IdPessoa] in table 'CompraSet'
ALTER TABLE [dbo].[CompraSet]
ADD CONSTRAINT [FK_ClienteCompra]
    FOREIGN KEY ([IdPessoa])
    REFERENCES [dbo].[PessoaSet_Cliente]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteCompra'
CREATE INDEX [IX_FK_ClienteCompra]
ON [dbo].[CompraSet]
    ([IdPessoa]);
GO

-- Creating foreign key on [NrEvento] in table 'ColaboracaoSet'
ALTER TABLE [dbo].[ColaboracaoSet]
ADD CONSTRAINT [FK_EventoColaboracao]
    FOREIGN KEY ([NrEvento])
    REFERENCES [dbo].[EventoSet]
        ([NrEvento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [AnimadorIdPessoa] in table 'ColaboracaoSet'
ALTER TABLE [dbo].[ColaboracaoSet]
ADD CONSTRAINT [FK_AnimadorColaboracao]
    FOREIGN KEY ([AnimadorIdPessoa])
    REFERENCES [dbo].[PessoaSet_Animador]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AnimadorColaboracao'
CREATE INDEX [IX_FK_AnimadorColaboracao]
ON [dbo].[ColaboracaoSet]
    ([AnimadorIdPessoa]);
GO

-- Creating foreign key on [IdPessoa] in table 'PessoaSet_Filho'
ALTER TABLE [dbo].[PessoaSet_Filho]
ADD CONSTRAINT [FK_Filho_inherits_Pessoa]
    FOREIGN KEY ([IdPessoa])
    REFERENCES [dbo].[PessoaSet]
        ([IdPessoa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdPessoa] in table 'PessoaSet_Cliente'
ALTER TABLE [dbo].[PessoaSet_Cliente]
ADD CONSTRAINT [FK_Cliente_inherits_Pessoa]
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