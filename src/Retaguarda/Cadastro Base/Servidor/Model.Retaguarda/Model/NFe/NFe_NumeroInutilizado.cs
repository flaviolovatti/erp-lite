namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfe_numero_inutilizado")]
    public partial class NFe_NumeroInutilizado
    {
        public int id { get; set; }

        public int id_empresa { get; set; }

        [StringLength(3)]
        public string serie { get; set; }

        public int? numero { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_inutilizacao { get; set; }

        public string observacao { get; set; }

        public virtual Empresa empresa { get; set; }
    }
}
