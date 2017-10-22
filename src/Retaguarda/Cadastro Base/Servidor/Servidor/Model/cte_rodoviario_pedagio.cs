namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cte_rodoviario_pedagio")]
    public partial class cte_rodoviario_pedagio
    {
        public int id { get; set; }

        public int id_cte_rodoviario { get; set; }

        [StringLength(14)]
        public string cnpj_fornecedor { get; set; }

        [StringLength(20)]
        public string comprovante_compra { get; set; }

        [StringLength(14)]
        public string cnpj_responsavel { get; set; }

        public decimal? valor { get; set; }

        public virtual cte_rodoviario cte_rodoviario { get; set; }
    }
}
