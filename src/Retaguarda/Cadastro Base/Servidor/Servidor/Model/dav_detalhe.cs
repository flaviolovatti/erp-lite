namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.dav_detalhe")]
    public partial class dav_detalhe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dav_detalhe()
        {
            dav_detalhe_alteracao = new HashSet<dav_detalhe_alteracao>();
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

        public virtual dav_cabecalho dav_cabecalho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dav_detalhe_alteracao> dav_detalhe_alteracao { get; set; }

        public virtual Produto produto { get; set; }
    }
}
