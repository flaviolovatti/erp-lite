namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UNIDADE_CONVERSAO
    {
        public int ID { get; set; }

        public int ID_PRODUTO { get; set; }

        public int ID_UNIDADE_PRODUTO { get; set; }

        [StringLength(10)]
        public string SIGLA { get; set; }

        [Column(TypeName = "text")]
        public string DESCRICAO { get; set; }

        public decimal? FATOR_CONVERSAO { get; set; }

        public virtual PRODUTO PRODUTO { get; set; }

        public virtual UNIDADE_PRODUTO UNIDADE_PRODUTO { get; set; }
    }
}
