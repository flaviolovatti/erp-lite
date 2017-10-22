namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfce_configuracao_leitor_ser")]
    public partial class nfce_configuracao_leitor_ser
    {
        public int id { get; set; }

        public int id_nfce_configuracao { get; set; }

        [StringLength(1)]
        public string usa { get; set; }

        [StringLength(4)]
        public string porta { get; set; }

        public int? baud { get; set; }

        public int? hand_shake { get; set; }

        public int? parity { get; set; }

        public int? stop_bits { get; set; }

        public int? data_bits { get; set; }

        public int? intervalo { get; set; }

        [StringLength(1)]
        public string usar_fila { get; set; }

        [StringLength(1)]
        public string hard_flow { get; set; }

        [StringLength(1)]
        public string soft_flow { get; set; }

        [StringLength(20)]
        public string sufixo { get; set; }

        [StringLength(1)]
        public string excluir_sufixo { get; set; }

        public virtual nfce_configuracao nfce_configuracao { get; set; }
    }
}
