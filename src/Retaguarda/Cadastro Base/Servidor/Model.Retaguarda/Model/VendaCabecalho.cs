namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.venda_cabecalho")]
    public partial class VendaCabecalho
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VendaCabecalho()
        {
            nfe_cabecalho = new HashSet<NFe_Cabecalho>();
            venda_comissao = new HashSet<VendaComissao>();
            venda_detalhe = new HashSet<VendaDetalhe>();
            venda_frete = new HashSet<VendaFrete>();
        }

        public int id { get; set; }

        public int id_empresa { get; set; }

        public int? id_venda_romaneio_entrega { get; set; }

        public int? id_venda_orcamento_cabecalho { get; set; }

        public int id_venda_condicoes_pagamento { get; set; }

        public int? id_transportadora { get; set; }

        public int id_tipo_nota_fiscal { get; set; }

        public int id_cliente { get; set; }

        public int id_vendedor { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_venda { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_saida { get; set; }

        [StringLength(8)]
        public string hora_saida { get; set; }

        public int? numero_fatura { get; set; }

        [StringLength(100)]
        public string local_entrega { get; set; }

        [StringLength(100)]
        public string local_cobranca { get; set; }

        public decimal? valor_subtotal { get; set; }

        public decimal? taxa_comissao { get; set; }

        public decimal? valor_comissao { get; set; }

        public decimal? taxa_desconto { get; set; }

        public decimal? valor_desconto { get; set; }

        public decimal? valor_total { get; set; }

        [StringLength(1)]
        public string tipo_frete { get; set; }

        [StringLength(1)]
        public string forma_pagamento { get; set; }

        public decimal? valor_frete { get; set; }

        public decimal? valor_seguro { get; set; }

        public string observacao { get; set; }

        [StringLength(1)]
        public string situacao { get; set; }

        public virtual Cliente cliente { get; set; }

        public virtual Empresa empresa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_Cabecalho> nfe_cabecalho { get; set; }

        public virtual NotaFiscalTipo nota_fiscal_tipo { get; set; }

        public virtual Transportadora transportadora { get; set; }

        public virtual VendaCondicoesPagamento venda_condicoes_pagamento { get; set; }

        public virtual VendaOrcamentoCabecalho venda_orcamento_cabecalho { get; set; }

        public virtual VendaRomaneioEntrega venda_romaneio_entrega { get; set; }

        public virtual Vendedor vendedor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendaComissao> venda_comissao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendaDetalhe> venda_detalhe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendaFrete> venda_frete { get; set; }
    }
}
