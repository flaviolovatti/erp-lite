namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FIN_CHEQUE_RECEBIDO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FIN_CHEQUE_RECEBIDO()
        {
            FIN_PARCELA_RECEBIMENTO = new HashSet<FIN_PARCELA_RECEBIMENTO>();
        }

        public int ID { get; set; }

        public int ID_CONTA_CAIXA { get; set; }

        public int? ID_PESSOA { get; set; }

        [StringLength(14)]
        public string CPF_CNPJ { get; set; }

        [StringLength(100)]
        public string NOME { get; set; }

        [StringLength(10)]
        public string CODIGO_BANCO { get; set; }

        [StringLength(10)]
        public string CODIGO_AGENCIA { get; set; }

        [StringLength(20)]
        public string CONTA { get; set; }

        public int? NUMERO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_EMISSAO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BOM_PARA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_COMPENSACAO { get; set; }

        public decimal? VALOR { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CUSTODIA_DATA { get; set; }

        public decimal? CUSTODIA_TARIFA { get; set; }

        public decimal? CUSTODIA_COMISSAO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DESCONTO_DATA { get; set; }

        public decimal? DESCONTO_TARIFA { get; set; }

        public decimal? DESCONTO_COMISSAO { get; set; }

        public decimal? VALOR_RECEBIDO { get; set; }

        public virtual CONTA_CAIXA CONTA_CAIXA { get; set; }

        public virtual PESSOA PESSOA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_PARCELA_RECEBIMENTO> FIN_PARCELA_RECEBIMENTO { get; set; }
    }
}
