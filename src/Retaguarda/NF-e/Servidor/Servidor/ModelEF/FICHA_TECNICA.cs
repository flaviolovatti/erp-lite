namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FICHA_TECNICA
    {
        public int ID { get; set; }

        public int ID_PRODUTO { get; set; }

        [StringLength(100)]
        public string DESCRICAO { get; set; }

        public int? ID_PRODUTO_FILHO { get; set; }

        public decimal? QUANTIDADE { get; set; }

        public int? SEQUENCIA_PRODUCAO { get; set; }

        public virtual PRODUTO PRODUTO { get; set; }
    }
}
