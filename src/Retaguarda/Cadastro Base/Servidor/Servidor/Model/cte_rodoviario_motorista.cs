namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cte_rodoviario_motorista")]
    public partial class cte_rodoviario_motorista
    {
        public int id { get; set; }

        public int id_cte_rodoviario { get; set; }

        [StringLength(60)]
        public string nome { get; set; }

        [StringLength(11)]
        public string cpf { get; set; }

        public virtual cte_rodoviario cte_rodoviario { get; set; }
    }
}
