namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ESTOQUE_REAJUSTE_CABECALHO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ESTOQUE_REAJUSTE_CABECALHO()
        {
            ESTOQUE_REAJUSTE_DETALHE = new HashSet<ESTOQUE_REAJUSTE_DETALHE>();
        }

        public int ID { get; set; }

        public int ID_COLABORADOR { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_REAJUSTE { get; set; }

        public decimal? PORCENTAGEM { get; set; }

        [StringLength(1)]
        public string TIPO_REAJUSTE { get; set; }

        [StringLength(100)]
        public string JUSTIFICATIVA { get; set; }

        public decimal? QUANTIDADE_FIXA { get; set; }

        [StringLength(1)]
        public string CAMPO_REAJUSTE { get; set; }

        public virtual COLABORADOR COLABORADOR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ESTOQUE_REAJUSTE_DETALHE> ESTOQUE_REAJUSTE_DETALHE { get; set; }
    }
}
