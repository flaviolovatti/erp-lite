namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NOTA_FISCAL_TIPO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NOTA_FISCAL_TIPO()
        {
            VENDA_CABECALHO = new HashSet<VENDA_CABECALHO>();
        }

        public int ID { get; set; }

        public int ID_NOTA_FISCAL_MODELO { get; set; }

        public int ID_EMPRESA { get; set; }

        [StringLength(50)]
        public string NOME { get; set; }

        [Column(TypeName = "text")]
        public string DESCRICAO { get; set; }

        [StringLength(3)]
        public string SERIE { get; set; }

        [StringLength(3)]
        public string SERIE_SCAN { get; set; }

        public int? ULTIMO_NUMERO { get; set; }

        public virtual EMPRESA EMPRESA { get; set; }

        public virtual NOTA_FISCAL_MODELO NOTA_FISCAL_MODELO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENDA_CABECALHO> VENDA_CABECALHO { get; set; }
    }
}
