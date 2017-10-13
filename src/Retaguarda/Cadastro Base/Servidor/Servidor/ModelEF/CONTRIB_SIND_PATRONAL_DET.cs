namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CONTRIB_SIND_PATRONAL_DET
    {
        public int ID { get; set; }

        public int ID_CONTRIB_SIND_PATRONAL_CAB { get; set; }

        public decimal? DE { get; set; }

        public decimal? ATE { get; set; }

        public decimal? PERCENTUAL { get; set; }

        public decimal? VALOR_ADICIONAR { get; set; }

        public virtual CONTRIB_SIND_PATRONAL_CAB CONTRIB_SIND_PATRONAL_CAB { get; set; }
    }
}
