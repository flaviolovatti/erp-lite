namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TRIBUT_ISS
    {
        public int ID { get; set; }

        public int ID_TRIBUT_OPERACAO_FISCAL { get; set; }

        [StringLength(1)]
        public string MODALIDADE_BASE_CALCULO { get; set; }

        public decimal? PORCENTO_BASE_CALCULO { get; set; }

        public decimal? ALIQUOTA_PORCENTO { get; set; }

        public decimal? ALIQUOTA_UNIDADE { get; set; }

        public decimal? VALOR_PRECO_MAXIMO { get; set; }

        public decimal? VALOR_PAUTA_FISCAL { get; set; }

        public int? ITEM_LISTA_SERVICO { get; set; }

        [StringLength(1)]
        public string CODIGO_TRIBUTACAO { get; set; }

        public virtual TRIBUT_OPERACAO_FISCAL TRIBUT_OPERACAO_FISCAL { get; set; }
    }
}
