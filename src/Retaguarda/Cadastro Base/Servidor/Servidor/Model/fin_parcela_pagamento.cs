namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.fin_parcela_pagamento")]
    public partial class fin_parcela_pagamento
    {
        public int id { get; set; }

        public int id_fin_parcela_pagar { get; set; }

        public int? id_fin_cheque_emitido { get; set; }

        public int id_fin_tipo_pagamento { get; set; }

        public int id_conta_caixa { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_pagamento { get; set; }

        public decimal? taxa_juro { get; set; }

        public decimal? taxa_multa { get; set; }

        public decimal? taxa_desconto { get; set; }

        public decimal? valor_juro { get; set; }

        public decimal? valor_multa { get; set; }

        public decimal? valor_desconto { get; set; }

        public decimal? valor_pago { get; set; }

        [StringLength(250)]
        public string historico { get; set; }

        public virtual conta_caixa conta_caixa { get; set; }

        public virtual fin_cheque_emitido fin_cheque_emitido { get; set; }

        public virtual fin_parcela_pagar fin_parcela_pagar { get; set; }

        public virtual fin_tipo_pagamento fin_tipo_pagamento { get; set; }
    }
}
