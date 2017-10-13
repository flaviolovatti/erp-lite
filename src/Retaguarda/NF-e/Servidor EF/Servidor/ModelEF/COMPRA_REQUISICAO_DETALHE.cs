namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class COMPRA_REQUISICAO_DETALHE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COMPRA_REQUISICAO_DETALHE()
        {
            COMPRA_REQ_COTACAO_DETALHE = new HashSet<COMPRA_REQ_COTACAO_DETALHE>();
        }

        public int ID { get; set; }

        public int ID_COMPRA_REQUISICAO { get; set; }

        public int ID_PRODUTO { get; set; }

        public decimal? QUANTIDADE { get; set; }

        public decimal? QUANTIDADE_COTADA { get; set; }

        [StringLength(1)]
        public string ITEM_COTADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRA_REQ_COTACAO_DETALHE> COMPRA_REQ_COTACAO_DETALHE { get; set; }

        public virtual COMPRA_REQUISICAO COMPRA_REQUISICAO { get; set; }

        public virtual PRODUTO PRODUTO { get; set; }
    }
}
