namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.ecf_documentos_emitidos")]
    public partial class ECF_DocumentosEmitidos
    {
        public int id { get; set; }

        [StringLength(30)]
        public string nome_caixa { get; set; }

        public int? id_gerado_caixa { get; set; }

        public int? id_empresa { get; set; }

        public int? id_ecf_movimento { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_emissao { get; set; }

        [StringLength(8)]
        public string hora_emissao { get; set; }

        [StringLength(2)]
        public string tipo { get; set; }

        public int? coo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_sincronizacao { get; set; }

        [StringLength(8)]
        public string hora_sincronizacao { get; set; }
    }
}
