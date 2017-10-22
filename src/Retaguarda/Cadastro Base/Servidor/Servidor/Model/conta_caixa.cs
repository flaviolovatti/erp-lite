namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.conta_caixa")]
    public partial class conta_caixa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public conta_caixa()
        {
            fin_cheque_recebido = new HashSet<fin_cheque_recebido>();
            fin_configuracao_boleto = new HashSet<fin_configuracao_boleto>();
            fin_extrato_conta_banco = new HashSet<fin_extrato_conta_banco>();
            fin_fechamento_caixa_banco = new HashSet<fin_fechamento_caixa_banco>();
            fin_parcela_pagamento = new HashSet<fin_parcela_pagamento>();
            fin_parcela_pagar = new HashSet<fin_parcela_pagar>();
            fin_parcela_receber = new HashSet<fin_parcela_receber>();
            fin_parcela_recebimento = new HashSet<fin_parcela_recebimento>();
            fin_tipo_recebimento = new HashSet<fin_tipo_recebimento>();
            operadora_cartao = new HashSet<operadora_cartao>();
            talonario_cheque = new HashSet<talonario_cheque>();
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

        public virtual agencia_banco agencia_banco { get; set; }

        public virtual Empresa empresa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fin_cheque_recebido> fin_cheque_recebido { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fin_configuracao_boleto> fin_configuracao_boleto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fin_extrato_conta_banco> fin_extrato_conta_banco { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fin_fechamento_caixa_banco> fin_fechamento_caixa_banco { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fin_parcela_pagamento> fin_parcela_pagamento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fin_parcela_pagar> fin_parcela_pagar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fin_parcela_receber> fin_parcela_receber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fin_parcela_recebimento> fin_parcela_recebimento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fin_tipo_recebimento> fin_tipo_recebimento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<operadora_cartao> operadora_cartao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<talonario_cheque> talonario_cheque { get; set; }
    }
}
