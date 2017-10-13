namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VENDA_CONDICOES_PARCELAS
    {
        public int ID { get; set; }

        public int ID_VENDA_CONDICOES_PAGAMENTO { get; set; }

        public int? PARCELA { get; set; }

        public int? DIAS { get; set; }

        public decimal? TAXA { get; set; }

        public virtual VENDA_CONDICOES_PAGAMENTO VENDA_CONDICOES_PAGAMENTO { get; set; }
    }
}
