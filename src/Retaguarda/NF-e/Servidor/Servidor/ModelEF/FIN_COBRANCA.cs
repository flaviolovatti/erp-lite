namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FIN_COBRANCA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FIN_COBRANCA()
        {
            FIN_COBRANCA_PARCELA_RECEBER = new HashSet<FIN_COBRANCA_PARCELA_RECEBER>();
        }

        public int ID { get; set; }

        public int ID_CLIENTE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_CONTATO { get; set; }

        [StringLength(8)]
        public string HORA_CONTATO { get; set; }

        [StringLength(14)]
        public string TELEFONE_CONTATO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_ACERTO_PAGAMENTO { get; set; }

        public decimal? TOTAL_RECEBER_NA_DATA { get; set; }

        public virtual CLIENTE CLIENTE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_COBRANCA_PARCELA_RECEBER> FIN_COBRANCA_PARCELA_RECEBER { get; set; }
    }
}
