namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SINDICATO")]
    public partial class SINDICATO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SINDICATO()
        {
            COLABORADOR = new HashSet<COLABORADOR>();
            CONTRIB_SIND_PATRONAL_CAB = new HashSet<CONTRIB_SIND_PATRONAL_CAB>();
            EMPRESA = new HashSet<EMPRESA>();
        }

        public int ID { get; set; }

        [StringLength(100)]
        public string NOME { get; set; }

        public int? CODIGO_BANCO { get; set; }

        public int? CODIGO_AGENCIA { get; set; }

        [StringLength(20)]
        public string CONTA_BANCO { get; set; }

        [StringLength(30)]
        public string CODIGO_CEDENTE { get; set; }

        [StringLength(100)]
        public string LOGRADOURO { get; set; }

        [StringLength(10)]
        public string NUMERO { get; set; }

        [StringLength(100)]
        public string BAIRRO { get; set; }

        public int? MUNICIPIO_IBGE { get; set; }

        [StringLength(2)]
        public string UF { get; set; }

        [StringLength(14)]
        public string FONE1 { get; set; }

        [StringLength(14)]
        public string FONE2 { get; set; }

        [StringLength(100)]
        public string EMAIL { get; set; }

        [StringLength(1)]
        public string TIPO_SINDICATO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_BASE { get; set; }

        public decimal? PISO_SALARIAL { get; set; }

        [StringLength(14)]
        public string CNPJ { get; set; }

        [StringLength(30)]
        public string CLASSIFICACAO_CONTABIL_CONTA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COLABORADOR> COLABORADOR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTRIB_SIND_PATRONAL_CAB> CONTRIB_SIND_PATRONAL_CAB { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPRESA> EMPRESA { get; set; }
    }
}
