namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cte_ferroviario_vagao")]
    public partial class cte_ferroviario_vagao
    {
        public int id { get; set; }

        public int id_cte_ferroviario { get; set; }

        public int? numero_vagao { get; set; }

        public decimal? capacidade { get; set; }

        [StringLength(3)]
        public string tipo_vagao { get; set; }

        public decimal? peso_real { get; set; }

        public decimal? peso_bc { get; set; }

        public virtual cte_ferroviario cte_ferroviario { get; set; }
    }
}
