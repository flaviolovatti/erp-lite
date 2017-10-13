namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOGSS")]
    public partial class LOGSS
    {
        public int ID { get; set; }

        public int? DAVC { get; set; }

        public int? DAVD { get; set; }
    }
}
