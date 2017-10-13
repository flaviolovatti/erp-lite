namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFE_REFERENCIADA
    {
        public int ID { get; set; }

        public int ID_NFE_CABECALHO { get; set; }

        [StringLength(44)]
        public string CHAVE_ACESSO { get; set; }

        public virtual NFE_CABECALHO NFE_CABECALHO { get; set; }
    }
}
