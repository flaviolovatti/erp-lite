namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFE_DETALHE_IMPOSTO_COFINS
    {
        public int ID { get; set; }

        public int ID_NFE_DETALHE { get; set; }

        [StringLength(2)]
        public string CST_COFINS { get; set; }

        public decimal? QUANTIDADE_VENDIDA { get; set; }

        public decimal? BASE_CALCULO_COFINS { get; set; }

        public decimal? ALIQUOTA_COFINS_PERCENTUAL { get; set; }

        public decimal? ALIQUOTA_COFINS_REAIS { get; set; }

        public decimal? VALOR_COFINS { get; set; }

        public virtual NFE_DETALHE NFE_DETALHE { get; set; }
    }
}
