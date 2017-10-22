namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.compra_requisicao_detalhe")]
    public partial class compra_requisicao_detalhe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public compra_requisicao_detalhe()
        {
            compra_req_cotacao_detalhe = new HashSet<compra_req_cotacao_detalhe>();
        }

        public int id { get; set; }

        public int id_compra_requisicao { get; set; }

        public int id_produto { get; set; }

        public decimal? quantidade { get; set; }

        public decimal? quantidade_cotada { get; set; }

        [StringLength(1)]
        public string item_cotado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<compra_req_cotacao_detalhe> compra_req_cotacao_detalhe { get; set; }

        public virtual compra_requisicao compra_requisicao { get; set; }

        public virtual Produto produto { get; set; }
    }
}
