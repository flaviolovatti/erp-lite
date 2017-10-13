namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INDICE_ECONOMICO
    {
        public int ID { get; set; }

        public int ID_PAIS { get; set; }

        [StringLength(50)]
        public string SIGLA { get; set; }

        [StringLength(50)]
        public string NOME { get; set; }

        [Column(TypeName = "text")]
        public string DESCRICAO { get; set; }

        public virtual PAIS PAIS { get; set; }
    }
}
