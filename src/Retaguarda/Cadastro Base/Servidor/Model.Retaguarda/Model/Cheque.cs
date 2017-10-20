namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cheque")]
    public partial class Cheque
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cheque()
        {
            fin_cheque_emitido = new HashSet<FIN_ChequeEmitido>();
        }

        public int id { get; set; }

        public int id_talonario_cheque { get; set; }

        public int? numero { get; set; }

        [StringLength(1)]
        public string status_cheque { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_status { get; set; }

        public virtual TalonarioCheque talonario_cheque { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_ChequeEmitido> fin_cheque_emitido { get; set; }
    }
}
