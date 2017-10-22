namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.compra_pedido_detalhe")]
    public partial class compra_pedido_detalhe
    {
        public int id { get; set; }

        public int id_compra_pedido { get; set; }

        public int id_produto { get; set; }

        public decimal? quantidade { get; set; }

        public decimal? valor_unitario { get; set; }

        public decimal? valor_subtotal { get; set; }

        public decimal? taxa_desconto { get; set; }

        public decimal? valor_desconto { get; set; }

        public decimal? valor_total { get; set; }

        [StringLength(3)]
        public string cst_csosn { get; set; }

        public int? cfop { get; set; }

        public decimal? base_calculo_icms { get; set; }

        public decimal? valor_icms { get; set; }

        public decimal? valor_ipi { get; set; }

        public decimal? aliquota_icms { get; set; }

        public decimal? aliquota_ipi { get; set; }

        public virtual compra_pedido compra_pedido { get; set; }

        public virtual Produto produto { get; set; }
    }
}
