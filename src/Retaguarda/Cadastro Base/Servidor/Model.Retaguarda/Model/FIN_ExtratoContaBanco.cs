namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.fin_extrato_conta_banco")]
    public partial class FIN_ExtratoContaBanco
    {
        public int id { get; set; }

        public int id_conta_caixa { get; set; }

        [StringLength(7)]
        public string mes_ano { get; set; }

        [StringLength(2)]
        public string mes { get; set; }

        [StringLength(4)]
        public string ano { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_movimento { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_balancete { get; set; }

        [StringLength(250)]
        public string historico { get; set; }

        [StringLength(50)]
        public string documento { get; set; }

        public decimal? valor { get; set; }

        [StringLength(1)]
        public string conciliado { get; set; }

        public string observacao { get; set; }

        public virtual ContaCaixa conta_caixa { get; set; }
    }
}
