namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFE_DETALHE_IMPOSTO_II
    {
        public int ID { get; set; }

        public int ID_NFE_DETALHE { get; set; }

        public decimal? VALOR_BC_II { get; set; }

        public decimal? VALOR_DESPESAS_ADUANEIRAS { get; set; }

        public decimal? VALOR_IMPOSTO_IMPORTACAO { get; set; }

        public decimal? VALOR_IOF { get; set; }

        public virtual NFE_DETALHE NFE_DETALHE { get; set; }
    }
}
