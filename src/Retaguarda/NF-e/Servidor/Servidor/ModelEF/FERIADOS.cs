namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FERIADOS
    {
        public int ID { get; set; }

        [StringLength(4)]
        public string ANO { get; set; }

        [StringLength(50)]
        public string NOME { get; set; }

        [StringLength(1)]
        public string ABRANGENCIA { get; set; }

        [StringLength(2)]
        public string UF { get; set; }

        public int? MUNICIPIO_IBGE { get; set; }

        [StringLength(1)]
        public string TIPO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_FERIADO { get; set; }
    }
}
