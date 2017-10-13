namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EMPRESA_CONTATO
    {
        public int ID { get; set; }

        public int ID_EMPRESA { get; set; }

        [StringLength(100)]
        public string NOME { get; set; }

        [StringLength(250)]
        public string EMAIL { get; set; }

        [StringLength(14)]
        public string FONE_COMERCIAL { get; set; }

        [StringLength(14)]
        public string FONE_RESIDENCIAL { get; set; }

        [StringLength(14)]
        public string FONE_CELULAR { get; set; }

        public virtual EMPRESA EMPRESA { get; set; }
    }
}
