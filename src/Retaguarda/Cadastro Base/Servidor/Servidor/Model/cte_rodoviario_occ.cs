namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cte_rodoviario_occ")]
    public partial class cte_rodoviario_occ
    {
        public int id { get; set; }

        public int id_cte_rodoviario { get; set; }

        [StringLength(3)]
        public string serie { get; set; }

        public int? numero { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_emissao { get; set; }

        [StringLength(14)]
        public string cnpj { get; set; }

        [StringLength(10)]
        public string codigo_interno { get; set; }

        [StringLength(14)]
        public string ie { get; set; }

        [StringLength(2)]
        public string uf { get; set; }

        [StringLength(14)]
        public string telefone { get; set; }

        public virtual cte_rodoviario cte_rodoviario { get; set; }
    }
}
