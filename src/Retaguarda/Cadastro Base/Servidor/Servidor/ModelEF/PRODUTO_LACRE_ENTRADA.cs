namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRODUTO_LACRE_ENTRADA
    {
        public int ID { get; set; }

        public int ID_PRODUTO { get; set; }

        public int ID_LACRE_PRODUTO { get; set; }

        public virtual PRODUTO PRODUTO { get; set; }

        public virtual PRODUTO_LACRE PRODUTO_LACRE { get; set; }
    }
}
