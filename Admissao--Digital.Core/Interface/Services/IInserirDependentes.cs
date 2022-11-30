using Admissao__Digital.Core.Entidades;

namespace Admissao__Digital.Core.Interface.Services
{
    public interface IInserirDependentes
    {
        bool InserirDadosDependentes(CriarUsuario jsonDependente, long idGestor);
    }
}