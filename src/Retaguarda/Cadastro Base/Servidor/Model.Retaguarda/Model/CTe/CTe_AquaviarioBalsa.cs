namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cte_aquaviario_balsa")]
    public partial class CTe_AquaviarioBalsa
    {
        public int id { get; set; }

        public int id_cte_aquaviario { get; set; }

        [StringLength(60)]
        public string id_balsa { get; set; }

        public int? numero_viagem { get; set; }

        [StringLength(1)]
        public string direcao { get; set; }

        [StringLength(60)]
        public string porto_embarque { get; set; }

        [StringLength(60)]
        public string porto_transbordo { get; set; }

        [StringLength(60)]
        public string porto_destino { get; set; }

        public int? tipo_navegacao { get; set; }

        [StringLength(10)]
        public string irin { get; set; }

        public virtual CTe_Aquaviario cte_aquaviario { get; set; }
    }
}
