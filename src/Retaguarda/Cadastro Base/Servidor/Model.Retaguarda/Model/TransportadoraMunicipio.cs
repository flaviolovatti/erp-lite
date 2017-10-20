namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.transportadora_municipio")]
    public partial class TransportadoraMunicipio
    {
        public int id { get; set; }

        public int id_municipio { get; set; }

        public int id_transportadora { get; set; }

        public virtual Municipio municipio { get; set; }

        public virtual Transportadora transportadora { get; set; }
    }
}
