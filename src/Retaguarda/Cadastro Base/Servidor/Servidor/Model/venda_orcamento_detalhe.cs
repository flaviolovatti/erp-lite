namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.venda_orcamento_detalhe")]
    public partial class venda_orcamento_detalhe
    {
        public int id { get; set; }

        public int id_venda_orcamento_cabecalho { get; set; }

        public int id_produto { get; set; }

        public decimal? quantidade { get; set; }

        public decimal? valor_unitario { get; set; }

        public decimal? valor_subtotal { get; set; }

        public decimal? taxa_desconto { get; set; }

        public decimal? valor_desconto { get; set; }

        public decimal? valor_total { get; set; }

        public virtual Produto produto { get; set; }

        public virtual venda_orcamento_cabecalho venda_orcamento_cabecalho { get; set; }
    }
}
