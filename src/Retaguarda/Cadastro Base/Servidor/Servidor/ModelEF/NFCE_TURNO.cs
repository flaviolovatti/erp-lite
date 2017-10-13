namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFCE_TURNO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NFCE_TURNO()
        {
            NFCE_MOVIMENTO = new HashSet<NFCE_MOVIMENTO>();
        }

        public int ID { get; set; }

        [StringLength(10)]
        public string DESCRICAO { get; set; }

        [StringLength(8)]
        public string HORA_INICIO { get; set; }

        [StringLength(8)]
        public string HORA_FIM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFCE_MOVIMENTO> NFCE_MOVIMENTO { get; set; }
    }
}
