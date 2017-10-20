namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.fin_parcela_pagar")]
    public partial class FIN_ParcelaPagar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FIN_ParcelaPagar()
        {
            fin_parcela_pagamento = new HashSet<FIN_ParcelaPagamento>();
        }

        public int id { get; set; }

        public int id_conta_caixa { get; set; }

        public int id_fin_lancamento_pagar { get; set; }

        public int id_fin_status_parcela { get; set; }

        public int? numero_parcela { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_emissao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_vencimento { get; set; }

        [Column(TypeName = "date")]
        public DateTime? desconto_ate { get; set; }

        [StringLength(1)]
        public string sofre_retencao { get; set; }

        public decimal? valor { get; set; }

        public decimal? taxa_juro { get; set; }

        public decimal? taxa_multa { get; set; }

        public decimal? taxa_desconto { get; set; }

        public decimal? valor_juro { get; set; }

        public decimal? valor_multa { get; set; }

        public decimal? valor_desconto { get; set; }

        public virtual ContaCaixa conta_caixa { get; set; }

        public virtual FIN_LancamentoPagar fin_lancamento_pagar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_ParcelaPagamento> fin_parcela_pagamento { get; set; }

        public virtual FIN_StatusParcela fin_status_parcela { get; set; }
    }
}
