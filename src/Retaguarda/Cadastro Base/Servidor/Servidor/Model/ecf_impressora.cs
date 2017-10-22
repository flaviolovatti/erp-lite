namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.ecf_impressora")]
    public partial class ecf_impressora
    {
        public int id { get; set; }

        public int? numero { get; set; }

        [StringLength(10)]
        public string codigo { get; set; }

        [StringLength(25)]
        public string serie { get; set; }

        [StringLength(250)]
        public string identificacao { get; set; }

        [StringLength(2)]
        public string mc { get; set; }

        [StringLength(2)]
        public string md { get; set; }

        [StringLength(2)]
        public string vr { get; set; }

        [StringLength(7)]
        public string tipo { get; set; }

        [StringLength(30)]
        public string marca { get; set; }

        [StringLength(30)]
        public string modelo { get; set; }

        [StringLength(30)]
        public string modelo_acbr { get; set; }

        [StringLength(2)]
        public string modelo_documento_fiscal { get; set; }

        [StringLength(30)]
        public string versao { get; set; }

        [StringLength(1)]
        public string le { get; set; }

        [StringLength(1)]
        public string lef { get; set; }

        [StringLength(1)]
        public string mfd { get; set; }

        [StringLength(1)]
        public string lacre_na_mfd { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_instalacao_sb { get; set; }

        [StringLength(8)]
        public string hora_instalacao_sb { get; set; }

        [StringLength(60)]
        public string docto { get; set; }

        [Column("ecf_impressora")]
        [StringLength(3)]
        public string ecf_impressora1 { get; set; }
    }
}
