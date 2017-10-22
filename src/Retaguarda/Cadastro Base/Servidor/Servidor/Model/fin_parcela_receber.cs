namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.fin_parcela_receber")]
    public partial class fin_parcela_receber
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public fin_parcela_receber()
        {
            fin_parcela_recebimento = new HashSet<fin_parcela_recebimento>();
        }

        public int id { get; set; }

        public int id_conta_caixa { get; set; }

        public int id_fin_lancamento_receber { get; set; }

        public int id_fin_status_parcela { get; set; }

        public int? numero_parcela { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_emissao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_vencimento { get; set; }

        [Column(TypeName = "date")]
        public DateTime? desconto_ate { get; set; }

        public decimal? valor { get; set; }

        public decimal? taxa_juro { get; set; }

        public decimal? taxa_multa { get; set; }

        public decimal? taxa_desconto { get; set; }

        public decimal? valor_juro { get; set; }

        public decimal? valor_multa { get; set; }

        public decimal? valor_desconto { get; set; }

        [StringLength(1)]
        public string emitiu_boleto { get; set; }

        [StringLength(50)]
        public string boleto_nosso_numero { get; set; }

        public virtual conta_caixa conta_caixa { get; set; }

        public virtual fin_lancamento_receber fin_lancamento_receber { get; set; }

        public virtual fin_status_parcela fin_status_parcela { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fin_parcela_recebimento> fin_parcela_recebimento { get; set; }
    }
}
