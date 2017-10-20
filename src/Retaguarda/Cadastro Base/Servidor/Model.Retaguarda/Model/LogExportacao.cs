namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.log_exportacao")]
    public partial class LogExportacao
    {
        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_exportacao { get; set; }

        [StringLength(8)]
        public string hora_importacao { get; set; }

        public string erro { get; set; }

        public string registro { get; set; }
    }
}
