namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfe_transporte_volume_lacre")]
    public partial class NFe_TransporteVolumeLacre
    {
        public int id { get; set; }

        public int id_nfe_transporte_volume { get; set; }

        [StringLength(60)]
        public string numero { get; set; }

        public virtual NFe_TransporteVolume nfe_transporte_volume { get; set; }
    }
}
