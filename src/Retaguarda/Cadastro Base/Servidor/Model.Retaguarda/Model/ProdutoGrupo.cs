namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.produto_grupo")]
    public partial class ProdutoGrupo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProdutoGrupo()
        {
            produto_subgrupo = new HashSet<ProdutoSubgrupo>();
        }

        public int id { get; set; }

        [StringLength(100)]
        public string nome { get; set; }

        public string descricao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProdutoSubgrupo> produto_subgrupo { get; set; }
    }
}
