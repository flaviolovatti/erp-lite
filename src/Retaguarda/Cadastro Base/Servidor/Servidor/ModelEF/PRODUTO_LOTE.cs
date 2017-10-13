namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRODUTO_LOTE
    {
        public int ID { get; set; }

        public int ID_NFE_CABECALHO { get; set; }

        public int ID_PRODUTO { get; set; }

        [StringLength(50)]
        public string CODIGO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_CADASTRO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_COMPRA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_FABRICACAO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_VALIDADE { get; set; }

        public decimal? QUANTIDADE { get; set; }

        public decimal? PRECO_MAXIMO_CONSUMIDOR { get; set; }

        [Column(TypeName = "text")]
        public string OBSERVACAO { get; set; }

        public virtual NFE_CABECALHO NFE_CABECALHO { get; set; }

        public virtual PRODUTO PRODUTO { get; set; }
    }
}
