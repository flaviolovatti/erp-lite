namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.indice_economico")]
    public partial class indice_economico
    {
        public int id { get; set; }

        public int id_pais { get; set; }

        [StringLength(50)]
        public string sigla { get; set; }

        [StringLength(50)]
        public string nome { get; set; }

        public string descricao { get; set; }

        public virtual Pais pai { get; set; }
    }
}
