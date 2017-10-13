namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CTE_INFORMACAO_NF_CARGA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CTE_INFORMACAO_NF_CARGA()
        {
            CTE_INF_NF_CARGA_LACRE = new HashSet<CTE_INF_NF_CARGA_LACRE>();
        }

        public int ID { get; set; }

        public int ID_CTE_INFORMACAO_NF { get; set; }

        public int? TIPO_UNIDADE_CARGA { get; set; }

        [StringLength(20)]
        public string ID_UNIDADE_CARGA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTE_INF_NF_CARGA_LACRE> CTE_INF_NF_CARGA_LACRE { get; set; }

        public virtual CTE_INFORMACAO_NF_OUTROS CTE_INFORMACAO_NF_OUTROS { get; set; }
    }
}
