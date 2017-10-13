namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRODUTO_COMBO_ITEM
    {
        public int ID { get; set; }

        public int ID_PRODUTO_COMBO { get; set; }

        public int ID_PRODUTO { get; set; }

        public decimal? TAXA_DESCONTO { get; set; }

        public virtual PRODUTO PRODUTO { get; set; }

        public virtual PRODUTO_COMBO PRODUTO_COMBO { get; set; }
    }
}
