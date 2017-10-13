namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFE_DET_ESPECIFICO_MEDICAMENTO
    {
        public int ID { get; set; }

        public int ID_NFE_DETALHE { get; set; }

        public decimal? PRECO_MAXIMO_CONSUMIDOR { get; set; }

        [StringLength(13)]
        public string CODIGO_PRODUTO_ANVISA { get; set; }

        public virtual NFE_DETALHE NFE_DETALHE { get; set; }
    }
}
