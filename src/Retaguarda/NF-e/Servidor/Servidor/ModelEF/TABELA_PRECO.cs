namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TABELA_PRECO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TABELA_PRECO()
        {
            CLIENTE = new HashSet<CLIENTE>();
            COMISSAO_OBJETIVO = new HashSet<COMISSAO_OBJETIVO>();
            TABELA_PRECO_PRODUTO = new HashSet<TABELA_PRECO_PRODUTO>();
            VENDEDOR = new HashSet<VENDEDOR>();
        }

        public int ID { get; set; }

        [StringLength(100)]
        public string NOME { get; set; }

        public decimal? COEFICIENTE { get; set; }

        [StringLength(1)]
        public string PRINCIPAL { get; set; }

        [StringLength(1)]
        public string BASE_CUSTO { get; set; }

        [StringLength(1)]
        public string METODO_UTILIZACAO { get; set; }

        public decimal? COMISSAO_VENDEDOR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENTE> CLIENTE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMISSAO_OBJETIVO> COMISSAO_OBJETIVO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TABELA_PRECO_PRODUTO> TABELA_PRECO_PRODUTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENDEDOR> VENDEDOR { get; set; }
    }
}
