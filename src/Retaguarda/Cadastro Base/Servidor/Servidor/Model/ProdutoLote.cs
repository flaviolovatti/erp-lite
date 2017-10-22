namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.produto_lote")]
    public partial class ProdutoLote
    {
        public int id { get; set; }

        public int id_nfe_cabecalho { get; set; }

        public int id_produto { get; set; }

        [StringLength(50)]
        public string codigo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_cadastro { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_compra { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_fabricacao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_validade { get; set; }

        public decimal? quantidade { get; set; }

        public decimal? preco_maximo_consumidor { get; set; }

        public string observacao { get; set; }

        public virtual nfe_cabecalho nfe_cabecalho { get; set; }

        public virtual Produto produto { get; set; }
    }
}
