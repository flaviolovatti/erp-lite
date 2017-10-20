namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.tabela_preco")]
    public partial class TabelaPreco
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TabelaPreco()
        {
            clientes = new HashSet<Cliente>();
            comissao_objetivo = new HashSet<ComissaoObjetivo>();
            tabela_preco_produto = new HashSet<TabelaPrecoProduto>();
            vendedors = new HashSet<Vendedor>();
        }

        public int id { get; set; }

        [StringLength(100)]
        public string nome { get; set; }

        public decimal? coeficiente { get; set; }

        [StringLength(1)]
        public string principal { get; set; }

        [StringLength(1)]
        public string base_custo { get; set; }

        [StringLength(1)]
        public string metodo_utilizacao { get; set; }

        public decimal? comissao_vendedor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cliente> clientes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComissaoObjetivo> comissao_objetivo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TabelaPrecoProduto> tabela_preco_produto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vendedor> vendedors { get; set; }
    }
}
