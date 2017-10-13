namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FIN_CONFIGURACAO_BOLETO
    {
        public int ID { get; set; }

        public int ID_CONTA_CAIXA { get; set; }

        public int ID_EMPRESA { get; set; }

        [StringLength(100)]
        public string INSTRUCAO01 { get; set; }

        [StringLength(100)]
        public string INSTRUCAO02 { get; set; }

        [StringLength(250)]
        public string CAMINHO_ARQUIVO_REMESSA { get; set; }

        [StringLength(250)]
        public string CAMINHO_ARQUIVO_RETORNO { get; set; }

        [StringLength(250)]
        public string CAMINHO_ARQUIVO_LOGOTIPO { get; set; }

        [StringLength(250)]
        public string CAMINHO_ARQUIVO_PDF { get; set; }

        [StringLength(250)]
        public string MENSAGEM { get; set; }

        [StringLength(100)]
        public string LOCAL_PAGAMENTO { get; set; }

        [StringLength(3)]
        public string LAYOUT_REMESSA { get; set; }

        [StringLength(1)]
        public string ACEITE { get; set; }

        [StringLength(2)]
        public string ESPECIE { get; set; }

        [StringLength(3)]
        public string CARTEIRA { get; set; }

        [StringLength(20)]
        public string CODIGO_CONVENIO { get; set; }

        [StringLength(20)]
        public string CODIGO_CEDENTE { get; set; }

        public decimal? TAXA_MULTA { get; set; }

        public decimal? TAXA_JURO { get; set; }

        public int? DIAS_PROTESTO { get; set; }

        [StringLength(50)]
        public string NOSSO_NUMERO_ANTERIOR { get; set; }

        public virtual CONTA_CAIXA CONTA_CAIXA { get; set; }

        public virtual EMPRESA EMPRESA { get; set; }
    }
}
