namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.vendedor")]
    public partial class Vendedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vendedor()
        {
            nfe_cabecalho = new HashSet<NFe_Cabecalho>();
            venda_cabecalho = new HashSet<VendaCabecalho>();
            venda_comissao = new HashSet<VendaComissao>();
            venda_orcamento_cabecalho = new HashSet<VendaOrcamentoCabecalho>();
        }

        public int id { get; set; }

        public int? id_tabela_preco { get; set; }

        public int? id_regiao { get; set; }

        public int? id_comissao_perfil { get; set; }

        public int? id_colaborador { get; set; }

        public decimal? comissao { get; set; }

        public decimal? meta_vendas { get; set; }

        [StringLength(1)]
        public string gerente { get; set; }

        public decimal? taxa_gerente { get; set; }

        public virtual Colaborador colaborador { get; set; }

        public virtual ComissaoPerfil comissao_perfil { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_Cabecalho> nfe_cabecalho { get; set; }

        public virtual Regiao regiao { get; set; }

        public virtual TabelaPreco tabela_preco { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendaCabecalho> venda_cabecalho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendaComissao> venda_comissao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendaOrcamentoCabecalho> venda_orcamento_cabecalho { get; set; }
    }
}
