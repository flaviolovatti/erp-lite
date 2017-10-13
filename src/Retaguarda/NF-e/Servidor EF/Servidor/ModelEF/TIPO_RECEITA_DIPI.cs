namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TIPO_RECEITA_DIPI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPO_RECEITA_DIPI()
        {
            TRIBUT_IPI_DIPI = new HashSet<TRIBUT_IPI_DIPI>();
        }

        public int ID { get; set; }

        [StringLength(100)]
        public string DESCRICAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRIBUT_IPI_DIPI> TRIBUT_IPI_DIPI { get; set; }
    }
}
