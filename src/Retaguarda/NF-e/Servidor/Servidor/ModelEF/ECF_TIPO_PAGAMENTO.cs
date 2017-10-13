namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ECF_TIPO_PAGAMENTO
    {
        public int ID { get; set; }

        [StringLength(3)]
        public string CODIGO { get; set; }

        [StringLength(20)]
        public string DESCRICAO { get; set; }

        [StringLength(1)]
        public string TEF { get; set; }

        [StringLength(1)]
        public string IMPRIME_VINCULADO { get; set; }

        [StringLength(1)]
        public string PERMITE_TROCO { get; set; }

        [StringLength(1)]
        public string TEF_TIPO_GP { get; set; }

        [StringLength(1)]
        public string GERA_PARCELAS { get; set; }
    }
}
