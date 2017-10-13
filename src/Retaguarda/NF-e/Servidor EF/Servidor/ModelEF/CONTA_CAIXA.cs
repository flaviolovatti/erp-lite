namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CONTA_CAIXA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CONTA_CAIXA()
        {
            FIN_CHEQUE_RECEBIDO = new HashSet<FIN_CHEQUE_RECEBIDO>();
            FIN_CONFIGURACAO_BOLETO = new HashSet<FIN_CONFIGURACAO_BOLETO>();
            FIN_EXTRATO_CONTA_BANCO = new HashSet<FIN_EXTRATO_CONTA_BANCO>();
            FIN_FECHAMENTO_CAIXA_BANCO = new HashSet<FIN_FECHAMENTO_CAIXA_BANCO>();
            FIN_PARCELA_PAGAR = new HashSet<FIN_PARCELA_PAGAR>();
            FIN_PARCELA_RECEBER = new HashSet<FIN_PARCELA_RECEBER>();
            FIN_PARCELA_RECEBIMENTO = new HashSet<FIN_PARCELA_RECEBIMENTO>();
            FIN_PARCELA_PAGAMENTO = new HashSet<FIN_PARCELA_PAGAMENTO>();
            FIN_TIPO_RECEBIMENTO = new HashSet<FIN_TIPO_RECEBIMENTO>();
            OPERADORA_CARTAO = new HashSet<OPERADORA_CARTAO>();
            TALONARIO_CHEQUE = new HashSet<TALONARIO_CHEQUE>();
        }

        public int ID { get; set; }

        public int ID_EMPRESA { get; set; }

        public int? ID_AGENCIA_BANCO { get; set; }

        [StringLength(20)]
        public string CODIGO { get; set; }

        [StringLength(1)]
        public string DIGITO { get; set; }

        [StringLength(50)]
        public string NOME { get; set; }

        [Column(TypeName = "text")]
        public string DESCRICAO { get; set; }

        [StringLength(1)]
        public string TIPO { get; set; }

        public decimal? LIMITE_CREDITO { get; set; }

        [StringLength(30)]
        public string CLASSIFICACAO_CONTABIL_CONTA { get; set; }

        public decimal? TAXA_MULTA { get; set; }

        public decimal? TAXA_JURO { get; set; }

        public decimal? DESCONTO_MAXIMO_PERMITIDO { get; set; }

        public int? LIMITE_COBRANCA_JURO { get; set; }

        public virtual AGENCIA_BANCO AGENCIA_BANCO { get; set; }

        public virtual EMPRESA EMPRESA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_CHEQUE_RECEBIDO> FIN_CHEQUE_RECEBIDO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_CONFIGURACAO_BOLETO> FIN_CONFIGURACAO_BOLETO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_EXTRATO_CONTA_BANCO> FIN_EXTRATO_CONTA_BANCO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_FECHAMENTO_CAIXA_BANCO> FIN_FECHAMENTO_CAIXA_BANCO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_PARCELA_PAGAR> FIN_PARCELA_PAGAR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_PARCELA_RECEBER> FIN_PARCELA_RECEBER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_PARCELA_RECEBIMENTO> FIN_PARCELA_RECEBIMENTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_PARCELA_PAGAMENTO> FIN_PARCELA_PAGAMENTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_TIPO_RECEBIMENTO> FIN_TIPO_RECEBIMENTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPERADORA_CARTAO> OPERADORA_CARTAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TALONARIO_CHEQUE> TALONARIO_CHEQUE { get; set; }
    }
}
