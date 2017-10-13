namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ADM_MODULO
    {
        public int ID { get; set; }

        [StringLength(3)]
        public string CODIGO { get; set; }

        [StringLength(100)]
        public string NOME { get; set; }

        [Column(TypeName = "text")]
        public string DESCRICAO { get; set; }

        [StringLength(1)]
        public string ATIVO { get; set; }
    }
}
