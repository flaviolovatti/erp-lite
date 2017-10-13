namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFCE_CONFIGURACAO_LEITOR_SER
    {
        public int ID { get; set; }

        public int ID_NFCE_CONFIGURACAO { get; set; }

        [StringLength(1)]
        public string USA { get; set; }

        [StringLength(4)]
        public string PORTA { get; set; }

        public int? BAUD { get; set; }

        public int? HAND_SHAKE { get; set; }

        public int? PARITY { get; set; }

        public int? STOP_BITS { get; set; }

        public int? DATA_BITS { get; set; }

        public int? INTERVALO { get; set; }

        [StringLength(1)]
        public string USAR_FILA { get; set; }

        [StringLength(1)]
        public string HARD_FLOW { get; set; }

        [StringLength(1)]
        public string SOFT_FLOW { get; set; }

        [StringLength(20)]
        public string SUFIXO { get; set; }

        [StringLength(1)]
        public string EXCLUIR_SUFIXO { get; set; }

        public virtual NFCE_CONFIGURACAO NFCE_CONFIGURACAO { get; set; }
    }
}
