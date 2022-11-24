using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admissao__Digital.application.Model
{
    public class ModelCriarUsuario
    {       
        public string? con_dssnome { get; set; }
        public DateTime con_dtdnascimento { get; set; }
        public string? con_rg { get; set; }
        public string? con_coscic { get; set; }
        public int con_cdigenero { get; set; }
        public List<Dependentes>? Dependente { get; set; }
    }

    public class Dependentes
    {
        public string? dep_dssnome { get; set; }
        public DateTime dep_dtdnascimento { get; set; }
        public string? dep_rg { get; set; }
        public string? dep_coscic { get; set; }
        public int dep_cdigenero { get; set; }
        public int dep_cdiparentesco { get; set; }

    }
}
