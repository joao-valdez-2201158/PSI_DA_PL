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
    
    public partial class Filho : Pessoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Filho()
        {
            this.Inscricao = new HashSet<Inscricao>();
        }
    
        public string Sexo { get; set; }
        public string DataNascimento { get; set; }
        public string IdEscola { get; set; }
        public string IdProgenitor { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inscricao> Inscricao { get; set; }
        public virtual Escola Escolas { get; set; }
    }
}