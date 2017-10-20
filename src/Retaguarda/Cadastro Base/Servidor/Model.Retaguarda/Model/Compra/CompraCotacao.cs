namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.compra_cotacao")]
    public partial class CompraCotacao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CompraCotacao()
        {
            compra_fornecedor_cotacao = new HashSet<CompraFornecedorCotacao>();
            compra_req_cotacao_detalhe = new HashSet<CompraRequisicaoCotacaoDetalhe>();
        }

        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_cotacao { get; set; }

        [StringLength(100)]
        public string descricao { get; set; }

        [StringLength(1)]
        public string situacao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompraFornecedorCotacao> compra_fornecedor_cotacao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompraRequisicaoCotacaoDetalhe> compra_req_cotacao_detalhe { get; set; }
    }
}
