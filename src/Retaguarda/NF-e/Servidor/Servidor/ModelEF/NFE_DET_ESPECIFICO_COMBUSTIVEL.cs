namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFE_DET_ESPECIFICO_COMBUSTIVEL
    {
        public int ID { get; set; }

        public int ID_NFE_DETALHE { get; set; }

        public int? CODIGO_ANP { get; set; }

        [StringLength(21)]
        public string CODIF { get; set; }

        public decimal? QUANTIDADE_TEMP_AMBIENTE { get; set; }

        [StringLength(2)]
        public string UF_CONSUMO { get; set; }

        public decimal? BASE_CALCULO_CIDE { get; set; }

        public decimal? ALIQUOTA_CIDE { get; set; }

        public decimal? VALOR_CIDE { get; set; }

        [StringLength(95)]
        public string DESCRICAO_PRODUTO_ANP { get; set; }

        public decimal? PERCENTUAL_PETROLEO { get; set; }

        public decimal? PERCENTUAL_NACIONAL { get; set; }

        public decimal? PERCENTUAL_IMPORTADO { get; set; }

        public decimal? VALOR_PARTIDA { get; set; }

        public int? NUMERO_IDENTIFICACAO_BICO { get; set; }

        public int? NUMERO_IDENTIFICACAO_BOMBA { get; set; }

        public int? NUMERO_IDENTIFICACAO_TANQUE { get; set; }

        public decimal? VALOR_ENCERRANTE_INICIO { get; set; }

        public decimal? VALOR_ENCERRANTE_FIM { get; set; }

        public virtual NFE_DETALHE NFE_DETALHE { get; set; }
    }
}
