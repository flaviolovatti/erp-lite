namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.ibpt")]
    public partial class ibpt
    {
        public int id { get; set; }

        [StringLength(8)]
        public string ncm { get; set; }

        [StringLength(2)]
        public string ex { get; set; }

        [StringLength(1)]
        public string tipo { get; set; }

        public string descricao { get; set; }

        public decimal? nacional_federal { get; set; }

        public decimal? importados_federal { get; set; }

        public decimal? estadual { get; set; }

        public decimal? municipal { get; set; }

        [Column(TypeName = "date")]
        public DateTime? vigencia_inicio { get; set; }

        [Column(TypeName = "date")]
        public DateTime? vigencia_fim { get; set; }

        [StringLength(6)]
        public string chave { get; set; }

        [StringLength(6)]
        public string versao { get; set; }

        [StringLength(34)]
        public string fonte { get; set; }
    }
}
