namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cte_rodoviario_pedagio")]
    public partial class CTe_RodoviarioPedagio
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

        public virtual CTe_Rodoviario cte_rodoviario { get; set; }
    }
}
