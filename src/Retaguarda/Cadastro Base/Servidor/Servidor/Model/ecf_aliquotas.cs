namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.ecf_aliquotas")]
    public partial class ecf_aliquotas
    {
        public int id { get; set; }

        [StringLength(10)]
        public string totalizador_parcial { get; set; }

        [StringLength(4)]
        public string ecf_icms_st { get; set; }

        [StringLength(1)]
        public string paf_p_st { get; set; }
    }
}
