using Admissao__Digital.application.ViewModel;
using Admissao__Digital.Core.Entidades;
using System.Collections.Generic;

namespace Admissao__Digital.application.Mapper
{
    public class CriarUsuarioMapper
    {
        public static CriarUsuario ToCriarUsuarioEntity(CriarUsuarioViewModel criarUsuarioViewModel)
        {
            
            var criarContratado = new CriarUsuario
                                    (
                                        criarUsuarioViewModel.con_dssnome, 
                                        criarUsuarioViewModel.con_dtdnascimento, 
                                        criarUsuarioViewModel.con_rg, 
                                        criarUsuarioViewModel.con_coscic, 
                                        criarUsuarioViewModel.con_cdigenero,
                                        criarUsuarioViewModel.Dependente
                                    );

            return criarContratado;
        }
        public static RetornoCriarUsuarioViewModel ToRetornoCriarUsuarioViewModel( CriarUsuario criarUsuario, long idContratado)
        {
            var retornoCriarUsuario = new RetornoCriarUsuarioViewModel(idContratado, criarUsuario.Dependente);

            return retornoCriarUsuario;
        }
    }
}
