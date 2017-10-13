namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFE_DETALHE_IMPOSTO_IPI
    {
        public int ID { get; set; }

        public int ID_NFE_DETALHE { get; set; }

        [StringLength(5)]
        public string ENQUADRAMENTO_IPI { get; set; }

        [StringLength(14)]
        public string CNPJ_PRODUTOR { get; set; }

        [StringLength(60)]
        public string CODIGO_SELO_IPI { get; set; }

        public int? QUANTIDADE_SELO_IPI { get; set; }

        [StringLength(3)]
        public string ENQUADRAMENTO_LEGAL_IPI { get; set; }

        [StringLength(2)]
        public string CST_IPI { get; set; }

        public decimal? VALOR_BASE_CALCULO_IPI { get; set; }

        public decimal? ALIQUOTA_IPI { get; set; }

        public decimal? QUANTIDADE_UNIDADE_TRIBUTAVEL { get; set; }

        public decimal? VALOR_UNIDADE_TRIBUTAVEL { get; set; }

        public decimal? VALOR_IPI { get; set; }

        public virtual NFE_DETALHE NFE_DETALHE { get; set; }
    }
}
