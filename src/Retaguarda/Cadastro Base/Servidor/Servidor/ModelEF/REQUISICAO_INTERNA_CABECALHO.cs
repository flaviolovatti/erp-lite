namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class REQUISICAO_INTERNA_CABECALHO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public REQUISICAO_INTERNA_CABECALHO()
        {
            REQUISICAO_INTERNA_DETALHE = new HashSet<REQUISICAO_INTERNA_DETALHE>();
        }

        public int ID { get; set; }

        public int ID_COLABORADOR { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATA_REQUISICAO { get; set; }

        [StringLength(1)]
        public string SITUACAO { get; set; }

        public virtual COLABORADOR COLABORADOR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REQUISICAO_INTERNA_DETALHE> REQUISICAO_INTERNA_DETALHE { get; set; }
    }
}
