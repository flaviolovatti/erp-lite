namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFE_FORMA_PAGAMENTO
    {
        public int ID { get; set; }

        public int ID_NFCE_TIPO_PAGAMENTO { get; set; }

        public int ID_NFE_CABECALHO { get; set; }

        [StringLength(2)]
        public string FORMA { get; set; }

        public decimal? VALOR { get; set; }

        [StringLength(1)]
        public string CARTAO_TIPO_INTEGRACAO { get; set; }

        [StringLength(14)]
        public string CNPJ_OPERADORA_CARTAO { get; set; }

        [StringLength(2)]
        public string BANDEIRA { get; set; }

        [StringLength(20)]
        public string NUMERO_AUTORIZACAO { get; set; }

        [StringLength(1)]
        public string ESTORNO { get; set; }

        public decimal? TROCO { get; set; }

        public virtual NFCE_TIPO_PAGAMENTO NFCE_TIPO_PAGAMENTO { get; set; }

        public virtual NFE_CABECALHO NFE_CABECALHO { get; set; }
    }
}
