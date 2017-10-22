namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfce_caixa")]
    public partial class nfce_caixa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public nfce_caixa()
        {
            nfce_configuracao = new HashSet<nfce_configuracao>();
            nfce_movimento = new HashSet<nfce_movimento>();
        }

        public int id { get; set; }

        [StringLength(30)]
        public string nome { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_cadastro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nfce_configuracao> nfce_configuracao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nfce_movimento> nfce_movimento { get; set; }
    }
}
