namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFE_CUPOM_FISCAL_REFERENCIADO
    {
        public int ID { get; set; }

        public int ID_NFE_CABECALHO { get; set; }

        [StringLength(2)]
        public string MODELO_DOCUMENTO_FISCAL { get; set; }

        public int? NUMERO_ORDEM_ECF { get; set; }

        public int? COO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_EMISSAO_CUPOM { get; set; }

        public int? NUMERO_CAIXA { get; set; }

        [StringLength(21)]
        public string NUMERO_SERIE_ECF { get; set; }

        public virtual NFE_CABECALHO NFE_CABECALHO { get; set; }
    }
}
