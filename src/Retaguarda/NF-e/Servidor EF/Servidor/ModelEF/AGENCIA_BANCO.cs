namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AGENCIA_BANCO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AGENCIA_BANCO()
        {
            CONTA_CAIXA = new HashSet<CONTA_CAIXA>();
        }

        public int ID { get; set; }

        public int ID_BANCO { get; set; }

        [StringLength(10)]
        public string CODIGO { get; set; }

        [StringLength(1)]
        public string DIGITO { get; set; }

        [StringLength(100)]
        public string NOME { get; set; }

        [StringLength(100)]
        public string LOGRADOURO { get; set; }

        [StringLength(10)]
        public string NUMERO { get; set; }

        [StringLength(8)]
        public string CEP { get; set; }

        [StringLength(60)]
        public string BAIRRO { get; set; }

        [StringLength(60)]
        public string MUNICIPIO { get; set; }

        [StringLength(2)]
        public string UF { get; set; }

        [StringLength(14)]
        public string TELEFONE { get; set; }

        [StringLength(30)]
        public string GERENTE { get; set; }

        [StringLength(30)]
        public string CONTATO { get; set; }

        [Column(TypeName = "text")]
        public string OBSERVACAO { get; set; }

        public virtual BANCO BANCO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTA_CAIXA> CONTA_CAIXA { get; set; }
    }
}
