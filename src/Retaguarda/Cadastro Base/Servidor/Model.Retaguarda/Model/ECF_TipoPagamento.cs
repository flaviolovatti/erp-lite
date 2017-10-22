namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.ecf_tipo_pagamento")]
    public partial class ECF_TipoPagamento
    {
        public int id { get; set; }

        [StringLength(3)]
        public string codigo { get; set; }

        [StringLength(20)]
        public string descricao { get; set; }

        [StringLength(1)]
        public string tef { get; set; }

        [StringLength(1)]
        public string imprime_vinculado { get; set; }

        [StringLength(1)]
        public string permite_troco { get; set; }

        [StringLength(1)]
        public string tef_tipo_gp { get; set; }

        [StringLength(1)]
        public string gera_parcelas { get; set; }
    }
}
