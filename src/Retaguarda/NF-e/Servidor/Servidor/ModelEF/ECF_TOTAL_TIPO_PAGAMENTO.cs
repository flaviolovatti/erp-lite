namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ECF_TOTAL_TIPO_PAGAMENTO
    {
        public int ID { get; set; }

        [StringLength(30)]
        public string NOME_CAIXA { get; set; }

        public int? ID_GERADO_CAIXA { get; set; }

        public int? ID_EMPRESA { get; set; }

        public int? ID_ECF_VENDA_CABECALHO { get; set; }

        public int? ID_ECF_TIPO_PAGAMENTO { get; set; }

        [StringLength(20)]
        public string SERIE_ECF { get; set; }

        public int? COO { get; set; }

        public int? CCF { get; set; }

        public int? GNF { get; set; }

        public decimal? VALOR { get; set; }

        [StringLength(30)]
        public string NSU { get; set; }

        [StringLength(1)]
        public string ESTORNO { get; set; }

        [StringLength(10)]
        public string REDE { get; set; }

        [StringLength(1)]
        public string CARTAO_DC { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_VENDA { get; set; }

        [StringLength(32)]
        public string LOGSS { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_SINCRONIZACAO { get; set; }

        [StringLength(8)]
        public string HORA_SINCRONIZACAO { get; set; }
    }
}
