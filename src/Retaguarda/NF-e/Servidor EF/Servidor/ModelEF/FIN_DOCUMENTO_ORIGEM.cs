namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FIN_DOCUMENTO_ORIGEM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FIN_DOCUMENTO_ORIGEM()
        {
            FIN_LANCAMENTO_PAGAR = new HashSet<FIN_LANCAMENTO_PAGAR>();
            FIN_LANCAMENTO_RECEBER = new HashSet<FIN_LANCAMENTO_RECEBER>();
            FIN_PAGAMENTO_FIXO = new HashSet<FIN_PAGAMENTO_FIXO>();
        }

        public int ID { get; set; }

        public int ID_EMPRESA { get; set; }

        [StringLength(3)]
        public string CODIGO { get; set; }

        [StringLength(10)]
        public string SIGLA_DOCUMENTO { get; set; }

        [Column(TypeName = "text")]
        public string DESCRICAO { get; set; }

        public virtual EMPRESA EMPRESA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_LANCAMENTO_PAGAR> FIN_LANCAMENTO_PAGAR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_LANCAMENTO_RECEBER> FIN_LANCAMENTO_RECEBER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_PAGAMENTO_FIXO> FIN_PAGAMENTO_FIXO { get; set; }
    }
}
