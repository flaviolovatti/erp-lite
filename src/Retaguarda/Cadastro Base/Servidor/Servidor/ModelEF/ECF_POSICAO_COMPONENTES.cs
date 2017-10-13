namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ECF_POSICAO_COMPONENTES
    {
        public int ID { get; set; }

        [StringLength(30)]
        public string NOME_CAIXA { get; set; }

        public int? ID_GERADO_CAIXA { get; set; }

        public int? ID_EMPRESA { get; set; }

        public int? ID_ECF_RESOLUCAO { get; set; }

        [StringLength(100)]
        public string NOME { get; set; }

        public int? ALTURA { get; set; }

        public int? LARGURA { get; set; }

        public int? TOPO { get; set; }

        public int? ESQUERDA { get; set; }

        public int? TAMANHO_FONTE { get; set; }

        [StringLength(250)]
        public string TEXTO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_SINCRONIZACAO { get; set; }

        [StringLength(8)]
        public string HORA_SINCRONIZACAO { get; set; }
    }
}
