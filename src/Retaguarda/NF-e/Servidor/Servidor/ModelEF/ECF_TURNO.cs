namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ECF_TURNO
    {
        public int ID { get; set; }

        [StringLength(10)]
        public string DESCRICAO { get; set; }

        [StringLength(8)]
        public string HORA_INICIO { get; set; }

        [StringLength(8)]
        public string HORA_FIM { get; set; }
    }
}
