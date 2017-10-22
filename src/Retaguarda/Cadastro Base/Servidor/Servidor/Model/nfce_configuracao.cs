namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfce_configuracao")]
    public partial class nfce_configuracao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public nfce_configuracao()
        {
            nfce_configuracao_balanca = new HashSet<nfce_configuracao_balanca>();
            nfce_configuracao_leitor_ser = new HashSet<nfce_configuracao_leitor_ser>();
        }

        public int id { get; set; }

        public int id_empresa { get; set; }

        public int id_nfce_caixa { get; set; }

        public int id_nfce_resolucao { get; set; }

        [StringLength(250)]
        public string mensagem_cupom { get; set; }

        [StringLength(100)]
        public string titulo_tela_caixa { get; set; }

        [StringLength(250)]
        public string caminho_imagens_produtos { get; set; }

        [StringLength(250)]
        public string caminho_imagens_marketing { get; set; }

        [StringLength(250)]
        public string caminho_imagens_layout { get; set; }

        [StringLength(20)]
        public string cor_janelas_internas { get; set; }

        [StringLength(1)]
        public string marketing_ativo { get; set; }

        public int? cfop { get; set; }

        public int? decimais_quantidade { get; set; }

        public int? decimais_valor { get; set; }

        public int? quantidade_maxima_parcela { get; set; }

        [StringLength(1)]
        public string imprime_parcela { get; set; }

        [StringLength(32)]
        public string codigo_csc { get; set; }

        [StringLength(6)]
        public string id_token_csc { get; set; }

        [StringLength(100)]
        public string certificado_digital_serie { get; set; }

        public string certificado_digital_caminho { get; set; }

        [StringLength(100)]
        public string certificado_digital_senha { get; set; }

        public int? tipo_emissao { get; set; }

        public int? formato_impressao_danfe { get; set; }

        public int? processo_emissao { get; set; }

        [StringLength(20)]
        public string versao_processo_emissao { get; set; }

        public string caminho_logomarca { get; set; }

        [StringLength(1)]
        public string salvar_xml { get; set; }

        public string caminho_salvar_xml { get; set; }

        public string caminho_schemas { get; set; }

        public string caminho_arquivo_danfe { get; set; }

        public string caminho_salvar_pdf { get; set; }

        [StringLength(2)]
        public string webservice_uf { get; set; }

        public int? webservice_ambiente { get; set; }

        [StringLength(100)]
        public string webservice_proxy_host { get; set; }

        public int? webservice_proxy_porta { get; set; }

        [StringLength(100)]
        public string webservice_proxy_usuario { get; set; }

        [StringLength(100)]
        public string webservice_proxy_senha { get; set; }

        [StringLength(1)]
        public string webservice_visualizar { get; set; }

        [StringLength(100)]
        public string email_servidor_smtp { get; set; }

        public int? email_porta { get; set; }

        [StringLength(100)]
        public string email_usuario { get; set; }

        [StringLength(100)]
        public string email_senha { get; set; }

        [StringLength(100)]
        public string email_assunto { get; set; }

        [StringLength(1)]
        public string email_autentica_ssl { get; set; }

        public string email_texto { get; set; }

        public virtual Empresa empresa { get; set; }

        public virtual nfce_caixa nfce_caixa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nfce_configuracao_balanca> nfce_configuracao_balanca { get; set; }

        public virtual nfce_resolucao nfce_resolucao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nfce_configuracao_leitor_ser> nfce_configuracao_leitor_ser { get; set; }
    }
}
