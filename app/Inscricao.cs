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
        public int FilhoIdPessoa { get; set; }
        public int EventoNrEvento { get; set; }
        public string Confirmada { get; set; }
    
        public virtual Filho Filho { get; set; }
        public virtual Evento Evento { get; set; }
    }
}