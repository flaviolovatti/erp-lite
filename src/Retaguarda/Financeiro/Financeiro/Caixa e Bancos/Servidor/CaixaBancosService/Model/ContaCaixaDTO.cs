using System;
using System.Text;
using System.Collections.Generic;


namespace CaixaBancosService.Model {
    
    public class ContaCaixaDTO {
        public ContaCaixaDTO() { }
        public int Id { get; set; }
        public AgenciaBancoDTO AgenciaBanco { get; set; }
        public EmpresaDTO Empresa { get; set; }
        public string Codigo { get; set; }
        public string Digito { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
    }
}
