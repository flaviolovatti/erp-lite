namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CNAE")]
    public partial class CNAE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CNAE()
        {
            EMPRESA_CNAE = new HashSet<EMPRESA_CNAE>();
        }

        public int ID { get; set; }

        [StringLength(7)]
        public string CODIGO { get; set; }

        [Column(TypeName = "text")]
        public string DENOMINACAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPRESA_CNAE> EMPRESA_CNAE { get; set; }
    }
}
