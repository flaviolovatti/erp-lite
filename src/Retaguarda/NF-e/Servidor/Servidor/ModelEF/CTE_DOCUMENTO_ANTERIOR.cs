namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CTE_DOCUMENTO_ANTERIOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CTE_DOCUMENTO_ANTERIOR()
        {
            CTE_DOCUMENTO_ANTERIOR_ID = new HashSet<CTE_DOCUMENTO_ANTERIOR_ID>();
        }

        public int ID { get; set; }

        public int ID_CTE_CABECALHO { get; set; }

        [StringLength(14)]
        public string CNPJ { get; set; }

        public int? CPF { get; set; }

        [StringLength(20)]
        public string IE { get; set; }

        [StringLength(2)]
        public string UF { get; set; }

        [StringLength(60)]
        public string NOME { get; set; }

        public virtual CTE_CABECALHO CTE_CABECALHO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTE_DOCUMENTO_ANTERIOR_ID> CTE_DOCUMENTO_ANTERIOR_ID { get; set; }
    }
}
