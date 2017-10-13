namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class COMPRA_PEDIDO_DETALHE
    {
        public int ID { get; set; }

        public int ID_COMPRA_PEDIDO { get; set; }

        public int ID_PRODUTO { get; set; }

        public decimal? QUANTIDADE { get; set; }

        public decimal? VALOR_UNITARIO { get; set; }

        public decimal? VALOR_SUBTOTAL { get; set; }

        public decimal? TAXA_DESCONTO { get; set; }

        public decimal? VALOR_DESCONTO { get; set; }

        public decimal? VALOR_TOTAL { get; set; }

        [StringLength(3)]
        public string CST_CSOSN { get; set; }

        public int? CFOP { get; set; }

        public decimal? BASE_CALCULO_ICMS { get; set; }

        public decimal? VALOR_ICMS { get; set; }

        public decimal? VALOR_IPI { get; set; }

        public decimal? ALIQUOTA_ICMS { get; set; }

        public decimal? ALIQUOTA_IPI { get; set; }

        public virtual COMPRA_PEDIDO COMPRA_PEDIDO { get; set; }

        public virtual PRODUTO PRODUTO { get; set; }
    }
}
