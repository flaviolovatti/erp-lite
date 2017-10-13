namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PESSOA_ALTERACAO
    {
        public int ID { get; set; }

        public int ID_PESSOA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_ALTERACAO { get; set; }

        [Column(TypeName = "text")]
        public string OBJETO_ANTIGO { get; set; }

        [Column(TypeName = "text")]
        public string OBJETO_NOVO { get; set; }

        public virtual PESSOA PESSOA { get; set; }
    }
}
