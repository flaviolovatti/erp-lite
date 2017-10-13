namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORNECEDOR_PRODUTO
    {
        public int ID { get; set; }

        public int ID_FORNECEDOR { get; set; }

        public int ID_PRODUTO { get; set; }

        [StringLength(20)]
        public string CODIGO_FORNECEDOR_PRODUTO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_ULTIMA_COMPRA { get; set; }

        public decimal? PRECO_ULTIMA_COMPRA { get; set; }

        public decimal? LOTE_MINIMO_COMPRA { get; set; }

        public decimal? MENOR_EMBALAGEM_COMPRA { get; set; }

        public decimal? CUSTO_ULTIMA_COMPRA { get; set; }

        public virtual FORNECEDOR FORNECEDOR { get; set; }

        public virtual PRODUTO PRODUTO { get; set; }
    }
}
