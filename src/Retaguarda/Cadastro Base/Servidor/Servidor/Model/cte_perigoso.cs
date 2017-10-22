namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cte_perigoso")]
    public partial class cte_perigoso
    {
        public int id { get; set; }

        public int id_cte_cabecalho { get; set; }

        [StringLength(4)]
        public string numero_onu { get; set; }

        [StringLength(150)]
        public string nome_apropriado { get; set; }

        [StringLength(40)]
        public string classe_risco { get; set; }

        [StringLength(6)]
        public string grupo_embalagem { get; set; }

        [StringLength(20)]
        public string quantidade_total_produto { get; set; }

        [StringLength(60)]
        public string quantidade_tipo_volume { get; set; }

        [StringLength(6)]
        public string ponto_fulgor { get; set; }

        public virtual cte_cabecalho cte_cabecalho { get; set; }
    }
}
