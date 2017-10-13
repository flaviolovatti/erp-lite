namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPERADORA_PLANO_SAUDE
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string REGISTRO_ANS { get; set; }

        [StringLength(100)]
        public string NOME { get; set; }

        [StringLength(30)]
        public string CLASSIFICACAO_CONTABIL_CONTA { get; set; }
    }
}
