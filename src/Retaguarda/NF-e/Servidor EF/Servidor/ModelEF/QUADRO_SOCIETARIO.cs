namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class QUADRO_SOCIETARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QUADRO_SOCIETARIO()
        {
            SOCIO = new HashSet<SOCIO>();
        }

        public int ID { get; set; }

        public int ID_EMPRESA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_REGISTRO { get; set; }

        public decimal? CAPITAL_SOCIAL { get; set; }

        public decimal? VALOR_QUOTA { get; set; }

        public int? QUANTIDADE_COTAS { get; set; }

        public virtual EMPRESA EMPRESA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SOCIO> SOCIO { get; set; }
    }
}
