namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EFD_TABELA_436
    {
        public int ID { get; set; }

        public int? CODIGO { get; set; }

        [StringLength(250)]
        public string DESCRICAO { get; set; }
    }
}
