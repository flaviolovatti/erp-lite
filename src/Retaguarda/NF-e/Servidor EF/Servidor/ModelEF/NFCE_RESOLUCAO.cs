namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFCE_RESOLUCAO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NFCE_RESOLUCAO()
        {
            NFCE_CONFIGURACAO = new HashSet<NFCE_CONFIGURACAO>();
            NFCE_POSICAO_COMPONENTES = new HashSet<NFCE_POSICAO_COMPONENTES>();
        }

        public int ID { get; set; }

        [StringLength(20)]
        public string RESOLUCAO_TELA { get; set; }

        public int? LARGURA { get; set; }

        public int? ALTURA { get; set; }

        [StringLength(50)]
        public string IMAGEM_TELA { get; set; }

        [StringLength(50)]
        public string IMAGEM_MENU { get; set; }

        [StringLength(50)]
        public string IMAGEM_SUBMENU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFCE_CONFIGURACAO> NFCE_CONFIGURACAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFCE_POSICAO_COMPONENTES> NFCE_POSICAO_COMPONENTES { get; set; }
    }
}
