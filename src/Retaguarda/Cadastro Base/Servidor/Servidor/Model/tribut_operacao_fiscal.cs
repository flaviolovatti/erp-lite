namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.tribut_operacao_fiscal")]
    public partial class tribut_operacao_fiscal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tribut_operacao_fiscal()
        {
            clientes = new HashSet<Cliente>();
            nfe_cabecalho = new HashSet<nfe_cabecalho>();
            tribut_configura_of_gt = new HashSet<tribut_configura_of_gt>();
            tribut_iss = new HashSet<tribut_iss>();
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
        public virtual ICollection<nfe_cabecalho> nfe_cabecalho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tribut_configura_of_gt> tribut_configura_of_gt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tribut_iss> tribut_iss { get; set; }
    }
}
