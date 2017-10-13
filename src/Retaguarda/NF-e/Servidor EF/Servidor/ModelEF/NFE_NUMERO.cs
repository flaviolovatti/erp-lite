namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFE_NUMERO
    {
        public int ID { get; set; }

        public int ID_EMPRESA { get; set; }

        [StringLength(3)]
        public string SERIE { get; set; }

        public int? NUMERO { get; set; }

        public virtual EMPRESA EMPRESA { get; set; }
    }
}
