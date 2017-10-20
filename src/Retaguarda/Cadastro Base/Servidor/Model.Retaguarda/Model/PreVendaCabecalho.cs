namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.pre_venda_cabecalho")]
    public partial class PreVendaCabecalho
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PreVendaCabecalho()
        {
            pre_venda_detalhe = new HashSet<PreVendaDetalhe>();
        }

        public int id { get; set; }

        public int id_empresa { get; set; }

        public int? id_pessoa { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_emissao { get; set; }

        [StringLength(8)]
        public string hora_emissao { get; set; }

        [StringLength(1)]
        public string situacao { get; set; }

        public int? ccf { get; set; }

        public decimal? valor { get; set; }

        [StringLength(100)]
        public string nome_destinatario { get; set; }

        [StringLength(14)]
        public string cpf_cnpj_destinatario { get; set; }

        public decimal? subtotal { get; set; }

        public decimal? desconto { get; set; }

        public decimal? acrescimo { get; set; }

        public decimal? taxa_acrescimo { get; set; }

        public decimal? taxa_desconto { get; set; }

        public virtual Empresa empresa { get; set; }

        public virtual Pessoa pessoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PreVendaDetalhe> pre_venda_detalhe { get; set; }
    }
}
