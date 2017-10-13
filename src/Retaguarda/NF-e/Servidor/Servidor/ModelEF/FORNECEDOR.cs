namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FORNECEDOR")]
    public partial class FORNECEDOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FORNECEDOR()
        {
            COMPRA_FORNECEDOR_COTACAO = new HashSet<COMPRA_FORNECEDOR_COTACAO>();
            COMPRA_PEDIDO = new HashSet<COMPRA_PEDIDO>();
            FIN_LANCAMENTO_PAGAR = new HashSet<FIN_LANCAMENTO_PAGAR>();
            FIN_PAGAMENTO_FIXO = new HashSet<FIN_PAGAMENTO_FIXO>();
            FORNECEDOR_PRODUTO = new HashSet<FORNECEDOR_PRODUTO>();
            NFE_CABECALHO = new HashSet<NFE_CABECALHO>();
        }

        public int ID { get; set; }

        public int ID_PESSOA { get; set; }

        public int ID_ATIVIDADE_FOR_CLI { get; set; }

        public int ID_SITUACAO_FOR_CLI { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DESDE { get; set; }

        [StringLength(1)]
        public string OPTANTE_SIMPLES_NACIONAL { get; set; }

        [StringLength(1)]
        public string LOCALIZACAO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_CADASTRO { get; set; }

        [StringLength(1)]
        public string SOFRE_RETENCAO { get; set; }

        [StringLength(100)]
        public string CHEQUE_NOMINAL_A { get; set; }

        [Column(TypeName = "text")]
        public string OBSERVACAO { get; set; }

        [StringLength(30)]
        public string CONTA_REMETENTE { get; set; }

        public int? PRAZO_MEDIO_ENTREGA { get; set; }

        [StringLength(1)]
        public string GERA_FATURAMENTO { get; set; }

        public int? NUM_DIAS_PRIMEIRO_VENCIMENTO { get; set; }

        public int? NUM_DIAS_INTERVALO { get; set; }

        public int? QUANTIDADE_PARCELAS { get; set; }

        [StringLength(30)]
        public string CLASSIFICACAO_CONTABIL_CONTA { get; set; }

        public virtual ATIVIDADE_FOR_CLI ATIVIDADE_FOR_CLI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRA_FORNECEDOR_COTACAO> COMPRA_FORNECEDOR_COTACAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRA_PEDIDO> COMPRA_PEDIDO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_LANCAMENTO_PAGAR> FIN_LANCAMENTO_PAGAR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_PAGAMENTO_FIXO> FIN_PAGAMENTO_FIXO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORNECEDOR_PRODUTO> FORNECEDOR_PRODUTO { get; set; }

        public virtual PESSOA PESSOA { get; set; }

        public virtual SITUACAO_FOR_CLI SITUACAO_FOR_CLI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_CABECALHO> NFE_CABECALHO { get; set; }
    }
}
