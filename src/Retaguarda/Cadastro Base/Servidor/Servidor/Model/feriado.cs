namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.feriados")]
    public partial class feriado
    {
        public int id { get; set; }

        [StringLength(4)]
        public string ano { get; set; }

        [StringLength(50)]
        public string nome { get; set; }

        [StringLength(1)]
        public string abrangencia { get; set; }

        [StringLength(2)]
        public string uf { get; set; }

        public int? municipio_ibge { get; set; }

        [StringLength(1)]
        public string tipo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_feriado { get; set; }
    }
}
