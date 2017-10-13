namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VENDA_ROMANEIO_ENTREGA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VENDA_ROMANEIO_ENTREGA()
        {
            VENDA_CABECALHO = new HashSet<VENDA_CABECALHO>();
        }

        public int ID { get; set; }

        public int ID_COLABORADOR { get; set; }

        [StringLength(100)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_EMISSAO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_PREVISTA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_SAIDA { get; set; }

        [StringLength(1)]
        public string SITUACAO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_ENCERRAMENTO { get; set; }

        [Column(TypeName = "text")]
        public string OBSERVACAO { get; set; }

        public virtual COLABORADOR COLABORADOR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENDA_CABECALHO> VENDA_CABECALHO { get; set; }
    }
}
