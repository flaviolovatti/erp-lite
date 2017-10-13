namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AUDITORIA")]
    public partial class AUDITORIA
    {
        public int ID { get; set; }

        public int ID_USUARIO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_REGISTRO { get; set; }

        [StringLength(8)]
        public string HORA_REGISTRO { get; set; }

        [StringLength(50)]
        public string JANELA_CONTROLLER { get; set; }

        [StringLength(50)]
        public string ACAO { get; set; }

        [Column(TypeName = "text")]
        public string CONTEUDO { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
