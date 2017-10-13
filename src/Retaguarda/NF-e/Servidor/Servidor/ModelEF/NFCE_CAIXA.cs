namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFCE_CAIXA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NFCE_CAIXA()
        {
            NFCE_CONFIGURACAO = new HashSet<NFCE_CONFIGURACAO>();
            NFCE_MOVIMENTO = new HashSet<NFCE_MOVIMENTO>();
        }

        public int ID { get; set; }

        [StringLength(30)]
        public string NOME { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_CADASTRO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFCE_CONFIGURACAO> NFCE_CONFIGURACAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFCE_MOVIMENTO> NFCE_MOVIMENTO { get; set; }
    }
}
