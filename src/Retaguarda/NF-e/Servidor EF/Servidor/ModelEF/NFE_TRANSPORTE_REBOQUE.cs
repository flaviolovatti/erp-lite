namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFE_TRANSPORTE_REBOQUE
    {
        public int ID { get; set; }

        public int ID_NFE_TRANSPORTE { get; set; }

        [StringLength(8)]
        public string PLACA { get; set; }

        [StringLength(2)]
        public string UF { get; set; }

        [StringLength(20)]
        public string RNTC { get; set; }

        public virtual NFE_TRANSPORTE NFE_TRANSPORTE { get; set; }
    }
}
