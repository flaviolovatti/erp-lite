namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FIN_CLIENTE_GRUPO_DET
    {
        public int ID { get; set; }

        public int ID_CLIENTE { get; set; }

        public int ID_FIN_CLIENTE_GRUPO_CAB { get; set; }

        [StringLength(2)]
        public string DIA_LANCAMENTO { get; set; }

        public decimal? VALOR { get; set; }

        [StringLength(1)]
        public string GERA_BOLETO { get; set; }

        public virtual CLIENTE CLIENTE { get; set; }

        public virtual FIN_CLIENTE_GRUPO_CAB FIN_CLIENTE_GRUPO_CAB { get; set; }
    }
}
