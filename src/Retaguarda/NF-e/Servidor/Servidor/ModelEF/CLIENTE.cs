namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CLIENTE")]
    public partial class CLIENTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIENTE()
        {
            FIN_CLIENTE_GRUPO_DET = new HashSet<FIN_CLIENTE_GRUPO_DET>();
            FIN_COBRANCA = new HashSet<FIN_COBRANCA>();
            FIN_LANCAMENTO_RECEBER = new HashSet<FIN_LANCAMENTO_RECEBER>();
            NFE_CABECALHO = new HashSet<NFE_CABECALHO>();
            VENDA_CABECALHO = new HashSet<VENDA_CABECALHO>();
            VENDA_ORCAMENTO_CABECALHO = new HashSet<VENDA_ORCAMENTO_CABECALHO>();
        }

        public int ID { get; set; }

        public int? ID_REGIAO { get; set; }

        public int? ID_TABELA_PRECO { get; set; }

        public int? ID_CONVENIO { get; set; }

        public int? ID_OPERACAO_FISCAL { get; set; }

        public int ID_PESSOA { get; set; }

        public int ID_ATIVIDADE_FOR_CLI { get; set; }

        public int ID_SITUACAO_FOR_CLI { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DESDE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_CADASTRO { get; set; }

        [Column(TypeName = "text")]
        public string OBSERVACAO { get; set; }

        [StringLength(30)]
        public string CONTA_TOMADOR { get; set; }

        [StringLength(1)]
        public string GERA_FINANCEIRO { get; set; }

        [StringLength(1)]
        public string INDICADOR_PRECO { get; set; }

        public decimal? PORCENTO_DESCONTO { get; set; }

        [StringLength(1)]
        public string FORMA_DESCONTO { get; set; }

        public decimal? LIMITE_CREDITO { get; set; }

        [StringLength(1)]
        public string TIPO_FRETE { get; set; }

        [StringLength(30)]
        public string CLASSIFICACAO_CONTABIL_CONTA { get; set; }

        [StringLength(1)]
        public string BLOQUEADO { get; set; }

        public int? DIAS_BLOQUEIO { get; set; }

        public virtual ATIVIDADE_FOR_CLI ATIVIDADE_FOR_CLI { get; set; }

        public virtual CONVENIO CONVENIO { get; set; }

        public virtual TRIBUT_OPERACAO_FISCAL TRIBUT_OPERACAO_FISCAL { get; set; }

        public virtual PESSOA PESSOA { get; set; }

        public virtual REGIAO REGIAO { get; set; }

        public virtual SITUACAO_FOR_CLI SITUACAO_FOR_CLI { get; set; }

        public virtual TABELA_PRECO TABELA_PRECO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_CLIENTE_GRUPO_DET> FIN_CLIENTE_GRUPO_DET { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_COBRANCA> FIN_COBRANCA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_LANCAMENTO_RECEBER> FIN_LANCAMENTO_RECEBER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_CABECALHO> NFE_CABECALHO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENDA_CABECALHO> VENDA_CABECALHO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENDA_ORCAMENTO_CABECALHO> VENDA_ORCAMENTO_CABECALHO { get; set; }
    }
}
