namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CTE_RODOVIARIO_PEDAGIO
    {
        public int ID { get; set; }

        public int ID_CTE_RODOVIARIO { get; set; }

        [StringLength(14)]
        public string CNPJ_FORNECEDOR { get; set; }

        [StringLength(20)]
        public string COMPROVANTE_COMPRA { get; set; }

        [StringLength(14)]
        public string CNPJ_RESPONSAVEL { get; set; }

        public decimal? VALOR { get; set; }

        public virtual CTE_RODOVIARIO CTE_RODOVIARIO { get; set; }
    }
}
