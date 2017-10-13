namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SOCIO")]
    public partial class SOCIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SOCIO()
        {
            SOCIO_DEPENDENTE = new HashSet<SOCIO_DEPENDENTE>();
            SOCIO_PARTICIPACAO_SOCIETARIA = new HashSet<SOCIO_PARTICIPACAO_SOCIETARIA>();
        }

        public int ID { get; set; }

        public int ID_QUADRO_SOCIETARIO { get; set; }

        [StringLength(100)]
        public string LOGRADOURO { get; set; }

        public int? NUMERO { get; set; }

        [StringLength(100)]
        public string COMPLEMENTO { get; set; }

        [StringLength(100)]
        public string BAIRRO { get; set; }

        [StringLength(100)]
        public string MUNICIPIO { get; set; }

        [StringLength(2)]
        public string UF { get; set; }

        [StringLength(8)]
        public string CEP { get; set; }

        [StringLength(10)]
        public string FONE { get; set; }

        [StringLength(10)]
        public string CELULAR { get; set; }

        [StringLength(250)]
        public string EMAIL { get; set; }

        public decimal? PARTICIPACAO { get; set; }

        public int? QUOTAS { get; set; }

        public decimal? INTEGRALIZAR { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_INGRESSO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_SAIDA { get; set; }

        public virtual QUADRO_SOCIETARIO QUADRO_SOCIETARIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SOCIO_DEPENDENTE> SOCIO_DEPENDENTE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SOCIO_PARTICIPACAO_SOCIETARIA> SOCIO_PARTICIPACAO_SOCIETARIA { get; set; }
    }
}
