namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPERADORA_CARTAO
    {
        public int ID { get; set; }

        public int ID_CONTA_CAIXA { get; set; }

        [StringLength(30)]
        public string BANDEIRA { get; set; }

        [StringLength(50)]
        public string NOME { get; set; }

        public decimal? TAXA_ADM { get; set; }

        public decimal? TAXA_ADM_DEBITO { get; set; }

        public decimal? VALOR_ALUGUEL_POS_PIN { get; set; }

        public int? VENCIMENTO_ALUGUEL { get; set; }

        [StringLength(14)]
        public string FONE1 { get; set; }

        [StringLength(14)]
        public string FONE2 { get; set; }

        [StringLength(30)]
        public string CLASSIFICACAO_CONTABIL_CONTA { get; set; }

        public virtual CONTA_CAIXA CONTA_CAIXA { get; set; }
    }
}
