namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfce_posicao_componentes")]
    public partial class nfce_posicao_componentes
    {
        public int id { get; set; }

        public int id_nfce_resolucao { get; set; }

        [StringLength(100)]
        public string nome { get; set; }

        public int? altura { get; set; }

        public int? largura { get; set; }

        public int? topo { get; set; }

        public int? esquerda { get; set; }

        public int? tamanho_fonte { get; set; }

        [StringLength(250)]
        public string texto { get; set; }

        public virtual nfce_resolucao nfce_resolucao { get; set; }
    }
}
