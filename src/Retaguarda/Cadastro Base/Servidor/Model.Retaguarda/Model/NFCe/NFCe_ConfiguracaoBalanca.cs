namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfce_configuracao_balanca")]
    public partial class NFCe_ConfiguracaoBalanca
    {
        public int id { get; set; }

        public int id_nfce_configuracao { get; set; }

        public int? modelo { get; set; }

        [StringLength(1)]
        public string identificador { get; set; }

        public int? hand_shake { get; set; }

        public int? parity { get; set; }

        public int? stop_bits { get; set; }

        public int? data_bits { get; set; }

        public int? baud_rate { get; set; }

        [StringLength(4)]
        public string porta { get; set; }

        public int? timeout { get; set; }

        [StringLength(20)]
        public string tipo_configuracao { get; set; }

        public virtual NFCe_Configuracao nfce_configuracao { get; set; }
    }
}
