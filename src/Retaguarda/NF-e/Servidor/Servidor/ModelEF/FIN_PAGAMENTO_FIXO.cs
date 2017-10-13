namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FIN_PAGAMENTO_FIXO
    {
        public int ID { get; set; }

        public int ID_FORNECEDOR { get; set; }

        public int ID_FIN_DOCUMENTO_ORIGEM { get; set; }

        [StringLength(1)]
        public string PAGAMENTO_COMPARTILHADO { get; set; }

        public int? QUANTIDADE_PARCELA { get; set; }

        public decimal? VALOR_TOTAL { get; set; }

        public decimal? VALOR_A_PAGAR { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_LANCAMENTO { get; set; }

        [StringLength(50)]
        public string NUMERO_DOCUMENTO { get; set; }

        [Column(TypeName = "text")]
        public string IMAGEM_DOCUMENTO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PRIMEIRO_VENCIMENTO { get; set; }

        public int? INTERVALO_ENTRE_PARCELAS { get; set; }

        public virtual FIN_DOCUMENTO_ORIGEM FIN_DOCUMENTO_ORIGEM { get; set; }

        public virtual FORNECEDOR FORNECEDOR { get; set; }
    }
}
