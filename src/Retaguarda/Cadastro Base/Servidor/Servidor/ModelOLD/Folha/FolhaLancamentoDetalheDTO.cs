using System;
using System.Text;
using System.Collections.Generic;


namespace Servidor.Model {
    
    public class FolhaLancamentoDetalheDTO {
        public FolhaLancamentoDetalheDTO() { }
        public int Id { get; set; }
        public FolhaEventoDTO FolhaEvento { get; set; }
        public FolhaLancamentoCabecalhoDTO FolhaLancamentoCabecalho { get; set; }
        public System.Nullable<decimal> Origem { get; set; }
        public System.Nullable<decimal> Provento { get; set; }
        public System.Nullable<decimal> Desconto { get; set; }
    }
}
