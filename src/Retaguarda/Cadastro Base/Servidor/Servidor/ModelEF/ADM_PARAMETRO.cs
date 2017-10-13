namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ADM_PARAMETRO
    {
        public int ID { get; set; }

        public int ID_EMPRESA { get; set; }

        public int? FIN_PARCELA_ABERTO { get; set; }

        public int? FIN_PARCELA_QUITADO { get; set; }

        public int? FIN_PARCELA_QUITADO_PARCIAL { get; set; }

        public int? FIN_TIPO_RECEBIMENTO_EDI { get; set; }

        public int? COMPRA_FIN_DOC_ORIGEM { get; set; }

        public int? COMPRA_CONTA_CAIXA { get; set; }

        public virtual EMPRESA EMPRESA { get; set; }
    }
}
