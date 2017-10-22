namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfe_cupom_fiscal_referenciado")]
    public partial class nfe_cupom_fiscal_referenciado
    {
        public int id { get; set; }

        public int id_nfe_cabecalho { get; set; }

        [StringLength(2)]
        public string modelo_documento_fiscal { get; set; }

        public int? numero_ordem_ecf { get; set; }

        public int? coo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_emissao_cupom { get; set; }

        public int? numero_caixa { get; set; }

        [StringLength(21)]
        public string numero_serie_ecf { get; set; }

        public virtual nfe_cabecalho nfe_cabecalho { get; set; }
    }
}
