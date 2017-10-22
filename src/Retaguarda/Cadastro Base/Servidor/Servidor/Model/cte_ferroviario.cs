namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cte_ferroviario")]
    public partial class cte_ferroviario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cte_ferroviario()
        {
            cte_ferroviario_ferrovia = new HashSet<cte_ferroviario_ferrovia>();
            cte_ferroviario_vagao = new HashSet<cte_ferroviario_vagao>();
        }

        public int id { get; set; }

        public int id_cte_cabecalho { get; set; }

        public int? tipo_trafego { get; set; }

        public int? responsavel_faturamento { get; set; }

        public int? ferrovia_emitente_cte { get; set; }

        [StringLength(10)]
        public string fluxo { get; set; }

        [StringLength(7)]
        public string id_trem { get; set; }

        public decimal? valor_frete { get; set; }

        public virtual cte_cabecalho cte_cabecalho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cte_ferroviario_ferrovia> cte_ferroviario_ferrovia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cte_ferroviario_vagao> cte_ferroviario_vagao { get; set; }
    }
}
