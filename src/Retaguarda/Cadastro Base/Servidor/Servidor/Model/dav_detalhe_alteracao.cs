namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.dav_detalhe_alteracao")]
    public partial class dav_detalhe_alteracao
    {
        public int id { get; set; }

        public int id_dav_detalhe { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_alteracao { get; set; }

        [StringLength(8)]
        public string hora_alteracao { get; set; }

        [StringLength(1)]
        public string tipo_alteracao { get; set; }

        public string objeto { get; set; }

        public virtual dav_detalhe dav_detalhe { get; set; }
    }
}
