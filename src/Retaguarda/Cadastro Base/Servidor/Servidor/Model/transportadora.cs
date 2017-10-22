namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.transportadora")]
    public partial class transportadora
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public transportadora()
        {
            nfe_transporte = new HashSet<nfe_transporte>();
            transportadora_municipio = new HashSet<transportadora_municipio>();
            venda_cabecalho = new HashSet<venda_cabecalho>();
            venda_frete = new HashSet<venda_frete>();
            venda_orcamento_cabecalho = new HashSet<venda_orcamento_cabecalho>();
        }

        public int id { get; set; }

        public int id_pessoa { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_cadastro { get; set; }

        public string observacao { get; set; }

        [StringLength(30)]
        public string classificacao_contabil_conta { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nfe_transporte> nfe_transporte { get; set; }

        public virtual Pessoa pessoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<transportadora_municipio> transportadora_municipio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<venda_cabecalho> venda_cabecalho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<venda_frete> venda_frete { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<venda_orcamento_cabecalho> venda_orcamento_cabecalho { get; set; }
    }
}
