namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.vendedor")]
    public partial class vendedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public vendedor()
        {
            nfe_cabecalho = new HashSet<nfe_cabecalho>();
            venda_cabecalho = new HashSet<venda_cabecalho>();
            venda_comissao = new HashSet<venda_comissao>();
            venda_orcamento_cabecalho = new HashSet<venda_orcamento_cabecalho>();
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

        public virtual comissao_perfil comissao_perfil { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nfe_cabecalho> nfe_cabecalho { get; set; }

        public virtual regiao regiao { get; set; }

        public virtual tabela_preco tabela_preco { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<venda_cabecalho> venda_cabecalho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<venda_comissao> venda_comissao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<venda_orcamento_cabecalho> venda_orcamento_cabecalho { get; set; }
    }
}
