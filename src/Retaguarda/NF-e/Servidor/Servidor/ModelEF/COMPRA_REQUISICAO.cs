namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class COMPRA_REQUISICAO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COMPRA_REQUISICAO()
        {
            COMPRA_REQUISICAO_DETALHE = new HashSet<COMPRA_REQUISICAO_DETALHE>();
        }

        public int ID { get; set; }

        public int ID_COMPRA_TIPO_REQUISICAO { get; set; }

        public int ID_COLABORADOR { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_REQUISICAO { get; set; }

        [Column(TypeName = "text")]
        public string OBSERVACAO { get; set; }

        public virtual COLABORADOR COLABORADOR { get; set; }

        public virtual COMPRA_TIPO_REQUISICAO COMPRA_TIPO_REQUISICAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRA_REQUISICAO_DETALHE> COMPRA_REQUISICAO_DETALHE { get; set; }
    }
}
