namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFCE_TIPO_PAGAMENTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NFCE_TIPO_PAGAMENTO()
        {
            NFE_FORMA_PAGAMENTO = new HashSet<NFE_FORMA_PAGAMENTO>();
        }

        public int ID { get; set; }

        [StringLength(2)]
        public string CODIGO { get; set; }

        [StringLength(20)]
        public string DESCRICAO { get; set; }

        [StringLength(1)]
        public string PERMITE_TROCO { get; set; }

        [StringLength(1)]
        public string GERA_PARCELAS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_FORMA_PAGAMENTO> NFE_FORMA_PAGAMENTO { get; set; }
    }
}
