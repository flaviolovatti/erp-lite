namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PESSOA_CONTATO
    {
        public int ID { get; set; }

        public int ID_PESSOA { get; set; }

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

        public virtual PESSOA PESSOA { get; set; }
    }
}
