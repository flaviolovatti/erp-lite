namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CTE_CABECALHO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CTE_CABECALHO()
        {
            CTE_AEREO = new HashSet<CTE_AEREO>();
            CTE_AQUAVIARIO = new HashSet<CTE_AQUAVIARIO>();
            CTE_CARGA = new HashSet<CTE_CARGA>();
            CTE_COMPONENTE = new HashSet<CTE_COMPONENTE>();
            CTE_DESTINATARIO = new HashSet<CTE_DESTINATARIO>();
            CTE_DOCUMENTO_ANTERIOR = new HashSet<CTE_DOCUMENTO_ANTERIOR>();
            CTE_DUPLICATA = new HashSet<CTE_DUPLICATA>();
            CTE_DUTOVIARIO = new HashSet<CTE_DUTOVIARIO>();
            CTE_EMITENTE = new HashSet<CTE_EMITENTE>();
            CTE_EXPEDIDOR = new HashSet<CTE_EXPEDIDOR>();
            CTE_FATURA = new HashSet<CTE_FATURA>();
            CTE_FERROVIARIO = new HashSet<CTE_FERROVIARIO>();
            CTE_INFORMACAO_NF_OUTROS = new HashSet<CTE_INFORMACAO_NF_OUTROS>();
            CTE_LOCAL_ENTREGA = new HashSet<CTE_LOCAL_ENTREGA>();
            CTE_LOCAL_COLETA = new HashSet<CTE_LOCAL_COLETA>();
            CTE_MULTIMODAL = new HashSet<CTE_MULTIMODAL>();
            CTE_PASSAGEM = new HashSet<CTE_PASSAGEM>();
            CTE_PERIGOSO = new HashSet<CTE_PERIGOSO>();
            CTE_RECEBEDOR = new HashSet<CTE_RECEBEDOR>();
            CTE_REMETENTE = new HashSet<CTE_REMETENTE>();
            CTE_RODOVIARIO = new HashSet<CTE_RODOVIARIO>();
            CTE_SEGURO = new HashSet<CTE_SEGURO>();
            CTE_TOMADOR = new HashSet<CTE_TOMADOR>();
            CTE_VEICULO_NOVO = new HashSet<CTE_VEICULO_NOVO>();
        }

        public int ID { get; set; }

        public int ID_EMPRESA { get; set; }

        public int? UF_EMITENTE { get; set; }

        [StringLength(8)]
        public string CODIGO_NUMERICO { get; set; }

        public int? CFOP { get; set; }

        [StringLength(60)]
        public string NATUREZA_OPERACAO { get; set; }

        [StringLength(2)]
        public string MODELO { get; set; }

        [StringLength(3)]
        public string SERIE { get; set; }

        [StringLength(9)]
        public string NUMERO { get; set; }

        public DateTime? DATA_HORA_EMISSAO { get; set; }

        public int? FORMATO_IMPRESSAO_DACTE { get; set; }

        public int? TIPO_EMISSAO { get; set; }

        [StringLength(44)]
        public string CHAVE_ACESSO { get; set; }

        [StringLength(1)]
        public string DIGITO_CHAVE_ACESSO { get; set; }

        public int? AMBIENTE { get; set; }

        public int? TIPO_CTE { get; set; }

        public int? PROCESSO_EMISSAO { get; set; }

        [StringLength(20)]
        public string VERSAO_PROCESSO_EMISSAO { get; set; }

        public int? CODIGO_MUNICIPIO_ENVIO { get; set; }

        [StringLength(60)]
        public string NOME_MUNICIPIO_ENVIO { get; set; }

        [StringLength(2)]
        public string UF_ENVIO { get; set; }

        [StringLength(2)]
        public string MODAL { get; set; }

        public int? TIPO_SERVICO { get; set; }

        public int? CODIGO_MUNICIPIO_INI_PRESTACAO { get; set; }

        [StringLength(60)]
        public string NOME_MUNICIPIO_INI_PRESTACAO { get; set; }

        [StringLength(2)]
        public string UF_INI_PRESTACAO { get; set; }

        public int? CODIGO_MUNICIPIO_FIM_PRESTACAO { get; set; }

        [StringLength(60)]
        public string NOME_MUNICIPIO_FIM_PRESTACAO { get; set; }

        [StringLength(2)]
        public string UF_FIM_PRESTACAO { get; set; }

        public int? RETIRA { get; set; }

        [StringLength(160)]
        public string RETIRA_DETALHE { get; set; }

        public int? TOMADOR { get; set; }

        public DateTime? DATA_ENTRADA_CONTINGENCIA { get; set; }

        [StringLength(255)]
        public string JUSTIFICATIVA_CONTINGENCIA { get; set; }

        [StringLength(15)]
        public string CARAC_ADICIONAL_TRANSPORTE { get; set; }

        [StringLength(30)]
        public string CARAC_ADICIONAL_SERVICO { get; set; }

        [StringLength(20)]
        public string FUNCIONARIO_EMISSOR { get; set; }

        [StringLength(15)]
        public string FLUXO_ORIGEM { get; set; }

        public int? ENTREGA_TIPO_PERIODO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ENTREGA_DATA_PROGRAMADA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ENTREGA_DATA_INICIAL { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ENTREGA_DATA_FINAL { get; set; }

        public int? ENTREGA_TIPO_HORA { get; set; }

        [StringLength(8)]
        public string ENTREGA_HORA_PROGRAMADA { get; set; }

        [StringLength(8)]
        public string ENTREGA_HORA_INICIAL { get; set; }

        [StringLength(8)]
        public string ENTREGA_HORA_FINAL { get; set; }

        [StringLength(40)]
        public string MUNICIPIO_ORIGEM_CALCULO { get; set; }

        [StringLength(40)]
        public string MUNICIPIO_DESTINO_CALCULO { get; set; }

        [Column(TypeName = "text")]
        public string OBSERVACOES_GERAIS { get; set; }

        public decimal? VALOR_TOTAL_SERVICO { get; set; }

        public decimal? VALOR_RECEBER { get; set; }

        [StringLength(2)]
        public string CST { get; set; }

        public decimal? BASE_CALCULO_ICMS { get; set; }

        public decimal? ALIQUOTA_ICMS { get; set; }

        public decimal? VALOR_ICMS { get; set; }

        public decimal? PERCENTUAL_REDUCAO_BC_ICMS { get; set; }

        public decimal? VALOR_BC_ICMS_ST_RETIDO { get; set; }

        public decimal? VALOR_ICMS_ST_RETIDO { get; set; }

        public decimal? ALIQUOTA_ICMS_ST_RETIDO { get; set; }

        public decimal? VALOR_CREDITO_PRESUMIDO_ICMS { get; set; }

        public decimal? PERCENTUAL_BC_ICMS_OUTRA_UF { get; set; }

        public decimal? VALOR_BC_ICMS_OUTRA_UF { get; set; }

        public decimal? ALIQUOTA_ICMS_OUTRA_UF { get; set; }

        public decimal? VALOR_ICMS_OUTRA_UF { get; set; }

        public int? SIMPLES_NACIONAL_INDICADOR { get; set; }

        public decimal? SIMPLES_NACIONAL_TOTAL { get; set; }

        [Column(TypeName = "text")]
        public string INFORMACOES_ADD_FISCO { get; set; }

        public decimal? VALOR_TOTAL_CARGA { get; set; }

        [StringLength(60)]
        public string PRODUTO_PREDOMINANTE { get; set; }

        [StringLength(30)]
        public string CARGA_OUTRAS_CARACTERISTICAS { get; set; }

        public int? MODAL_VERSAO_LAYOUT { get; set; }

        [StringLength(44)]
        public string CHAVE_CTE_SUBSTITUIDO { get; set; }

        public int? INDICADOR_CTE_GLOBALIZADO { get; set; }

        public int? INDICADOR_PAPEL_TOMADOR { get; set; }

        public decimal? VALOR_BC_UF_FIM { get; set; }

        public decimal? PERCENTUAL_FPC_UF_FIM { get; set; }

        public decimal? ALIQUOTA_ICMS_UF_FIM { get; set; }

        public decimal? ALIQUOTA_INTERESTADUAL_UF_FIM { get; set; }

        public decimal? PERCENTUAL_PARTILHA_UF_FIM { get; set; }

        public decimal? VALOR_ICMS_FPC_UF_FIM { get; set; }

        public decimal? VALOR_ICMS_PARTILHA_UF_FIM { get; set; }

        public decimal? VALOR_ICMS_PARTILHA_UF_INI { get; set; }

        public decimal? VALOR_CARGA_AVERBACAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTE_AEREO> CTE_AEREO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTE_AQUAVIARIO> CTE_AQUAVIARIO { get; set; }

        public virtual EMPRESA EMPRESA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTE_CARGA> CTE_CARGA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTE_COMPONENTE> CTE_COMPONENTE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTE_DESTINATARIO> CTE_DESTINATARIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTE_DOCUMENTO_ANTERIOR> CTE_DOCUMENTO_ANTERIOR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTE_DUPLICATA> CTE_DUPLICATA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTE_DUTOVIARIO> CTE_DUTOVIARIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTE_EMITENTE> CTE_EMITENTE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTE_EXPEDIDOR> CTE_EXPEDIDOR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTE_FATURA> CTE_FATURA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTE_FERROVIARIO> CTE_FERROVIARIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTE_INFORMACAO_NF_OUTROS> CTE_INFORMACAO_NF_OUTROS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTE_LOCAL_ENTREGA> CTE_LOCAL_ENTREGA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTE_LOCAL_COLETA> CTE_LOCAL_COLETA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTE_MULTIMODAL> CTE_MULTIMODAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTE_PASSAGEM> CTE_PASSAGEM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTE_PERIGOSO> CTE_PERIGOSO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTE_RECEBEDOR> CTE_RECEBEDOR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTE_REMETENTE> CTE_REMETENTE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTE_RODOVIARIO> CTE_RODOVIARIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTE_SEGURO> CTE_SEGURO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTE_TOMADOR> CTE_TOMADOR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTE_VEICULO_NOVO> CTE_VEICULO_NOVO { get; set; }
    }
}
