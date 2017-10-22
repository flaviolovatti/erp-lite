namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cte_rodoviario_motorista")]
    public partial class CTe_RodoviarioMotorista
    {
        public int id { get; set; }

        public int id_cte_rodoviario { get; set; }

        [StringLength(60)]
        public string nome { get; set; }

        [StringLength(11)]
        public string cpf { get; set; }

        public virtual CTe_Rodoviario cte_rodoviario { get; set; }
    }
}
