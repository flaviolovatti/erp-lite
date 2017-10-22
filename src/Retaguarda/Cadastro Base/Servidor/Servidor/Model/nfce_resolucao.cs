namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfce_resolucao")]
    public partial class nfce_resolucao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public nfce_resolucao()
        {
            nfce_configuracao = new HashSet<nfce_configuracao>();
            nfce_posicao_componentes = new HashSet<nfce_posicao_componentes>();
        }

        public int id { get; set; }

        [StringLength(20)]
        public string resolucao_tela { get; set; }

        public int? largura { get; set; }

        public int? altura { get; set; }

        [StringLength(50)]
        public string imagem_tela { get; set; }

        [StringLength(50)]
        public string imagem_menu { get; set; }

        [StringLength(50)]
        public string imagem_submenu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nfce_configuracao> nfce_configuracao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nfce_posicao_componentes> nfce_posicao_componentes { get; set; }
    }
}
