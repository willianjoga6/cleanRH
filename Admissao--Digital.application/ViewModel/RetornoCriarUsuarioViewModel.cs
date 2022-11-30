namespace Admissao__Digital.application.ViewModel
{
    public class RetornoCriarUsuarioViewModel
    {
        public RetornoCriarUsuarioViewModel(long idColaborador, List<RetornoDependentes> dependentes)
        {
            IdColaborador = idColaborador;
            Dependentes = dependentes;
        }

        public long IdColaborador { get; set; }
        public List<RetornoDependentes> Dependentes { get; set; }
    }

    public class RetornoDependentes
    {
        public long IdDependente { get; set; }
        public string Nome { get; set; }

    }
}
