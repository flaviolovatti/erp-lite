namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfe_importacao_detalhe")]
    public partial class NFe_ImportacaoDetalhe
    {
        public int id { get; set; }

        public int id_nfe_declaracao_importacao { get; set; }

        public int? numero_adicao { get; set; }

        public int? numero_sequencial { get; set; }

        [StringLength(60)]
        public string codigo_fabricante_estrangeiro { get; set; }

        public decimal? valor_desconto { get; set; }

        public int? drawback { get; set; }

        public virtual NFe_DeclaracaoImportacao nfe_declaracao_importacao { get; set; }
    }
}
