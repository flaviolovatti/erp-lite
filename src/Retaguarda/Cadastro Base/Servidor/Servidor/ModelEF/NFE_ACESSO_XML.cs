namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFE_ACESSO_XML
    {
        public int ID { get; set; }

        public int ID_NFE_CABECALHO { get; set; }

        [StringLength(14)]
        public string CNPJ { get; set; }

        [StringLength(11)]
        public string CPF { get; set; }

        public virtual NFE_CABECALHO NFE_CABECALHO { get; set; }
    }
}
