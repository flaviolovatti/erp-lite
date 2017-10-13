namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHEQUE")]
    public partial class CHEQUE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHEQUE()
        {
            FIN_CHEQUE_EMITIDO = new HashSet<FIN_CHEQUE_EMITIDO>();
        }

        public int ID { get; set; }

        public int ID_TALONARIO_CHEQUE { get; set; }

        public int? NUMERO { get; set; }

        [StringLength(1)]
        public string STATUS_CHEQUE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_STATUS { get; set; }

        public virtual TALONARIO_CHEQUE TALONARIO_CHEQUE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_CHEQUE_EMITIDO> FIN_CHEQUE_EMITIDO { get; set; }
    }
}
