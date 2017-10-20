namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.unidade_produto")]
    public partial class UnidadeProduto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UnidadeProduto()
        {
            produtoes = new HashSet<Produto>();
            unidade_conversao = new HashSet<UnidadeConversao>();
        }

        public int id { get; set; }

        [StringLength(10)]
        public string sigla { get; set; }

        public string descricao { get; set; }

        [StringLength(1)]
        public string pode_fracionar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Produto> produtoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UnidadeConversao> unidade_conversao { get; set; }
    }
}
