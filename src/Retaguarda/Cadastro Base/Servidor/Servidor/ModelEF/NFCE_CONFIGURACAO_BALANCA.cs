namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFCE_CONFIGURACAO_BALANCA
    {
        public int ID { get; set; }

        public int ID_NFCE_CONFIGURACAO { get; set; }

        public int? MODELO { get; set; }

        [StringLength(1)]
        public string IDENTIFICADOR { get; set; }

        public int? HAND_SHAKE { get; set; }

        public int? PARITY { get; set; }

        public int? STOP_BITS { get; set; }

        public int? DATA_BITS { get; set; }

        public int? BAUD_RATE { get; set; }

        [StringLength(4)]
        public string PORTA { get; set; }

        public int? TIMEOUT { get; set; }

        [StringLength(20)]
        public string TIPO_CONFIGURACAO { get; set; }

        public virtual NFCE_CONFIGURACAO NFCE_CONFIGURACAO { get; set; }
    }
}
