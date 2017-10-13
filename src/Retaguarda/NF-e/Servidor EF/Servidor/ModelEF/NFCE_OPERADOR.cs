namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFCE_OPERADOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NFCE_OPERADOR()
        {
            NFCE_MOVIMENTO = new HashSet<NFCE_MOVIMENTO>();
        }

        public int ID { get; set; }

        [StringLength(20)]
        public string LOGIN { get; set; }

        [StringLength(20)]
        public string SENHA { get; set; }

        [StringLength(1)]
        public string NIVEL_AUTORIZACAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFCE_MOVIMENTO> NFCE_MOVIMENTO { get; set; }
    }
}
