namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfce_caixa")]
    public partial class NFCe_Caixa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NFCe_Caixa()
        {
            nfce_configuracao = new HashSet<NFCe_Configuracao>();
            nfce_movimento = new HashSet<NFCe_Movimento>();
        }

        public int id { get; set; }

        [StringLength(30)]
        public string nome { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_cadastro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFCe_Configuracao> nfce_configuracao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFCe_Movimento> nfce_movimento { get; set; }
    }
}
