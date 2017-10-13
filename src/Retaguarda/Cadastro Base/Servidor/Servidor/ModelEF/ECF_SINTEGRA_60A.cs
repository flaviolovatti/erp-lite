namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ECF_SINTEGRA_60A
    {
        public int ID { get; set; }

        [StringLength(8)]
        public string NOME_CAIXA { get; set; }

        public int? ID_GERADO_CAIXA { get; set; }

        public int? ID_EMPRESA { get; set; }

        public int? ID_SINTEGRA_60M { get; set; }

        [StringLength(4)]
        public string SITUACAO_TRIBUTARIA { get; set; }

        public decimal? VALOR { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_SINCRONIZACAO { get; set; }

        [StringLength(32)]
        public string HORA_SINCRONIZACAO { get; set; }
    }
}
