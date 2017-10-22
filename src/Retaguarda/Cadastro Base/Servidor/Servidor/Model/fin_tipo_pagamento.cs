namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.fin_tipo_pagamento")]
    public partial class fin_tipo_pagamento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public fin_tipo_pagamento()
        {
            fin_parcela_pagamento = new HashSet<fin_parcela_pagamento>();
        }

        public int id { get; set; }

        public int id_empresa { get; set; }

        [StringLength(2)]
        public string tipo { get; set; }

        [StringLength(30)]
        public string descricao { get; set; }

        public virtual Empresa empresa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fin_parcela_pagamento> fin_parcela_pagamento { get; set; }
    }
}
