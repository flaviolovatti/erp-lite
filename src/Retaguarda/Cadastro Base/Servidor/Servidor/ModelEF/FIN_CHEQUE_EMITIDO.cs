namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FIN_CHEQUE_EMITIDO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FIN_CHEQUE_EMITIDO()
        {
            FIN_PARCELA_PAGAMENTO = new HashSet<FIN_PARCELA_PAGAMENTO>();
        }

        public int ID { get; set; }

        public int ID_CHEQUE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_EMISSAO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BOM_PARA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_COMPENSACAO { get; set; }

        public decimal? VALOR { get; set; }

        [StringLength(100)]
        public string NOMINAL_A { get; set; }

        public virtual CHEQUE CHEQUE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_PARCELA_PAGAMENTO> FIN_PARCELA_PAGAMENTO { get; set; }
    }
}
