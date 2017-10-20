namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.fin_fechamento_caixa_banco")]
    public partial class FIN_FechamentoCaixaBanco
    {
        public int id { get; set; }

        public int id_conta_caixa { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_fechamento { get; set; }

        [StringLength(7)]
        public string mes_ano { get; set; }

        [StringLength(2)]
        public string mes { get; set; }

        [StringLength(4)]
        public string ano { get; set; }

        public decimal? saldo_anterior { get; set; }

        public decimal? recebimentos { get; set; }

        public decimal? pagamentos { get; set; }

        public decimal? saldo_conta { get; set; }

        public decimal? cheque_nao_compensado { get; set; }

        public decimal? saldo_disponivel { get; set; }

        public virtual ContaCaixa conta_caixa { get; set; }
    }
}
