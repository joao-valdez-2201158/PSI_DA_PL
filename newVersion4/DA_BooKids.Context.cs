﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projeto_DA_BooKids
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DA_BooKidsContainer : DbContext
    {
        public DA_BooKidsContainer()
            : base("name=DA_BooKidsContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Pessoa> PessoaSet { get; set; }
        public virtual DbSet<Compra> CompraSet { get; set; }
        public virtual DbSet<Inscricao> InscricaoSet { get; set; }
        public virtual DbSet<Escola> EscolaSet { get; set; }
        public virtual DbSet<DetalheCompra> DetalheCompraSet { get; set; }
        public virtual DbSet<Produto> ProdutoSet { get; set; }
        public virtual DbSet<TipoProduto> TipoProdutoSet { get; set; }
        public virtual DbSet<Evento> EventoSet { get; set; }
        public virtual DbSet<Participacao> ParticipacaoSet { get; set; }
        public virtual DbSet<Colaboracao> ColaboracaoSet { get; set; }
    }
}