//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Inscricao
    {
        public bool Confirmada { get; set; }
        public int FilhoIdPessoa { get; set; }
        public int EventoNrEvento { get; set; }
    
        public virtual Filho Filhos { get; set; }
        public virtual Evento Eventos { get; set; }
    }
}