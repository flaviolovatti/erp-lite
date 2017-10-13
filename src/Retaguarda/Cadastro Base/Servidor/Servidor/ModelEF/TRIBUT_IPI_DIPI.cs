namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TRIBUT_IPI_DIPI
    {
        public int ID { get; set; }

        public int ID_TRIBUT_CONFIGURA_OF_GT { get; set; }

        public int? ID_TIPO_RECEITA_DIPI { get; set; }

        [StringLength(2)]
        public string CST_IPI { get; set; }

        [StringLength(1)]
        public string MODALIDADE_BASE_CALCULO { get; set; }

        public decimal? PORCENTO_BASE_CALCULO { get; set; }

        public decimal? ALIQUOTA_PORCENTO { get; set; }

        public decimal? ALIQUOTA_UNIDADE { get; set; }

        public decimal? VALOR_PRECO_MAXIMO { get; set; }

        public decimal? VALOR_PAUTA_FISCAL { get; set; }

        public virtual TIPO_RECEITA_DIPI TIPO_RECEITA_DIPI { get; set; }

        public virtual TRIBUT_CONFIGURA_OF_GT TRIBUT_CONFIGURA_OF_GT { get; set; }
    }
}
