namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.venda_romaneio_entrega")]
    public partial class venda_romaneio_entrega
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public venda_romaneio_entrega()
        {
            venda_cabecalho = new HashSet<venda_cabecalho>();
        }

        public int id { get; set; }

        public int id_colaborador { get; set; }

        [StringLength(100)]
        public string descricao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_emissao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_prevista { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_saida { get; set; }

        [StringLength(1)]
        public string situacao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_encerramento { get; set; }

        public string observacao { get; set; }

        public virtual Colaborador colaborador { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<venda_cabecalho> venda_cabecalho { get; set; }
    }
}
