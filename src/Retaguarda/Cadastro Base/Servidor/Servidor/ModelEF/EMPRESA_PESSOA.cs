namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EMPRESA_PESSOA
    {
        public int ID { get; set; }

        public int ID_EMPRESA { get; set; }

        public int ID_PESSOA { get; set; }

        [StringLength(1)]
        public string RESPONSAVEL_LEGAL { get; set; }

        public virtual EMPRESA EMPRESA { get; set; }

        public virtual PESSOA PESSOA { get; set; }
    }
}
