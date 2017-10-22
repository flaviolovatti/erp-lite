namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.integracao_pdv")]
    public partial class integracao_pdv
    {
        public int id { get; set; }

        [StringLength(50)]
        public string identifica { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_integracao { get; set; }

        [StringLength(8)]
        public string hora_integracao { get; set; }
    }
}
