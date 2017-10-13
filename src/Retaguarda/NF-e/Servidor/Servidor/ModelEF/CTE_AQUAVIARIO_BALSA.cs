namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CTE_AQUAVIARIO_BALSA
    {
        public int ID { get; set; }

        public int ID_CTE_AQUAVIARIO { get; set; }

        [StringLength(60)]
        public string ID_BALSA { get; set; }

        public int? NUMERO_VIAGEM { get; set; }

        [StringLength(1)]
        public string DIRECAO { get; set; }

        [StringLength(60)]
        public string PORTO_EMBARQUE { get; set; }

        [StringLength(60)]
        public string PORTO_TRANSBORDO { get; set; }

        [StringLength(60)]
        public string PORTO_DESTINO { get; set; }

        public int? TIPO_NAVEGACAO { get; set; }

        [StringLength(10)]
        public string IRIN { get; set; }

        public virtual CTE_AQUAVIARIO CTE_AQUAVIARIO { get; set; }
    }
}
