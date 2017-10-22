namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cte_carga")]
    public partial class CTe_Carga
    {
        public int id { get; set; }

        public int id_cte_cabecalho { get; set; }

        [StringLength(2)]
        public string codigo_unidade_medida { get; set; }

        [StringLength(20)]
        public string tipo_medida { get; set; }

        public decimal? quantidade { get; set; }

        public virtual CTe_Cabecalho cte_cabecalho { get; set; }
    }
}
