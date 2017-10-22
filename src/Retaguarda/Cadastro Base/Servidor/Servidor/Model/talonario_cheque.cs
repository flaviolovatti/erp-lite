namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.talonario_cheque")]
    public partial class talonario_cheque
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public talonario_cheque()
        {
            cheques = new HashSet<cheque>();
        }

        public int id { get; set; }

        public int id_conta_caixa { get; set; }

        public int id_empresa { get; set; }

        [StringLength(10)]
        public string talao { get; set; }

        public int? numero { get; set; }

        [StringLength(1)]
        public string status_talao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cheque> cheques { get; set; }

        public virtual conta_caixa conta_caixa { get; set; }

        public virtual Empresa empresa { get; set; }
    }
}
