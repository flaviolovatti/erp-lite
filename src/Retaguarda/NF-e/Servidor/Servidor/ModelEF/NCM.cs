namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NCM")]
    public partial class NCM
    {
        public int ID { get; set; }

        [StringLength(8)]
        public string CODIGO { get; set; }

        [Column(TypeName = "text")]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "text")]
        public string OBSERVACAO { get; set; }
    }
}
