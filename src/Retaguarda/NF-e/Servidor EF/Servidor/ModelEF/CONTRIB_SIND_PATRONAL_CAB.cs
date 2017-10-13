namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CONTRIB_SIND_PATRONAL_CAB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CONTRIB_SIND_PATRONAL_CAB()
        {
            CONTRIB_SIND_PATRONAL_DET = new HashSet<CONTRIB_SIND_PATRONAL_DET>();
        }

        public int ID { get; set; }

        public int ID_SINDICATO { get; set; }

        [StringLength(4)]
        public string VIGENCIA_ANO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTRIB_SIND_PATRONAL_DET> CONTRIB_SIND_PATRONAL_DET { get; set; }

        public virtual SINDICATO SINDICATO { get; set; }
    }
}
