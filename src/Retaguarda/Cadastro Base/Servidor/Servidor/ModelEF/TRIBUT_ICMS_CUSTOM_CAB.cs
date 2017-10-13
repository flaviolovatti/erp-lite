namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TRIBUT_ICMS_CUSTOM_CAB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TRIBUT_ICMS_CUSTOM_CAB()
        {
            PRODUTO = new HashSet<PRODUTO>();
            TRIBUT_ICMS_CUSTOM_DET = new HashSet<TRIBUT_ICMS_CUSTOM_DET>();
        }

        public int ID { get; set; }

        public int ID_EMPRESA { get; set; }

        [StringLength(100)]
        public string DESCRICAO { get; set; }

        [StringLength(1)]
        public string ORIGEM_MERCADORIA { get; set; }

        public virtual EMPRESA EMPRESA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUTO> PRODUTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRIBUT_ICMS_CUSTOM_DET> TRIBUT_ICMS_CUSTOM_DET { get; set; }
    }
}
