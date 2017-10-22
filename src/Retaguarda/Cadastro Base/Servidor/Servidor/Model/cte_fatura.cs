namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cte_fatura")]
    public partial class cte_fatura
    {
        public int id { get; set; }

        public int id_cte_cabecalho { get; set; }

        [StringLength(60)]
        public string numero { get; set; }

        public decimal? valor_original { get; set; }

        public decimal? valor_desconto { get; set; }

        public decimal? valor_liquido { get; set; }

        public virtual cte_cabecalho cte_cabecalho { get; set; }
    }
}
