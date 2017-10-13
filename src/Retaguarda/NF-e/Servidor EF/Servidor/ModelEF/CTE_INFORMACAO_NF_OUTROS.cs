namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CTE_INFORMACAO_NF_OUTROS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CTE_INFORMACAO_NF_OUTROS()
        {
            CTE_INFORMACAO_NF_CARGA = new HashSet<CTE_INFORMACAO_NF_CARGA>();
            CTE_INFORMACAO_NF_TRANSPORTE = new HashSet<CTE_INFORMACAO_NF_TRANSPORTE>();
        }

        public int ID { get; set; }

        public int ID_CTE_CABECALHO { get; set; }

        [StringLength(20)]
        public string NUMERO_ROMANEIO { get; set; }

        [StringLength(20)]
        public string NUMERO_PEDIDO { get; set; }

        [StringLength(44)]
        public string CHAVE_ACESSO_NFE { get; set; }

        [StringLength(2)]
        public string CODIGO_MODELO { get; set; }

        [StringLength(3)]
        public string SERIE { get; set; }

        [StringLength(20)]
        public string NUMERO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_EMISSAO { get; set; }

        public int? UF_EMITENTE { get; set; }

        public decimal? BASE_CALCULO_ICMS { get; set; }

        public decimal? VALOR_ICMS { get; set; }

        public decimal? BASE_CALCULO_ICMS_ST { get; set; }

        public decimal? VALOR_ICMS_ST { get; set; }

        public decimal? VALOR_TOTAL_PRODUTOS { get; set; }

        public decimal? VALOR_TOTAL { get; set; }

        public int? CFOP_PREDOMINANTE { get; set; }

        public decimal? PESO_TOTAL_KG { get; set; }

        public int? PIN_SUFRAMA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_PREVISTA_ENTREGA { get; set; }

        [StringLength(2)]
        public string OUTRO_TIPO_DOC_ORIG { get; set; }

        [StringLength(100)]
        public string OUTRO_DESCRICAO { get; set; }

        public decimal? OUTRO_VALOR_DOCUMENTO { get; set; }

        public virtual CTE_CABECALHO CTE_CABECALHO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTE_INFORMACAO_NF_CARGA> CTE_INFORMACAO_NF_CARGA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTE_INFORMACAO_NF_TRANSPORTE> CTE_INFORMACAO_NF_TRANSPORTE { get; set; }
    }
}
