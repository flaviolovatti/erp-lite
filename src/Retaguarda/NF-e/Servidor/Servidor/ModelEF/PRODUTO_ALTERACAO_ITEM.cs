namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRODUTO_ALTERACAO_ITEM
    {
        public int ID { get; set; }

        public int ID_PRODUTO { get; set; }

        [StringLength(14)]
        public string CODIGO { get; set; }

        [StringLength(100)]
        public string NOME { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_INICIAL { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_FINAL { get; set; }

        public virtual PRODUTO PRODUTO { get; set; }
    }
}
