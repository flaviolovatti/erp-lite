namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CTE_AQUAVIARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CTE_AQUAVIARIO()
        {
            CTE_AQUAVIARIO_BALSA = new HashSet<CTE_AQUAVIARIO_BALSA>();
        }

        public int ID { get; set; }

        public int ID_CTE_CABECALHO { get; set; }

        public decimal? VALOR_PRESTACAO { get; set; }

        public decimal? AFRMM { get; set; }

        [StringLength(10)]
        public string NUMERO_BOOKING { get; set; }

        [StringLength(10)]
        public string NUMERO_CONTROLE { get; set; }

        [StringLength(60)]
        public string ID_NAVIO { get; set; }

        public virtual CTE_CABECALHO CTE_CABECALHO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTE_AQUAVIARIO_BALSA> CTE_AQUAVIARIO_BALSA { get; set; }
    }
}
