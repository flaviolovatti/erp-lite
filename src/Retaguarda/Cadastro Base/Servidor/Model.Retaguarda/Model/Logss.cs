namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.logss")]
    public partial class Logss
    {
        public int id { get; set; }

        public int? davc { get; set; }

        public int? davd { get; set; }
    }
}
