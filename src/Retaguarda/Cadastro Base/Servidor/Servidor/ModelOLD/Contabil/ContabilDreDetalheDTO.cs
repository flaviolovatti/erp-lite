using System;
using System.Text;
using System.Collections.Generic;


namespace Servidor.Model {
    
    public class ContabilDreDetalheDTO {
        public ContabilDreDetalheDTO() { }
        public int Id { get; set; }
        public ContabilDreCabecalhoDTO ContabilDreCabecalho { get; set; }
        public string Classificacao { get; set; }
        public string Descricao { get; set; }
        public string FormaCalculo { get; set; }
        public string Sinal { get; set; }
        public string Natureza { get; set; }
        public System.Nullable<decimal> Valor { get; set; }
    }
}
