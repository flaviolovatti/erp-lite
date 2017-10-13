namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IBPT")]
    public partial class IBPT
    {
        public int ID { get; set; }

        [StringLength(8)]
        public string NCM { get; set; }

        [StringLength(2)]
        public string EX { get; set; }

        [StringLength(1)]
        public string TIPO { get; set; }

        [Column(TypeName = "text")]
        public string DESCRICAO { get; set; }

        public decimal? NACIONAL_FEDERAL { get; set; }

        public decimal? IMPORTADOS_FEDERAL { get; set; }

        public decimal? ESTADUAL { get; set; }

        public decimal? MUNICIPAL { get; set; }

        [Column(TypeName = "date")]
        public DateTime? VIGENCIA_INICIO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? VIGENCIA_FIM { get; set; }

        [StringLength(6)]
        public string CHAVE { get; set; }

        [StringLength(6)]
        public string VERSAO { get; set; }

        [StringLength(34)]
        public string FONTE { get; set; }
    }
}
