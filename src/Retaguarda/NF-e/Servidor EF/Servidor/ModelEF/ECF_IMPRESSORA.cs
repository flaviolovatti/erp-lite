namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ECF_IMPRESSORA
    {
        public int ID { get; set; }

        public int? NUMERO { get; set; }

        [StringLength(10)]
        public string CODIGO { get; set; }

        [StringLength(25)]
        public string SERIE { get; set; }

        [StringLength(250)]
        public string IDENTIFICACAO { get; set; }

        [StringLength(2)]
        public string MC { get; set; }

        [StringLength(2)]
        public string MD { get; set; }

        [StringLength(2)]
        public string VR { get; set; }

        [StringLength(7)]
        public string TIPO { get; set; }

        [StringLength(30)]
        public string MARCA { get; set; }

        [StringLength(30)]
        public string MODELO { get; set; }

        [StringLength(30)]
        public string MODELO_ACBR { get; set; }

        [StringLength(2)]
        public string MODELO_DOCUMENTO_FISCAL { get; set; }

        [StringLength(30)]
        public string VERSAO { get; set; }

        [StringLength(1)]
        public string LE { get; set; }

        [StringLength(1)]
        public string LEF { get; set; }

        [StringLength(1)]
        public string MFD { get; set; }

        [StringLength(1)]
        public string LACRE_NA_MFD { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_INSTALACAO_SB { get; set; }

        [StringLength(8)]
        public string HORA_INSTALACAO_SB { get; set; }

        [StringLength(60)]
        public string DOCTO { get; set; }

        [Column("ECF_IMPRESSORA")]
        [StringLength(3)]
        public string ECF_IMPRESSORA1 { get; set; }
    }
}
