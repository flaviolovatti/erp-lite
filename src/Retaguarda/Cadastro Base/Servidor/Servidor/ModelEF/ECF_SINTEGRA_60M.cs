namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ECF_SINTEGRA_60M
    {
        public int ID { get; set; }

        [StringLength(8)]
        public string NOME_CAIXA { get; set; }

        public int? ID_GERADO_CAIXA { get; set; }

        public int? ID_EMPRESA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_EMISSAO { get; set; }

        [StringLength(20)]
        public string NUMERO_SERIE_ECF { get; set; }

        public int? NUMERO_EQUIPAMENTO { get; set; }

        [StringLength(2)]
        public string MODELO_DOCUMENTO_FISCAL { get; set; }

        public int? COO_INICIAL { get; set; }

        public int? COO_FINAL { get; set; }

        public int? CRZ { get; set; }

        public int? CRO { get; set; }

        public decimal? VALOR_VENDA_BRUTA { get; set; }

        public decimal? VALOR_GRANDE_TOTAL { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_SINCRONIZACAO { get; set; }

        [StringLength(8)]
        public string HORA_SINCRONIZACAO { get; set; }
    }
}
