namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfce_tipo_pagamento")]
    public partial class NFCe_TipoPagamento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NFCe_TipoPagamento()
        {
            nfe_forma_pagamento = new HashSet<NFe_FormaPagamento>();
        }

        public int id { get; set; }

        [StringLength(2)]
        public string codigo { get; set; }

        [StringLength(20)]
        public string descricao { get; set; }

        [StringLength(1)]
        public string permite_troco { get; set; }

        [StringLength(1)]
        public string gera_parcelas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_FormaPagamento> nfe_forma_pagamento { get; set; }
    }
}
