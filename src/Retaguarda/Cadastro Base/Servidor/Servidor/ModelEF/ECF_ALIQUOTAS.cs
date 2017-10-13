namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ECF_ALIQUOTAS
    {
        public int ID { get; set; }

        [StringLength(10)]
        public string TOTALIZADOR_PARCIAL { get; set; }

        [StringLength(4)]
        public string ECF_ICMS_ST { get; set; }

        [StringLength(1)]
        public string PAF_P_ST { get; set; }
    }
}
