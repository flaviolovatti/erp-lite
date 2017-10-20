namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nivel_formacao")]
    public partial class NivelFormacao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NivelFormacao()
        {
            colaboradors = new HashSet<Colaborador>();
        }

        public int id { get; set; }

        [StringLength(100)]
        public string nome { get; set; }

        public string descricao { get; set; }

        public int? grau_instrucao_caged { get; set; }

        public int? grau_instrucao_sefip { get; set; }

        public int? grau_instrucao_rais { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Colaborador> colaboradors { get; set; }
    }
}
