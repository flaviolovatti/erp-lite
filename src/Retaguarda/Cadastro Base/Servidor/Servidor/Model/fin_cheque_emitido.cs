namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.fin_cheque_emitido")]
    public partial class fin_cheque_emitido
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public fin_cheque_emitido()
        {
            fin_parcela_pagamento = new HashSet<fin_parcela_pagamento>();
        }

        public int id { get; set; }

        public int id_cheque { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_emissao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? bom_para { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_compensacao { get; set; }

        public decimal? valor { get; set; }

        [StringLength(100)]
        public string nominal_a { get; set; }

        public virtual cheque cheque { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fin_parcela_pagamento> fin_parcela_pagamento { get; set; }
    }
}
