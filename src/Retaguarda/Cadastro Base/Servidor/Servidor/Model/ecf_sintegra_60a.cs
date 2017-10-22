namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.ecf_sintegra_60a")]
    public partial class ecf_sintegra_60a
    {
        public int id { get; set; }

        [StringLength(8)]
        public string nome_caixa { get; set; }

        public int? id_gerado_caixa { get; set; }

        public int? id_empresa { get; set; }

        public int? id_sintegra_60m { get; set; }

        [StringLength(4)]
        public string situacao_tributaria { get; set; }

        public decimal? valor { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_sincronizacao { get; set; }

        [StringLength(32)]
        public string hora_sincronizacao { get; set; }
    }
}
