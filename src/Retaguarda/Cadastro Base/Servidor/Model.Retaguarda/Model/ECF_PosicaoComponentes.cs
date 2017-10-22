namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.ecf_posicao_componentes")]
    public partial class ECF_PosicaoComponentes
    {
        public int id { get; set; }

        [StringLength(30)]
        public string nome_caixa { get; set; }

        public int? id_gerado_caixa { get; set; }

        public int? id_empresa { get; set; }

        public int? id_ecf_resolucao { get; set; }

        [StringLength(100)]
        public string nome { get; set; }

        public int? altura { get; set; }

        public int? largura { get; set; }

        public int? topo { get; set; }

        public int? esquerda { get; set; }

        public int? tamanho_fonte { get; set; }

        [StringLength(250)]
        public string texto { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_sincronizacao { get; set; }

        [StringLength(8)]
        public string hora_sincronizacao { get; set; }
    }
}
