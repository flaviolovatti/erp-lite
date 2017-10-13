namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFE_EXPORTACAO
    {
        public int ID { get; set; }

        public int ID_NFE_DETALHE { get; set; }

        public int? DRAWBACK { get; set; }

        public int? NUMERO_REGISTRO { get; set; }

        [StringLength(44)]
        public string CHAVE_ACESSO { get; set; }

        public decimal? QUANTIDADE { get; set; }

        public virtual NFE_DETALHE NFE_DETALHE { get; set; }
    }
}
