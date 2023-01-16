namespace Admissao__Digital.Core.Entidades
{
    public class CriarUsuario
    {
        public CriarUsuario()
        {

        }
        public CriarUsuario(string con_dssnome, DateTime con_dtdnascimento, string con_rg, string con_coscic, int con_cdigenero, List<Dependentes> dependente)
        {
            this.con_dssnome = con_dssnome;
            this.con_dtdnascimento = con_dtdnascimento;
            this.con_rg = con_rg;
            this.con_coscic = con_coscic;
            this.con_cdigenero = con_cdigenero;
            Dependente = dependente;
        }

        public string con_dssnome { get; set; }
        public DateTime con_dtdnascimento { get; set; }
        public string con_rg { get; set; }
        public string con_coscic { get; set; }
        public int con_cdigenero { get; set; }
        
        public List<Dependentes>? Dependente { get; set; }
    }

    public class Dependentes
    {
        public string dep_dssnome { get; set; }
        public DateTime dep_dtdnascimento { get; set; }
        public string dep_rg { get; set; }
        public string dep_coscic { get; set; }
        public int dep_cdigenero { get; set; }
        public int dep_cdiparentesco { get; set; }

    }
}
