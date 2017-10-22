namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.ecf_turno")]
    public partial class ECF_Turno
    {
        public int id { get; set; }

        [StringLength(10)]
        public string descricao { get; set; }

        [StringLength(8)]
        public string hora_inicio { get; set; }

        [StringLength(8)]
        public string hora_fim { get; set; }
    }
}
