namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cte_multimodal")]
    public partial class CTe_Multimodal
    {
        public int id { get; set; }

        public int id_cte_cabecalho { get; set; }

        [StringLength(20)]
        public string cotm { get; set; }

        public int? indicador_negociavel { get; set; }

        public virtual CTe_Cabecalho cte_cabecalho { get; set; }
    }
}
