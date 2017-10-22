namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cte_documento_anterior")]
    public partial class cte_documento_anterior
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cte_documento_anterior()
        {
            cte_documento_anterior_id = new HashSet<cte_documento_anterior_id>();
        }

        public int id { get; set; }

        public int id_cte_cabecalho { get; set; }

        [StringLength(14)]
        public string cnpj { get; set; }

        [StringLength(11)]
        public string cpf { get; set; }

        [StringLength(20)]
        public string ie { get; set; }

        [StringLength(2)]
        public string uf { get; set; }

        [StringLength(60)]
        public string nome { get; set; }

        public virtual cte_cabecalho cte_cabecalho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cte_documento_anterior_id> cte_documento_anterior_id { get; set; }
    }
}
