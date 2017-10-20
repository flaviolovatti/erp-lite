namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.dav_detalhe")]
    public partial class DAV_Detalhe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DAV_Detalhe()
        {
            dav_detalhe_alteracao = new HashSet<DAV_DetalheAlteracao>();
        }

        public int id { get; set; }

        public int id_produto { get; set; }

        public int id_dav_cabecalho { get; set; }

        [StringLength(10)]
        public string numero_dav { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_emissao { get; set; }

        public int? item { get; set; }

        public decimal? quantidade { get; set; }

        public decimal? valor_unitario { get; set; }

        public decimal? valor_total { get; set; }

        [StringLength(1)]
        public string cancelado { get; set; }

        [StringLength(1)]
        public string mescla_produto { get; set; }

        [StringLength(14)]
        public string gtin_produto { get; set; }

        [StringLength(100)]
        public string nome_produto { get; set; }

        [StringLength(10)]
        public string unidade_produto { get; set; }

        [StringLength(10)]
        public string totalizador_parcial { get; set; }

        [StringLength(32)]
        public string logss { get; set; }

        public string servico_formula { get; set; }

        public virtual DAV_Cabecalho dav_cabecalho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DAV_DetalheAlteracao> dav_detalhe_alteracao { get; set; }

        public virtual Produto produto { get; set; }
    }
}
