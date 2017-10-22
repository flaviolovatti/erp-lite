namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cte_configuracao")]
    public partial class cte_configuracao
    {
        public int id { get; set; }

        public int id_empresa { get; set; }

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
    }
}
