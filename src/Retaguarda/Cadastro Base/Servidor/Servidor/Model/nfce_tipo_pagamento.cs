namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfce_tipo_pagamento")]
    public partial class nfce_tipo_pagamento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public nfce_tipo_pagamento()
        {
            nfe_forma_pagamento = new HashSet<nfe_forma_pagamento>();
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
        public virtual ICollection<nfe_forma_pagamento> nfe_forma_pagamento { get; set; }
    }
}
