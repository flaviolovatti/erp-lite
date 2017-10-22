namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.operadora_cartao")]
    public partial class operadora_cartao
    {
        public int id { get; set; }

        public int id_conta_caixa { get; set; }

        [StringLength(30)]
        public string bandeira { get; set; }

        [StringLength(50)]
        public string nome { get; set; }

        public decimal? taxa_adm { get; set; }

        public decimal? taxa_adm_debito { get; set; }

        public decimal? valor_aluguel_pos_pin { get; set; }

        public int? vencimento_aluguel { get; set; }

        [StringLength(14)]
        public string fone1 { get; set; }

        [StringLength(14)]
        public string fone2 { get; set; }

        [StringLength(30)]
        public string classificacao_contabil_conta { get; set; }

        public virtual conta_caixa conta_caixa { get; set; }
    }
}
