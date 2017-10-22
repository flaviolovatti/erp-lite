namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.tribut_operacao_fiscal")]
    public partial class Tribut_OperacaoFiscal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tribut_OperacaoFiscal()
        {
            clientes = new HashSet<Cliente>();
            nfe_cabecalho = new HashSet<NFe_Cabecalho>();
            tribut_configura_of_gt = new HashSet<Tribut_ConfiguraOperacaoFiscalGrupoTributario>();
            tribut_iss = new HashSet<Tribut_ISS>();
        }

        public int id { get; set; }

        public int id_empresa { get; set; }

        [StringLength(100)]
        public string descricao { get; set; }

        [StringLength(100)]
        public string descricao_na_nf { get; set; }

        public int? cfop { get; set; }

        public string observacao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cliente> clientes { get; set; }

        public virtual Empresa empresa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_Cabecalho> nfe_cabecalho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tribut_ConfiguraOperacaoFiscalGrupoTributario> tribut_configura_of_gt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tribut_ISS> tribut_iss { get; set; }
    }
}
