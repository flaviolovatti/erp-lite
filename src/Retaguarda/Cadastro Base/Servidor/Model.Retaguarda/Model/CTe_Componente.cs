namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cte_componente")]
    public partial class CTe_Componente
    {
        public int id { get; set; }

        public int id_cte_cabecalho { get; set; }

        [StringLength(15)]
        public string nome { get; set; }

        public decimal? valor { get; set; }

        public virtual CTe_Cabecalho cte_cabecalho { get; set; }
    }
}
