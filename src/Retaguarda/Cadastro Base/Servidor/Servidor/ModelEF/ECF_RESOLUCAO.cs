namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ECF_RESOLUCAO
    {
        public int ID { get; set; }

        [StringLength(30)]
        public string NOME_CAIXA { get; set; }

        public int? ID_GERADO_CAIXA { get; set; }

        public int? ID_EMPRESA { get; set; }

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

        [StringLength(20)]
        public string HOTTRACK_COLOR { get; set; }

        [StringLength(20)]
        public string ITEM_STYLE_FONT_NAME { get; set; }

        [StringLength(20)]
        public string ITEM_STYLE_FONT_COLOR { get; set; }

        [StringLength(20)]
        public string ITEM_SEL_STYLE_COLOR { get; set; }

        [StringLength(20)]
        public string LABEL_TOTAL_GERAL_FONT_COLOR { get; set; }

        [StringLength(20)]
        public string ITEM_STYLE_FONT_STYLE { get; set; }

        [StringLength(20)]
        public string EDITS_COLOR { get; set; }

        [StringLength(20)]
        public string EDITS_FONT_COLOR { get; set; }

        [StringLength(20)]
        public string EDITS_DISABLED_COLOR { get; set; }

        [StringLength(20)]
        public string EDITS_FONT_NAME { get; set; }

        [StringLength(20)]
        public string EDITS_FONT_STYLE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_SINCRONIZACAO { get; set; }

        [StringLength(8)]
        public string HORA_SINCRONIZACAO { get; set; }
    }
}
