namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NATUREZA_FINANCEIRA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NATUREZA_FINANCEIRA()
        {
            CT_RESULTADO_NT_FINANCEIRA = new HashSet<CT_RESULTADO_NT_FINANCEIRA>();
            FIN_LCTO_PAGAR_NT_FINANCEIRA = new HashSet<FIN_LCTO_PAGAR_NT_FINANCEIRA>();
            FIN_LCTO_RECEBER_NT_FINANCEIRA = new HashSet<FIN_LCTO_RECEBER_NT_FINANCEIRA>();
        }

        public int ID { get; set; }

        public int ID_PLANO_NATUREZA_FINANCEIRA { get; set; }

        [StringLength(30)]
        public string CLASSIFICACAO { get; set; }

        [StringLength(100)]
        public string DESCRICAO { get; set; }

        [StringLength(1)]
        public string TIPO { get; set; }

        [StringLength(250)]
        public string APLICACAO { get; set; }

        [StringLength(1)]
        public string APARECE_A_PAGAR { get; set; }

        [StringLength(1)]
        public string APARECE_A_RECEBER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_RESULTADO_NT_FINANCEIRA> CT_RESULTADO_NT_FINANCEIRA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_LCTO_PAGAR_NT_FINANCEIRA> FIN_LCTO_PAGAR_NT_FINANCEIRA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_LCTO_RECEBER_NT_FINANCEIRA> FIN_LCTO_RECEBER_NT_FINANCEIRA { get; set; }

        public virtual PLANO_NATUREZA_FINANCEIRA PLANO_NATUREZA_FINANCEIRA { get; set; }
    }
}
