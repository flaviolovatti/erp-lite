namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.venda_comissao")]
    public partial class VendaComissao
    {
        public int id { get; set; }

        public int id_vendedor { get; set; }

        public int id_venda_cabecalho { get; set; }

        public decimal? valor_venda { get; set; }

        [StringLength(1)]
        public string tipo_contabil { get; set; }

        public decimal? valor_comissao { get; set; }

        [StringLength(1)]
        public string situacao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_lancamento { get; set; }

        public virtual VendaCabecalho venda_cabecalho { get; set; }

        public virtual Vendedor vendedor { get; set; }
    }
}
