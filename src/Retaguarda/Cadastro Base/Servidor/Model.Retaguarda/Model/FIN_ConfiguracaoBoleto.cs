namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.fin_configuracao_boleto")]
    public partial class FIN_ConfiguracaoBoleto
    {
        public int id { get; set; }

        public int id_conta_caixa { get; set; }

        public int id_empresa { get; set; }

        [StringLength(100)]
        public string instrucao01 { get; set; }

        [StringLength(100)]
        public string instrucao02 { get; set; }

        [StringLength(250)]
        public string caminho_arquivo_remessa { get; set; }

        [StringLength(250)]
        public string caminho_arquivo_retorno { get; set; }

        [StringLength(250)]
        public string caminho_arquivo_logotipo { get; set; }

        [StringLength(250)]
        public string caminho_arquivo_pdf { get; set; }

        [StringLength(250)]
        public string mensagem { get; set; }

        [StringLength(100)]
        public string local_pagamento { get; set; }

        [StringLength(3)]
        public string layout_remessa { get; set; }

        [StringLength(1)]
        public string aceite { get; set; }

        [StringLength(2)]
        public string especie { get; set; }

        [StringLength(3)]
        public string carteira { get; set; }

        [StringLength(20)]
        public string codigo_convenio { get; set; }

        [StringLength(20)]
        public string codigo_cedente { get; set; }

        public decimal? taxa_multa { get; set; }

        public decimal? taxa_juro { get; set; }

        public int? dias_protesto { get; set; }

        [StringLength(50)]
        public string nosso_numero_anterior { get; set; }

        public virtual ContaCaixa conta_caixa { get; set; }

        public virtual Empresa empresa { get; set; }
    }
}
