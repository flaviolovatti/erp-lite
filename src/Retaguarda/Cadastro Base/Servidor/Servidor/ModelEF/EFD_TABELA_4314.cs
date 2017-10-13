namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EFD_TABELA_4314
    {
        public int ID { get; set; }

        public int? CODIGO { get; set; }

        [Column(TypeName = "text")]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "text")]
        public string OBSERVACAO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? INICIO_VIGENCIA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FIM_VIGENCIA { get; set; }
    }
}
