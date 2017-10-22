namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfe_det_especifico_medicamento")]
    public partial class nfe_det_especifico_medicamento
    {
        public int id { get; set; }

        public int id_nfe_detalhe { get; set; }

        public decimal? preco_maximo_consumidor { get; set; }

        [StringLength(13)]
        public string codigo_produto_anvisa { get; set; }

        public virtual nfe_detalhe nfe_detalhe { get; set; }
    }
}
