namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.sindicato")]
    public partial class sindicato
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sindicato()
        {
            colaboradors = new HashSet<Colaborador>();
            contrib_sind_patronal_cab = new HashSet<contrib_sind_patronal_cab>();
            empresas = new HashSet<Empresa>();
        }

        public int id { get; set; }

        [StringLength(100)]
        public string nome { get; set; }

        public int? codigo_banco { get; set; }

        public int? codigo_agencia { get; set; }

        [StringLength(20)]
        public string conta_banco { get; set; }

        [StringLength(30)]
        public string codigo_cedente { get; set; }

        [StringLength(100)]
        public string logradouro { get; set; }

        [StringLength(10)]
        public string numero { get; set; }

        [StringLength(100)]
        public string bairro { get; set; }

        public int? municipio_ibge { get; set; }

        [StringLength(2)]
        public string uf { get; set; }

        [StringLength(14)]
        public string fone1 { get; set; }

        [StringLength(14)]
        public string fone2 { get; set; }

        [StringLength(100)]
        public string email { get; set; }

        [StringLength(1)]
        public string tipo_sindicato { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_base { get; set; }

        public decimal? piso_salarial { get; set; }

        [StringLength(14)]
        public string cnpj { get; set; }

        [StringLength(30)]
        public string classificacao_contabil_conta { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Colaborador> colaboradors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<contrib_sind_patronal_cab> contrib_sind_patronal_cab { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empresa> empresas { get; set; }
    }
}
