namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.compra_cotacao")]
    public partial class compra_cotacao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public compra_cotacao()
        {
            compra_fornecedor_cotacao = new HashSet<compra_fornecedor_cotacao>();
            compra_req_cotacao_detalhe = new HashSet<compra_req_cotacao_detalhe>();
        }

        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_cotacao { get; set; }

        [StringLength(100)]
        public string descricao { get; set; }

        [StringLength(1)]
        public string situacao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<compra_fornecedor_cotacao> compra_fornecedor_cotacao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<compra_req_cotacao_detalhe> compra_req_cotacao_detalhe { get; set; }
    }
}
