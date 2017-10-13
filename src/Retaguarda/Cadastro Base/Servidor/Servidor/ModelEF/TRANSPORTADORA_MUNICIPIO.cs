namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TRANSPORTADORA_MUNICIPIO
    {
        public int ID { get; set; }

        public int ID_MUNICIPIO { get; set; }

        public int ID_TRANSPORTADORA { get; set; }

        public virtual MUNICIPIO MUNICIPIO { get; set; }

        public virtual TRANSPORTADORA TRANSPORTADORA { get; set; }
    }
}
