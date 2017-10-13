namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VENDA_COMISSAO
    {
        public int ID { get; set; }

        public int ID_VENDEDOR { get; set; }

        public int ID_VENDA_CABECALHO { get; set; }

        public decimal? VALOR_VENDA { get; set; }

        [StringLength(1)]
        public string TIPO_CONTABIL { get; set; }

        public decimal? VALOR_COMISSAO { get; set; }

        [StringLength(1)]
        public string SITUACAO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_LANCAMENTO { get; set; }

        public virtual VENDA_CABECALHO VENDA_CABECALHO { get; set; }

        public virtual VENDEDOR VENDEDOR { get; set; }
    }
}
