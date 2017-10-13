namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VENDA_DETALHE
    {
        public int ID { get; set; }

        public int ID_PRODUTO { get; set; }

        public int ID_VENDA_CABECALHO { get; set; }

        public decimal? QUANTIDADE { get; set; }

        public decimal? VALOR_UNITARIO { get; set; }

        public decimal? VALOR_SUBTOTAL { get; set; }

        public decimal? TAXA_DESCONTO { get; set; }

        public decimal? VALOR_DESCONTO { get; set; }

        public decimal? VALOR_TOTAL { get; set; }

        public decimal? TAXA_COMISSAO { get; set; }

        public decimal? VALOR_COMISSAO { get; set; }

        public virtual PRODUTO PRODUTO { get; set; }

        public virtual VENDA_CABECALHO VENDA_CABECALHO { get; set; }
    }
}
