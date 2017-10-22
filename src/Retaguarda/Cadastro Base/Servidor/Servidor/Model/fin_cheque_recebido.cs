namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.fin_cheque_recebido")]
    public partial class fin_cheque_recebido
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public fin_cheque_recebido()
        {
            fin_parcela_recebimento = new HashSet<fin_parcela_recebimento>();
        }

        public int id { get; set; }

        public int id_conta_caixa { get; set; }

        public int? id_pessoa { get; set; }

        [StringLength(14)]
        public string cpf_cnpj { get; set; }

        [StringLength(100)]
        public string nome { get; set; }

        [StringLength(10)]
        public string codigo_banco { get; set; }

        [StringLength(10)]
        public string codigo_agencia { get; set; }

        [StringLength(20)]
        public string conta { get; set; }

        public int? numero { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_emissao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? bom_para { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_compensacao { get; set; }

        public decimal? valor { get; set; }

        [Column(TypeName = "date")]
        public DateTime? custodia_data { get; set; }

        public decimal? custodia_tarifa { get; set; }

        public decimal? custodia_comissao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? desconto_data { get; set; }

        public decimal? desconto_tarifa { get; set; }

        public decimal? desconto_comissao { get; set; }

        public decimal? valor_recebido { get; set; }

        public virtual conta_caixa conta_caixa { get; set; }

        public virtual Pessoa pessoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fin_parcela_recebimento> fin_parcela_recebimento { get; set; }
    }
}
