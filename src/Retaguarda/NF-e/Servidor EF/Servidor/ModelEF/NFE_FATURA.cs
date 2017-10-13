namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFE_FATURA
    {
        public int ID { get; set; }

        public int ID_NFE_CABECALHO { get; set; }

        [StringLength(60)]
        public string NUMERO { get; set; }

        public decimal? VALOR_ORIGINAL { get; set; }

        public decimal? VALOR_DESCONTO { get; set; }

        public decimal? VALOR_LIQUIDO { get; set; }

        public virtual NFE_CABECALHO NFE_CABECALHO { get; set; }
    }
}
