namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DAV_DETALHE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DAV_DETALHE()
        {
            DAV_DETALHE_ALTERACAO = new HashSet<DAV_DETALHE_ALTERACAO>();
        }

        public int ID { get; set; }

        public int ID_PRODUTO { get; set; }

        public int ID_DAV_CABECALHO { get; set; }

        [StringLength(10)]
        public string NUMERO_DAV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_EMISSAO { get; set; }

        public int? ITEM { get; set; }

        public decimal? QUANTIDADE { get; set; }

        public decimal? VALOR_UNITARIO { get; set; }

        public decimal? VALOR_TOTAL { get; set; }

        [StringLength(1)]
        public string CANCELADO { get; set; }

        [StringLength(1)]
        public string MESCLA_PRODUTO { get; set; }

        [StringLength(14)]
        public string GTIN_PRODUTO { get; set; }

        [StringLength(100)]
        public string NOME_PRODUTO { get; set; }

        [StringLength(10)]
        public string UNIDADE_PRODUTO { get; set; }

        [StringLength(10)]
        public string TOTALIZADOR_PARCIAL { get; set; }

        [StringLength(32)]
        public string LOGSS { get; set; }

        [Column(TypeName = "text")]
        public string SERVICO_FORMULA { get; set; }

        public virtual DAV_CABECALHO DAV_CABECALHO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DAV_DETALHE_ALTERACAO> DAV_DETALHE_ALTERACAO { get; set; }

        public virtual PRODUTO PRODUTO { get; set; }
    }
}
