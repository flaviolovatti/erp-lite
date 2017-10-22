namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.fin_lcto_pagar_nt_financeira")]
    public partial class fin_lcto_pagar_nt_financeira
    {
        public int id { get; set; }

        public int id_fin_lancamento_pagar { get; set; }

        public int id_natureza_financeira { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_inclusao { get; set; }

        public decimal? valor { get; set; }

        public decimal? percentual { get; set; }

        public virtual fin_lancamento_pagar fin_lancamento_pagar { get; set; }

        public virtual natureza_financeira natureza_financeira { get; set; }
    }
}
