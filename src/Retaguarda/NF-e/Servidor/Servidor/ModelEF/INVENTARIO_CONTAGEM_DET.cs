namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INVENTARIO_CONTAGEM_DET
    {
        public int ID { get; set; }

        public int ID_INVENTARIO_CONTAGEM_CAB { get; set; }

        public int ID_PRODUTO { get; set; }

        public decimal? CONTAGEM01 { get; set; }

        public decimal? CONTAGEM02 { get; set; }

        public decimal? CONTAGEM03 { get; set; }

        [StringLength(2)]
        public string FECHADO_CONTAGEM { get; set; }

        public decimal? QUANTIDADE_SISTEMA { get; set; }

        public decimal? ACURACIDADE { get; set; }

        public decimal? DIVERGENCIA { get; set; }

        public virtual INVENTARIO_CONTAGEM_CAB INVENTARIO_CONTAGEM_CAB { get; set; }

        public virtual PRODUTO PRODUTO { get; set; }
    }
}
