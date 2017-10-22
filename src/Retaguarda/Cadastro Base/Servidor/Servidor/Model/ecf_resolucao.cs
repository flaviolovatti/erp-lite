namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.ecf_resolucao")]
    public partial class ecf_resolucao
    {
        public int id { get; set; }

        [StringLength(30)]
        public string nome_caixa { get; set; }

        public int? id_gerado_caixa { get; set; }

        public int? id_empresa { get; set; }

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

        [StringLength(20)]
        public string hottrack_color { get; set; }

        [StringLength(20)]
        public string item_style_font_name { get; set; }

        [StringLength(20)]
        public string item_style_font_color { get; set; }

        [StringLength(20)]
        public string item_sel_style_color { get; set; }

        [StringLength(20)]
        public string label_total_geral_font_color { get; set; }

        [StringLength(20)]
        public string item_style_font_style { get; set; }

        [StringLength(20)]
        public string edits_color { get; set; }

        [StringLength(20)]
        public string edits_font_color { get; set; }

        [StringLength(20)]
        public string edits_disabled_color { get; set; }

        [StringLength(20)]
        public string edits_font_name { get; set; }

        [StringLength(20)]
        public string edits_font_style { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_sincronizacao { get; set; }

        [StringLength(8)]
        public string hora_sincronizacao { get; set; }
    }
}
