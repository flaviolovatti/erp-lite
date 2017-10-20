namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.funcao")]
    public partial class Funcao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Funcao()
        {
            papel_funcao = new HashSet<PapelFuncao>();
        }

        public int id { get; set; }

        [StringLength(30)]
        public string descricao_menu { get; set; }

        [StringLength(30)]
        public string imagem_menu { get; set; }

        [StringLength(30)]
        public string metodo { get; set; }

        [StringLength(100)]
        public string nome { get; set; }

        [StringLength(100)]
        public string formulario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PapelFuncao> papel_funcao { get; set; }
    }
}
