namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfe_cana_fornecimento_diario")]
    public partial class nfe_cana_fornecimento_diario
    {
        public int id { get; set; }

        public int id_nfe_cana { get; set; }

        [StringLength(2)]
        public string dia { get; set; }

        public decimal? quantidade { get; set; }

        public decimal? quantidade_total_mes { get; set; }

        public decimal? quantidade_total_anterior { get; set; }

        public decimal? quantidade_total_geral { get; set; }

        public virtual nfe_cana nfe_cana { get; set; }
    }
}