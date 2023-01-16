using Admissao__Digital.application.ViewModel;
using Admissao__Digital.Core.Entidades;
using System.Collections.Generic;

namespace Admissao__Digital.application.Mapper
{
    public class CriarUsuarioMapper
    {
        public static CriarUsuario ToCriarUsuarioEntity(CriarUsuarioViewModel criarUsuarioViewModel)
        {
            List<Dependentes> dependente = new List<Dependentes>();
            

            var criarContratado = new CriarUsuario
                                    (
                                        criarUsuarioViewModel.con_dssnome,
                                        criarUsuarioViewModel.con_dtdnascimento,
                                        criarUsuarioViewModel.con_rg,
                                        criarUsuarioViewModel.con_coscic,
                                        criarUsuarioViewModel.con_cdigenero,
                                        dependente
                                    ) ;

            return criarContratado;
        }
        public static RetornoCriarUsuarioViewModel ToRetornoCriarUsuarioViewModel( CriarUsuario criarUsuario, long idContratado)
        {
            List<RetornoDependentes> retornoDependentes = new List<RetornoDependentes>();

            var retornoCriarUsuario = new RetornoCriarUsuarioViewModel(idContratado, retornoDependentes);

            return retornoCriarUsuario;
        }
    }
}
