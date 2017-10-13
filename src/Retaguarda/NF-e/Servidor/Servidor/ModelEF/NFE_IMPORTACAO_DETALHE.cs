namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFE_IMPORTACAO_DETALHE
    {
        public int ID { get; set; }

        public int ID_NFE_DECLARACAO_IMPORTACAO { get; set; }

        public int? NUMERO_ADICAO { get; set; }

        public int? NUMERO_SEQUENCIAL { get; set; }

        [StringLength(60)]
        public string CODIGO_FABRICANTE_ESTRANGEIRO { get; set; }

        public decimal? VALOR_DESCONTO { get; set; }

        public int? DRAWBACK { get; set; }

        public virtual NFE_DECLARACAO_IMPORTACAO NFE_DECLARACAO_IMPORTACAO { get; set; }
    }
}
