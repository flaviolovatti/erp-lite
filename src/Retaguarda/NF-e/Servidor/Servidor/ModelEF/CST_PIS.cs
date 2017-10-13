namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CST_PIS
    {
        public int ID { get; set; }

        [StringLength(2)]
        public string CODIGO { get; set; }

        [StringLength(250)]
        public string DESCRICAO { get; set; }
    }
}
