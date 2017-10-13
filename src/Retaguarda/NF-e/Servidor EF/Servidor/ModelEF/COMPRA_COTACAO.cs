namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class COMPRA_COTACAO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COMPRA_COTACAO()
        {
            COMPRA_FORNECEDOR_COTACAO = new HashSet<COMPRA_FORNECEDOR_COTACAO>();
            COMPRA_REQ_COTACAO_DETALHE = new HashSet<COMPRA_REQ_COTACAO_DETALHE>();
        }

        public int ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_COTACAO { get; set; }

        [StringLength(100)]
        public string DESCRICAO { get; set; }

        [StringLength(1)]
        public string SITUACAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRA_FORNECEDOR_COTACAO> COMPRA_FORNECEDOR_COTACAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRA_REQ_COTACAO_DETALHE> COMPRA_REQ_COTACAO_DETALHE { get; set; }
    }
}
