namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CENTRO_RESULTADO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CENTRO_RESULTADO()
        {
            CT_RESULTADO_NT_FINANCEIRA = new HashSet<CT_RESULTADO_NT_FINANCEIRA>();
        }

        public int ID { get; set; }

        public int ID_PLANO_CENTRO_RESULTADO { get; set; }

        [StringLength(30)]
        public string CLASSIFICACAO { get; set; }

        [StringLength(100)]
        public string DESCRICAO { get; set; }

        [StringLength(1)]
        public string SOFRE_RATEIRO { get; set; }

        public virtual PLANO_CENTRO_RESULTADO PLANO_CENTRO_RESULTADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_RESULTADO_NT_FINANCEIRA> CT_RESULTADO_NT_FINANCEIRA { get; set; }
    }
}
