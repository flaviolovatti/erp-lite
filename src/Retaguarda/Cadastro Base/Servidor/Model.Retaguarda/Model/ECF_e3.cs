namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.ecf_e3")]
    public partial class ECF_e3
    {
        public int id { get; set; }

        [StringLength(20)]
        public string serie_ecf { get; set; }

        [StringLength(1)]
        public string mf_adicional { get; set; }

        [StringLength(7)]
        public string tipo_ecf { get; set; }

        [StringLength(20)]
        public string marca_ecf { get; set; }

        [StringLength(20)]
        public string modelo_ecf { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_estoque { get; set; }

        [StringLength(8)]
        public string hora_estoque { get; set; }
    }
}
