using Admissao__Digital.application.Model;

namespace Admissao__Digital.Core.Interface.Repo
{
    public interface IInserirDependentes
    {
        public long InserirDadosDependentes(ModelCriarUsuario modelCriarUsuario, long idGestor);
    }
}