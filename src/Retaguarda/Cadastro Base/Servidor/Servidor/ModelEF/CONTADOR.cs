namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONTADOR")]
    public partial class CONTADOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CONTADOR()
        {
            EMPRESA = new HashSet<EMPRESA>();
        }

        public int ID { get; set; }

        [StringLength(150)]
        public string NOME { get; set; }

        [StringLength(11)]
        public string CPF { get; set; }

        [StringLength(14)]
        public string CNPJ { get; set; }

        [StringLength(15)]
        public string INSCRICAO_CRC { get; set; }

        [StringLength(2)]
        public string UF_CRC { get; set; }

        [StringLength(14)]
        public string FONE { get; set; }

        [StringLength(14)]
        public string FAX { get; set; }

        [StringLength(100)]
        public string LOGRADOURO { get; set; }

        [StringLength(10)]
        public string NUMERO { get; set; }

        [StringLength(100)]
        public string COMPLEMENTO { get; set; }

        [StringLength(60)]
        public string BAIRRO { get; set; }

        [StringLength(60)]
        public string CIDADE { get; set; }

        [StringLength(8)]
        public string CEP { get; set; }

        public int? MUNICIPIO_IBGE { get; set; }

        [StringLength(2)]
        public string UF { get; set; }

        [StringLength(250)]
        public string EMAIL { get; set; }

        [StringLength(250)]
        public string SITE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPRESA> EMPRESA { get; set; }
    }
}
