namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TRIBUT_ICMS_CUSTOM_DET
    {
        public int ID { get; set; }

        public int ID_TRIBUT_ICMS_CUSTOM_CAB { get; set; }

        [StringLength(2)]
        public string UF_DESTINO { get; set; }

        public int? CFOP { get; set; }

        [StringLength(3)]
        public string CSOSN_B { get; set; }

        [StringLength(2)]
        public string CST_B { get; set; }

        [StringLength(1)]
        public string MODALIDADE_BC { get; set; }

        public decimal? ALIQUOTA { get; set; }

        public decimal? VALOR_PAUTA { get; set; }

        public decimal? VALOR_PRECO_MAXIMO { get; set; }

        public decimal? MVA { get; set; }

        public decimal? PORCENTO_BC { get; set; }

        [StringLength(1)]
        public string MODALIDADE_BC_ST { get; set; }

        public decimal? ALIQUOTA_INTERNA_ST { get; set; }

        public decimal? ALIQUOTA_INTERESTADUAL_ST { get; set; }

        public decimal? PORCENTO_BC_ST { get; set; }

        public decimal? ALIQUOTA_ICMS_ST { get; set; }

        public decimal? VALOR_PAUTA_ST { get; set; }

        public decimal? VALOR_PRECO_MAXIMO_ST { get; set; }

        public virtual TRIBUT_ICMS_CUSTOM_CAB TRIBUT_ICMS_CUSTOM_CAB { get; set; }
    }
}
