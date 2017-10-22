namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfe_cana_deducoes_safra")]
    public partial class nfe_cana_deducoes_safra
    {
        public int id { get; set; }

        public int id_nfe_cana { get; set; }

        [StringLength(60)]
        public string decricao { get; set; }

        public decimal? valor_deducao { get; set; }

        public decimal? valor_fornecimento { get; set; }

        public decimal? valor_total_deducao { get; set; }

        public decimal? valor_liquido_fornecimento { get; set; }

        public virtual nfe_cana nfe_cana { get; set; }
    }
}
