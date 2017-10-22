namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cte_documento_anterior_id")]
    public partial class cte_documento_anterior_id
    {
        public int id { get; set; }

        public int id_cte_documento_anterior { get; set; }

        [StringLength(2)]
        public string tipo { get; set; }

        [StringLength(3)]
        public string serie { get; set; }

        [StringLength(2)]
        public string subserie { get; set; }

        [StringLength(20)]
        public string numero { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_emissao { get; set; }

        [StringLength(44)]
        public string chave_cte { get; set; }

        public virtual cte_documento_anterior cte_documento_anterior { get; set; }
    }
}
