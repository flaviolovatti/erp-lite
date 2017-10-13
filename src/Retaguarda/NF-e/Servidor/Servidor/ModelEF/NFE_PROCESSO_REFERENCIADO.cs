namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFE_PROCESSO_REFERENCIADO
    {
        public int ID { get; set; }

        public int ID_NFE_CABECALHO { get; set; }

        [StringLength(60)]
        public string IDENTIFICADOR { get; set; }

        [StringLength(1)]
        public string ORIGEM { get; set; }

        public virtual NFE_CABECALHO NFE_CABECALHO { get; set; }
    }
}
