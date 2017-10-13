namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFE_TRANSPORTE_VOLUME_LACRE
    {
        public int ID { get; set; }

        public int ID_NFE_TRANSPORTE_VOLUME { get; set; }

        [StringLength(60)]
        public string NUMERO { get; set; }

        public virtual NFE_TRANSPORTE_VOLUME NFE_TRANSPORTE_VOLUME { get; set; }
    }
}
