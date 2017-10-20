namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.transportadora")]
    public partial class Transportadora
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Transportadora()
        {
            nfe_transporte = new HashSet<NFe_Transporte>();
            transportadora_municipio = new HashSet<TransportadoraMunicipio>();
            venda_cabecalho = new HashSet<VendaCabecalho>();
            venda_frete = new HashSet<VendaFrete>();
            venda_orcamento_cabecalho = new HashSet<VendaOrcamentoCabecalho>();
        }

        public int id { get; set; }

        public int id_pessoa { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_cadastro { get; set; }

        public string observacao { get; set; }

        [StringLength(30)]
        public string classificacao_contabil_conta { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_Transporte> nfe_transporte { get; set; }

        public virtual Pessoa pessoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransportadoraMunicipio> transportadora_municipio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendaCabecalho> venda_cabecalho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendaFrete> venda_frete { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendaOrcamentoCabecalho> venda_orcamento_cabecalho { get; set; }
    }
}
