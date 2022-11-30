using Admissao__Digital.Core.Entidades;
using Admissao__Digital.Core.Interface.Infra;
using Admissao__Digital.Core.Interface.Services;
using Dapper;
using MySql.Data.MySqlClient;

namespace Admissao__Digital.Infra.Repository
{
    public class InserirDependentes : IInserirDependentes
    {
        private readonly IConexaoDB _conexaoDB;
        private readonly string _stringConexao; 


        public InserirDependentes(IConexaoDB conexaoDB)
        {

            _conexaoDB = conexaoDB;

            _stringConexao = _conexaoDB.GetConexao();
        }

        public bool InserirDadosDependentes( CriarUsuario jsonDependente, long idGestor)
        {
            try
            {                
                using var _conn = new MySqlConnection(_stringConexao);

                foreach(var i in jsonDependente.Dependente)
                {
                    var sql = @"
                            INSERT INTO DEPENDENTES
                            (
                                dep_cdicontratado,
                                dep_dssnome,
                                dep_dtdnascimento,
                                dep_rg,
                                dep_coscic,
                                dep_cdigenero,
                                dep_cdiparentesco
                            )                            
                            Values
                            (
                                @contratado,
                                @nome,
                                @dataNascimento,
                                @rg,
                                @cpf,
                                @genero,
                                @parentesco
                            ); Select LAST_INSERT_ID()
                    ";
                    var select = _conn.ExecuteScalar<int>(sql, new
                    {
                        contratado = idGestor,
                        nome = i.dep_dssnome,
                        dataNascimento = i.dep_dtdnascimento,
                        rg = i.dep_rg,
                        cpf = i.dep_coscic,
                        genero = i.dep_cdigenero,
                        parentesco = i.dep_cdiparentesco
                    });
                }
                return true;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
