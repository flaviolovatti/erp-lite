namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EMPRESA_CNAE
    {
        public int ID { get; set; }

        public int ID_CNAE { get; set; }

        public int ID_EMPRESA { get; set; }

        [StringLength(1)]
        public string PRINCIPAL { get; set; }

        [StringLength(50)]
        public string RAMO_ATIVIDADE { get; set; }

        [Column(TypeName = "text")]
        public string OBJETO_SOCIAL { get; set; }

        public virtual CNAE CNAE { get; set; }

        public virtual EMPRESA EMPRESA { get; set; }
    }
}
