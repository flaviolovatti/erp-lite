namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ESTOQUE_REAJUSTE_DETALHE
    {
        public int ID { get; set; }

        public int ID_ESTOQUE_REAJUSTE_CABECALHO { get; set; }

        public int ID_PRODUTO { get; set; }

        public decimal? VALOR_ORIGINAL { get; set; }

        public decimal? VALOR_REAJUSTE { get; set; }

        public decimal? QUANTIDADE_ORIGINAL { get; set; }

        public decimal? QUANTIDADE_REAJUSTE { get; set; }

        public virtual ESTOQUE_REAJUSTE_CABECALHO ESTOQUE_REAJUSTE_CABECALHO { get; set; }

        public virtual PRODUTO PRODUTO { get; set; }
    }
}
