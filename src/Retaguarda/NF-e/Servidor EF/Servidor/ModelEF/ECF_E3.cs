namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ECF_E3
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string SERIE_ECF { get; set; }

        [StringLength(1)]
        public string MF_ADICIONAL { get; set; }

        [StringLength(7)]
        public string TIPO_ECF { get; set; }

        [StringLength(20)]
        public string MARCA_ECF { get; set; }

        [StringLength(20)]
        public string MODELO_ECF { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_ESTOQUE { get; set; }

        [StringLength(8)]
        public string HORA_ESTOQUE { get; set; }
    }
}
