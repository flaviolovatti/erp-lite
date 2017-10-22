namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.venda_condicoes_parcelas")]
    public partial class venda_condicoes_parcelas
    {
        public int id { get; set; }

        public int id_venda_condicoes_pagamento { get; set; }

        public int? parcela { get; set; }

        public int? dias { get; set; }

        public decimal? taxa { get; set; }

        public virtual venda_condicoes_pagamento venda_condicoes_pagamento { get; set; }
    }
}
