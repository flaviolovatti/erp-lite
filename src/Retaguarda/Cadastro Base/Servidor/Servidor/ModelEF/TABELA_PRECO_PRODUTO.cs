namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TABELA_PRECO_PRODUTO
    {
        public int ID { get; set; }

        public int ID_TABELA_PRECO { get; set; }

        public int ID_PRODUTO { get; set; }

        public decimal? PRECO { get; set; }

        public virtual PRODUTO PRODUTO { get; set; }

        public virtual TABELA_PRECO TABELA_PRECO { get; set; }
    }
}
