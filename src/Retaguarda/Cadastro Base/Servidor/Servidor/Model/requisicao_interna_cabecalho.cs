namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.requisicao_interna_cabecalho")]
    public partial class requisicao_interna_cabecalho
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public requisicao_interna_cabecalho()
        {
            requisicao_interna_detalhe = new HashSet<requisicao_interna_detalhe>();
        }

        public int id { get; set; }

        public int id_colaborador { get; set; }

        [Column(TypeName = "date")]
        public DateTime data_requisicao { get; set; }

        [StringLength(1)]
        public string situacao { get; set; }

        public virtual Colaborador colaborador { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<requisicao_interna_detalhe> requisicao_interna_detalhe { get; set; }
    }
}
