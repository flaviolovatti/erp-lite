namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.transportadora_municipio")]
    public partial class transportadora_municipio
    {
        public int id { get; set; }

        public int id_municipio { get; set; }

        public int id_transportadora { get; set; }

        public virtual municipio municipio { get; set; }

        public virtual transportadora transportadora { get; set; }
    }
}
