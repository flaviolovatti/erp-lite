namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFCE_POSICAO_COMPONENTES
    {
        public int ID { get; set; }

        public int ID_NFCE_RESOLUCAO { get; set; }

        [StringLength(100)]
        public string NOME { get; set; }

        public int? ALTURA { get; set; }

        public int? LARGURA { get; set; }

        public int? TOPO { get; set; }

        public int? ESQUERDA { get; set; }

        public int? TAMANHO_FONTE { get; set; }

        [StringLength(250)]
        public string TEXTO { get; set; }

        public virtual NFCE_RESOLUCAO NFCE_RESOLUCAO { get; set; }
    }
}
