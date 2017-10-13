namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FIN_EXTRATO_CONTA_BANCO
    {
        public int ID { get; set; }

        public int ID_CONTA_CAIXA { get; set; }

        [StringLength(7)]
        public string MES_ANO { get; set; }

        [StringLength(2)]
        public string MES { get; set; }

        [StringLength(4)]
        public string ANO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_MOVIMENTO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_BALANCETE { get; set; }

        [StringLength(250)]
        public string HISTORICO { get; set; }

        [StringLength(50)]
        public string DOCUMENTO { get; set; }

        public decimal? VALOR { get; set; }

        [StringLength(1)]
        public string CONCILIADO { get; set; }

        [Column(TypeName = "text")]
        public string OBSERVACAO { get; set; }

        public virtual CONTA_CAIXA CONTA_CAIXA { get; set; }
    }
}
