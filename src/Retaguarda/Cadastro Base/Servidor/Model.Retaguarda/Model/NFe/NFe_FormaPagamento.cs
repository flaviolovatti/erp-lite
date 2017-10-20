namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfe_forma_pagamento")]
    public partial class NFe_FormaPagamento
    {
        public int id { get; set; }

        public int id_nfce_tipo_pagamento { get; set; }

        public int id_nfe_cabecalho { get; set; }

        [StringLength(2)]
        public string forma { get; set; }

        public decimal? valor { get; set; }

        [StringLength(1)]
        public string cartao_tipo_integracao { get; set; }

        [StringLength(14)]
        public string cnpj_operadora_cartao { get; set; }

        [StringLength(2)]
        public string bandeira { get; set; }

        [StringLength(20)]
        public string numero_autorizacao { get; set; }

        [StringLength(1)]
        public string estorno { get; set; }

        public decimal? troco { get; set; }

        public virtual NFCe_TipoPagamento nfce_tipo_pagamento { get; set; }

        public virtual NFe_Cabecalho nfe_cabecalho { get; set; }
    }
}
