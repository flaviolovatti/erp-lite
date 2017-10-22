namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cte_componente")]
    public partial class cte_componente
    {
        public int id { get; set; }

        public int id_cte_cabecalho { get; set; }

        [StringLength(15)]
        public string nome { get; set; }

        public decimal? valor { get; set; }

        public virtual cte_cabecalho cte_cabecalho { get; set; }
    }
}
