namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFE_DETALHE_IMPOSTO_ISSQN
    {
        public int ID { get; set; }

        public int ID_NFE_DETALHE { get; set; }

        public decimal? BASE_CALCULO_ISSQN { get; set; }

        public decimal? ALIQUOTA_ISSQN { get; set; }

        public decimal? VALOR_ISSQN { get; set; }

        public int? MUNICIPIO_ISSQN { get; set; }

        public int? ITEM_LISTA_SERVICOS { get; set; }

        public decimal? VALOR_DEDUCAO { get; set; }

        public decimal? VALOR_OUTRAS_RETENCOES { get; set; }

        public decimal? VALOR_DESCONTO_INCONDICIONADO { get; set; }

        public decimal? VALOR_DESCONTO_CONDICIONADO { get; set; }

        public decimal? VALOR_RETENCAO_ISS { get; set; }

        public int? INDICADOR_EXIGIBILIDADE_ISS { get; set; }

        [StringLength(20)]
        public string CODIGO_SERVICO { get; set; }

        public int? MUNICIPIO_INCIDENCIA { get; set; }

        public int? PAIS_SEVICO_PRESTADO { get; set; }

        [StringLength(30)]
        public string NUMERO_PROCESSO { get; set; }

        public int? INDICADOR_INCENTIVO_FISCAL { get; set; }

        public virtual NFE_DETALHE NFE_DETALHE { get; set; }
    }
}
