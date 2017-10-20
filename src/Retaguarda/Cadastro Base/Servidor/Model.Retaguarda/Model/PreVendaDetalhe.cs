namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.pre_venda_detalhe")]
    public partial class PreVendaDetalhe
    {
        public int id { get; set; }

        public int id_produto { get; set; }

        public int id_pre_venda_cabecalho { get; set; }

        public int? item { get; set; }

        public decimal? quantidade { get; set; }

        public decimal? valor_unitario { get; set; }

        public decimal? valor_total { get; set; }

        [StringLength(1)]
        public string cancelado { get; set; }

        [StringLength(14)]
        public string gtin_produto { get; set; }

        [StringLength(100)]
        public string nome_produto { get; set; }

        [StringLength(10)]
        public string unidade_produto { get; set; }

        [StringLength(4)]
        public string ecf_icms_st { get; set; }

        public virtual PreVendaCabecalho pre_venda_cabecalho { get; set; }

        public virtual Produto produto { get; set; }
    }
}
