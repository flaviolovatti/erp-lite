namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CTE_RODOVIARIO_MOTORISTA
    {
        public int ID { get; set; }

        public int ID_CTE_RODOVIARIO { get; set; }

        [StringLength(60)]
        public string NOME { get; set; }

        [StringLength(11)]
        public string CPF { get; set; }

        public virtual CTE_RODOVIARIO CTE_RODOVIARIO { get; set; }
    }
}
