namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.venda_orcamento_cabecalho")]
    public partial class VendaOrcamentoCabecalho
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VendaOrcamentoCabecalho()
        {
            venda_cabecalho = new HashSet<VendaCabecalho>();
            venda_orcamento_detalhe = new HashSet<VendaOrcamentoDetalhe>();
        }

        public int id { get; set; }

        public int id_empresa { get; set; }

        public int id_venda_condicoes_pagamento { get; set; }

        public int id_vendedor { get; set; }

        public int? id_transportadora { get; set; }

        public int id_cliente { get; set; }

        [StringLength(1)]
        public string tipo { get; set; }

        [StringLength(20)]
        public string codigo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_cadastro { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_entrega { get; set; }

        [Column(TypeName = "date")]
        public DateTime? validade { get; set; }

        [StringLength(1)]
        public string tipo_frete { get; set; }

        public decimal? valor_subtotal { get; set; }

        public decimal? valor_frete { get; set; }

        public decimal? taxa_comissao { get; set; }

        public decimal? valor_comissao { get; set; }

        public decimal? taxa_desconto { get; set; }

        public decimal? valor_desconto { get; set; }

        public decimal? valor_total { get; set; }

        public string observacao { get; set; }

        [StringLength(1)]
        public string situacao { get; set; }

        public virtual Cliente cliente { get; set; }

        public virtual Empresa empresa { get; set; }

        public virtual Transportadora transportadora { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendaCabecalho> venda_cabecalho { get; set; }

        public virtual VendaCondicoesPagamento venda_condicoes_pagamento { get; set; }

        public virtual Vendedor vendedor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendaOrcamentoDetalhe> venda_orcamento_detalhe { get; set; }
    }
}
