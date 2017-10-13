namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFE_DETALHE_IMPOSTO_ICMS
    {
        public int ID { get; set; }

        public int ID_NFE_DETALHE { get; set; }

        public int? ORIGEM_MERCADORIA { get; set; }

        [StringLength(2)]
        public string CST_ICMS { get; set; }

        [StringLength(3)]
        public string CSOSN { get; set; }

        public int? MODALIDADE_BC_ICMS { get; set; }

        public decimal? TAXA_REDUCAO_BC_ICMS { get; set; }

        public decimal? BASE_CALCULO_ICMS { get; set; }

        public decimal? ALIQUOTA_ICMS { get; set; }

        public decimal? VALOR_ICMS { get; set; }

        public decimal? VALOR_ICMS_OPERACAO { get; set; }

        public decimal? PERCENTUAL_DIFERIMENTO { get; set; }

        public decimal? VALOR_ICMS_DIFERIDO { get; set; }

        public int? MOTIVO_DESONERACAO_ICMS { get; set; }

        public decimal? VALOR_ICMS_DESONERADO { get; set; }

        public int? MODALIDADE_BC_ICMS_ST { get; set; }

        public decimal? PERCENTUAL_MVA_ICMS_ST { get; set; }

        public decimal? PERCENTUAL_REDUCAO_BC_ICMS_ST { get; set; }

        public decimal? VALOR_BASE_CALCULO_ICMS_ST { get; set; }

        public decimal? ALIQUOTA_ICMS_ST { get; set; }

        public decimal? VALOR_ICMS_ST { get; set; }

        public decimal? VALOR_BC_ICMS_ST_RETIDO { get; set; }

        public decimal? VALOR_ICMS_ST_RETIDO { get; set; }

        public decimal? VALOR_BC_ICMS_ST_DESTINO { get; set; }

        public decimal? VALOR_ICMS_ST_DESTINO { get; set; }

        public decimal? ALIQUOTA_CREDITO_ICMS_SN { get; set; }

        public decimal? VALOR_CREDITO_ICMS_SN { get; set; }

        public decimal? PERCENTUAL_BC_OPERACAO_PROPRIA { get; set; }

        [StringLength(2)]
        public string UF_ST { get; set; }

        public decimal? VALOR_BC_FPC { get; set; }

        public decimal? PERCENTUAL_FPC { get; set; }

        public decimal? VALOR_FPC { get; set; }

        public decimal? VALOR_BC_FPC_ST { get; set; }

        public decimal? PERCENTUAL_BC_FPC_ST { get; set; }

        public decimal? VALOR_FPC_ST { get; set; }

        public decimal? FPC_CONSUMIDOR_FINAL { get; set; }

        public decimal? VALOR_BC_FPC_RETIDO { get; set; }

        public decimal? PERCENTUAL_BC_FPC_RETIDO { get; set; }

        public decimal? VALOR_FPC_RETIDO { get; set; }

        public decimal? VALOR_BC_FPC_UF_DESTINO { get; set; }

        public decimal? VALOR_BS_ICMS_UF_DESTINO { get; set; }

        public decimal? PERCENTUAL_FPC_UF_DESTINO { get; set; }

        public decimal? ALIQUOTA_INTERNA_UF_DESTINO { get; set; }

        public decimal? ALIQUOTA_INTERESTADUAL_UFS { get; set; }

        public decimal? PERCENTUAL_PROVISORIO_PARTILHA { get; set; }

        public decimal? VALOR_ICMS_FPC_UF_DESTINO { get; set; }

        public decimal? VALOR_ICMS_INTER_UF_DESTINO { get; set; }

        public decimal? VALOR_ICMS_INTER_UF_REMETENTE { get; set; }

        public virtual NFE_DETALHE NFE_DETALHE { get; set; }
    }
}
