namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PLANO_NATUREZA_FINANCEIRA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PLANO_NATUREZA_FINANCEIRA()
        {
            NATUREZA_FINANCEIRA = new HashSet<NATUREZA_FINANCEIRA>();
        }

        public int ID { get; set; }

        public int ID_EMPRESA { get; set; }

        [StringLength(100)]
        public string NOME { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_INCLUSAO { get; set; }

        [StringLength(50)]
        public string MASCARA { get; set; }

        public int? NIVEIS { get; set; }

        public virtual EMPRESA EMPRESA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NATUREZA_FINANCEIRA> NATUREZA_FINANCEIRA { get; set; }
    }
}
