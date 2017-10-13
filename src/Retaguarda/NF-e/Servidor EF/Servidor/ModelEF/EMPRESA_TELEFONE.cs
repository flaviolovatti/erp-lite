namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EMPRESA_TELEFONE
    {
        public int ID { get; set; }

        public int ID_EMPRESA { get; set; }

        public int? TIPO { get; set; }

        [StringLength(14)]
        public string NUMERO { get; set; }

        [Column(TypeName = "text")]
        public string OBSERVACAO { get; set; }

        public virtual EMPRESA EMPRESA { get; set; }
    }
}
