namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.ecf_r03")]
    public partial class ecf_r03
    {
        public int id { get; set; }

        [StringLength(30)]
        public string nome_caixa { get; set; }

        public int? id_gerado_caixa { get; set; }

        public int? id_empresa { get; set; }

        public int? id_r02 { get; set; }

        [StringLength(20)]
        public string serie_ecf { get; set; }

        [StringLength(10)]
        public string totalizador_parcial { get; set; }

        public decimal? valor_acumulado { get; set; }

        public int? crz { get; set; }

        [StringLength(32)]
        public string logss { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_sincronizacao { get; set; }

        [StringLength(8)]
        public string hora_sincronizacao { get; set; }
    }
}
