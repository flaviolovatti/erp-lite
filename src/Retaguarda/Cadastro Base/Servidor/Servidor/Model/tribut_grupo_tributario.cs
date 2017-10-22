namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.tribut_grupo_tributario")]
    public partial class tribut_grupo_tributario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tribut_grupo_tributario()
        {
            produtoes = new HashSet<Produto>();
            tribut_configura_of_gt = new HashSet<tribut_configura_of_gt>();
        }

        public int id { get; set; }

        public int id_empresa { get; set; }

        [StringLength(100)]
        public string descricao { get; set; }

        [StringLength(1)]
        public string origem_mercadoria { get; set; }

        public string observacao { get; set; }

        public virtual Empresa empresa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Produto> produtoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tribut_configura_of_gt> tribut_configura_of_gt { get; set; }
    }
}
