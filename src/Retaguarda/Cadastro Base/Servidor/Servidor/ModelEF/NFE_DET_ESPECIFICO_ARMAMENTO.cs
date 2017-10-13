namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFE_DET_ESPECIFICO_ARMAMENTO
    {
        public int ID { get; set; }

        public int ID_NFE_DETALHE { get; set; }

        public int? TIPO_ARMA { get; set; }

        [StringLength(15)]
        public string NUMERO_SERIE_ARMA { get; set; }

        [StringLength(15)]
        public string NUMERO_SERIE_CANO { get; set; }

        [StringLength(250)]
        public string DESCRICAO { get; set; }

        public virtual NFE_DETALHE NFE_DETALHE { get; set; }
    }
}
