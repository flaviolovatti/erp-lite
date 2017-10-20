namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.conta_caixa")]
    public partial class ContaCaixa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContaCaixa()
        {
            fin_cheque_recebido = new HashSet<FIN_ChequeRecebido>();
            fin_configuracao_boleto = new HashSet<FIN_ConfiguracaoBoleto>();
            fin_extrato_conta_banco = new HashSet<FIN_ExtratoContaBanco>();
            fin_fechamento_caixa_banco = new HashSet<FIN_FechamentoCaixaBanco>();
            fin_parcela_pagamento = new HashSet<FIN_ParcelaPagamento>();
            fin_parcela_pagar = new HashSet<FIN_ParcelaPagar>();
            fin_parcela_receber = new HashSet<FIN_ParcelaReceber>();
            fin_parcela_recebimento = new HashSet<FIN_ParcelaRecebimento>();
            fin_tipo_recebimento = new HashSet<FIN_TipoRecebimento>();
            operadora_cartao = new HashSet<OperadoraCartao>();
            talonario_cheque = new HashSet<TalonarioCheque>();
        }

        public int id { get; set; }

        public int id_empresa { get; set; }

        public int? id_agencia_banco { get; set; }

        [StringLength(20)]
        public string codigo { get; set; }

        [StringLength(1)]
        public string digito { get; set; }

        [StringLength(50)]
        public string nome { get; set; }

        public string descricao { get; set; }

        [StringLength(1)]
        public string tipo { get; set; }

        public decimal? limite_credito { get; set; }

        [StringLength(30)]
        public string classificacao_contabil_conta { get; set; }

        public decimal? taxa_multa { get; set; }

        public decimal? taxa_juro { get; set; }

        public decimal? desconto_maximo_permitido { get; set; }

        public int? limite_cobranca_juro { get; set; }

        public virtual AgenciaBanco agencia_banco { get; set; }

        public virtual Empresa empresa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_ChequeRecebido> fin_cheque_recebido { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_ConfiguracaoBoleto> fin_configuracao_boleto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_ExtratoContaBanco> fin_extrato_conta_banco { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_FechamentoCaixaBanco> fin_fechamento_caixa_banco { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_ParcelaPagamento> fin_parcela_pagamento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_ParcelaPagar> fin_parcela_pagar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_ParcelaReceber> fin_parcela_receber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_ParcelaRecebimento> fin_parcela_recebimento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_TipoRecebimento> fin_tipo_recebimento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperadoraCartao> operadora_cartao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TalonarioCheque> talonario_cheque { get; set; }
    }
}
