using Admissao__Digital.Core.Entidades;

namespace Admissao__Digital.Core.Interface.Services
{
    public interface IContratadoService
    {
        bool CriarUsuario(CriarUsuario modelCriarUsuario);
        bool CriarDependente(CriarUsuario modelCriarUsuario, long idContratado);
    }
}