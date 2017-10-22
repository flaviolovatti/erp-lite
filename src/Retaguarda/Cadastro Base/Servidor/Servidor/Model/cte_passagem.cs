namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cte_passagem")]
    public partial class cte_passagem
    {
        public int id { get; set; }

        public int id_cte_cabecalho { get; set; }

        [StringLength(15)]
        public string sigla_passagem { get; set; }

        [StringLength(15)]
        public string sigla_destino { get; set; }

        [StringLength(10)]
        public string rota { get; set; }

        public virtual cte_cabecalho cte_cabecalho { get; set; }
    }
}
