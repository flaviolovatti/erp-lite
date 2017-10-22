namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfe_nf_referenciada")]
    public partial class NFe_NotaFiscalReferenciada
    {
        public int id { get; set; }

        public int id_nfe_cabecalho { get; set; }

        public int? codigo_uf { get; set; }

        [StringLength(4)]
        public string ano_mes { get; set; }

        [StringLength(14)]
        public string cnpj { get; set; }

        [StringLength(2)]
        public string modelo { get; set; }

        [StringLength(3)]
        public string serie { get; set; }

        public int? numero_nf { get; set; }

        public virtual NFe_Cabecalho nfe_cabecalho { get; set; }
    }
}
