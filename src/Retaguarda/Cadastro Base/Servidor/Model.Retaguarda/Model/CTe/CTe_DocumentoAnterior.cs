namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cte_documento_anterior")]
    public partial class CTe_DocumentoAnterior
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CTe_DocumentoAnterior()
        {
            cte_documento_anterior_id = new HashSet<CTe_DocumentoAnteriorID>();
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

        public virtual CTe_Cabecalho cte_cabecalho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTe_DocumentoAnteriorID> cte_documento_anterior_id { get; set; }
    }
}
