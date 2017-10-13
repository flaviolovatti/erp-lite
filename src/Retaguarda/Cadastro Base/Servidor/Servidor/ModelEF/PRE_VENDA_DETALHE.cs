namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRE_VENDA_DETALHE
    {
        public int ID { get; set; }

        public int ID_PRODUTO { get; set; }

        public int ID_PRE_VENDA_CABECALHO { get; set; }

        public int? ITEM { get; set; }

        public decimal? QUANTIDADE { get; set; }

        public decimal? VALOR_UNITARIO { get; set; }

        public decimal? VALOR_TOTAL { get; set; }

        [StringLength(1)]
        public string CANCELADO { get; set; }

        [StringLength(14)]
        public string GTIN_PRODUTO { get; set; }

        [StringLength(100)]
        public string NOME_PRODUTO { get; set; }

        [StringLength(10)]
        public string UNIDADE_PRODUTO { get; set; }

        [StringLength(4)]
        public string ECF_ICMS_ST { get; set; }

        public virtual PRE_VENDA_CABECALHO PRE_VENDA_CABECALHO { get; set; }

        public virtual PRODUTO PRODUTO { get; set; }
    }
}
