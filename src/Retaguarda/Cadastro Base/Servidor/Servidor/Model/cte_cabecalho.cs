namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cte_cabecalho")]
    public partial class cte_cabecalho
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cte_cabecalho()
        {
            cte_aereo = new HashSet<cte_aereo>();
            cte_aquaviario = new HashSet<cte_aquaviario>();
            cte_carga = new HashSet<cte_carga>();
            cte_componente = new HashSet<cte_componente>();
            cte_destinatario = new HashSet<cte_destinatario>();
            cte_documento_anterior = new HashSet<cte_documento_anterior>();
            cte_duplicata = new HashSet<cte_duplicata>();
            cte_dutoviario = new HashSet<cte_dutoviario>();
            cte_emitente = new HashSet<cte_emitente>();
            cte_expedidor = new HashSet<cte_expedidor>();
            cte_fatura = new HashSet<cte_fatura>();
            cte_ferroviario = new HashSet<cte_ferroviario>();
            cte_informacao_nf_outros = new HashSet<cte_informacao_nf_outros>();
            cte_local_coleta = new HashSet<cte_local_coleta>();
            cte_local_entrega = new HashSet<cte_local_entrega>();
            cte_multimodal = new HashSet<cte_multimodal>();
            cte_passagem = new HashSet<cte_passagem>();
            cte_perigoso = new HashSet<cte_perigoso>();
            cte_recebedor = new HashSet<cte_recebedor>();
            cte_remetente = new HashSet<cte_remetente>();
            cte_rodoviario = new HashSet<cte_rodoviario>();
            cte_seguro = new HashSet<cte_seguro>();
            cte_tomador = new HashSet<cte_tomador>();
            cte_veiculo_novo = new HashSet<cte_veiculo_novo>();
        }

        public int id { get; set; }

        public int id_empresa { get; set; }

        public int? uf_emitente { get; set; }

        [StringLength(8)]
        public string codigo_numerico { get; set; }

        public int? cfop { get; set; }

        [StringLength(60)]
        public string natureza_operacao { get; set; }

        [StringLength(2)]
        public string modelo { get; set; }

        [StringLength(3)]
        public string serie { get; set; }

        [StringLength(9)]
        public string numero { get; set; }

        public DateTime? data_hora_emissao { get; set; }

        public int? formato_impressao_dacte { get; set; }

        public int? tipo_emissao { get; set; }

        [StringLength(44)]
        public string chave_acesso { get; set; }

        [StringLength(1)]
        public string digito_chave_acesso { get; set; }

        public int? ambiente { get; set; }

        public int? tipo_cte { get; set; }

        public int? processo_emissao { get; set; }

        [StringLength(20)]
        public string versao_processo_emissao { get; set; }

        public int? codigo_municipio_envio { get; set; }

        [StringLength(60)]
        public string nome_municipio_envio { get; set; }

        [StringLength(2)]
        public string uf_envio { get; set; }

        [StringLength(2)]
        public string modal { get; set; }

        public int? tipo_servico { get; set; }

        public int? codigo_municipio_ini_prestacao { get; set; }

        [StringLength(60)]
        public string nome_municipio_ini_prestacao { get; set; }

        [StringLength(2)]
        public string uf_ini_prestacao { get; set; }

        public int? codigo_municipio_fim_prestacao { get; set; }

        [StringLength(60)]
        public string nome_municipio_fim_prestacao { get; set; }

        [StringLength(2)]
        public string uf_fim_prestacao { get; set; }

        public int? retira { get; set; }

        [StringLength(160)]
        public string retira_detalhe { get; set; }

        public int? tomador { get; set; }

        public DateTime? data_entrada_contingencia { get; set; }

        [StringLength(255)]
        public string justificativa_contingencia { get; set; }

        [StringLength(15)]
        public string carac_adicional_transporte { get; set; }

        [StringLength(30)]
        public string carac_adicional_servico { get; set; }

        [StringLength(20)]
        public string funcionario_emissor { get; set; }

        [StringLength(15)]
        public string fluxo_origem { get; set; }

        public int? entrega_tipo_periodo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? entrega_data_programada { get; set; }

        [Column(TypeName = "date")]
        public DateTime? entrega_data_inicial { get; set; }

        [Column(TypeName = "date")]
        public DateTime? entrega_data_final { get; set; }

        public int? entrega_tipo_hora { get; set; }

        [StringLength(8)]
        public string entrega_hora_programada { get; set; }

        [StringLength(8)]
        public string entrega_hora_inicial { get; set; }

        [StringLength(8)]
        public string entrega_hora_final { get; set; }

        [StringLength(40)]
        public string municipio_origem_calculo { get; set; }

        [StringLength(40)]
        public string municipio_destino_calculo { get; set; }

        public string observacoes_gerais { get; set; }

        public decimal? valor_total_servico { get; set; }

        public decimal? valor_receber { get; set; }

        [StringLength(2)]
        public string cst { get; set; }

        public decimal? base_calculo_icms { get; set; }

        public decimal? aliquota_icms { get; set; }

        public decimal? valor_icms { get; set; }

        public decimal? percentual_reducao_bc_icms { get; set; }

        public decimal? valor_bc_icms_st_retido { get; set; }

        public decimal? valor_icms_st_retido { get; set; }

        public decimal? aliquota_icms_st_retido { get; set; }

        public decimal? valor_credito_presumido_icms { get; set; }

        public decimal? percentual_bc_icms_outra_uf { get; set; }

        public decimal? valor_bc_icms_outra_uf { get; set; }

        public decimal? aliquota_icms_outra_uf { get; set; }

        public decimal? valor_icms_outra_uf { get; set; }

        public int? simples_nacional_indicador { get; set; }

        public decimal? simples_nacional_total { get; set; }

        public string informacoes_add_fisco { get; set; }

        public decimal? valor_total_carga { get; set; }

        [StringLength(60)]
        public string produto_predominante { get; set; }

        [StringLength(30)]
        public string carga_outras_caracteristicas { get; set; }

        public int? modal_versao_layout { get; set; }

        [StringLength(44)]
        public string chave_cte_substituido { get; set; }

        public int? indicador_cte_globalizado { get; set; }

        public int? indicador_papel_tomador { get; set; }

        public decimal? valor_bc_uf_fim { get; set; }

        public decimal? percentual_fcp_uf_fim { get; set; }

        public decimal? aliquota_icms_uf_fim { get; set; }

        public decimal? aliquota_interestadual_uf_fim { get; set; }

        public decimal? percentual_partilha_uf_fim { get; set; }

        public decimal? valor_icms_fcp_uf_fim { get; set; }

        public decimal? valor_icms_partilha_uf_fim { get; set; }

        public decimal? valor_icms_partilha_uf_ini { get; set; }

        public decimal? valor_carga_averbacao { get; set; }

        [StringLength(20)]
        public string versao_aplicativo { get; set; }

        public DateTime? data_hora_processamento { get; set; }

        [StringLength(15)]
        public string numero_protocolo { get; set; }

        [StringLength(28)]
        public string digest_value { get; set; }

        [StringLength(3)]
        public string codigo_status_resposta { get; set; }

        public string descricao_motivo_resposta { get; set; }

        [StringLength(255)]
        public string justificativa_cancelamento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cte_aereo> cte_aereo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cte_aquaviario> cte_aquaviario { get; set; }

        public virtual Empresa empresa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cte_carga> cte_carga { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cte_componente> cte_componente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cte_destinatario> cte_destinatario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cte_documento_anterior> cte_documento_anterior { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cte_duplicata> cte_duplicata { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cte_dutoviario> cte_dutoviario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cte_emitente> cte_emitente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cte_expedidor> cte_expedidor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cte_fatura> cte_fatura { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cte_ferroviario> cte_ferroviario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cte_informacao_nf_outros> cte_informacao_nf_outros { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cte_local_coleta> cte_local_coleta { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cte_local_entrega> cte_local_entrega { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cte_multimodal> cte_multimodal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cte_passagem> cte_passagem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cte_perigoso> cte_perigoso { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cte_recebedor> cte_recebedor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cte_remetente> cte_remetente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cte_rodoviario> cte_rodoviario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cte_seguro> cte_seguro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cte_tomador> cte_tomador { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cte_veiculo_novo> cte_veiculo_novo { get; set; }
    }
}
