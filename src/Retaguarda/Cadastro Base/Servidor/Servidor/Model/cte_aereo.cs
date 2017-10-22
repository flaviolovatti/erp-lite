namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cte_aereo")]
    public partial class cte_aereo
    {
        public int id { get; set; }

        public int id_cte_cabecalho { get; set; }

        public int? numero_minuta { get; set; }

        public int? numero_conhecimento { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_prevista_entrega { get; set; }

        [StringLength(20)]
        public string id_emissor { get; set; }

        [StringLength(14)]
        public string id_interna_tomador { get; set; }

        [StringLength(1)]
        public string tarifa_classe { get; set; }

        [StringLength(4)]
        public string tarifa_codigo { get; set; }

        public decimal? tarifa_valor { get; set; }

        [StringLength(14)]
        public string carga_dimensao { get; set; }

        public int? carga_informacao_manuseio { get; set; }

        [StringLength(3)]
        public string carga_especial { get; set; }

        public virtual cte_cabecalho cte_cabecalho { get; set; }
    }
}
