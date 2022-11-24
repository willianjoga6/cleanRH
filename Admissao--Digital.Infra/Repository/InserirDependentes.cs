
using Admissao__Digital.application.Model;
using Admissao__Digital.Core.Interface.Infra;
using Admissao__Digital.Core.Interface.Repo;
using Dapper;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

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

        public long InserirDadosDependentes(ModelCriarUsuario modelCriarUsuario, long idGestor)
        {
            try
            {
                var jsonSerialize = JsonConvert.SerializeObject(modelCriarUsuario);

                using var _conn = new MySqlConnection(_stringConexao);

                foreach(var i in modelCriarUsuario.Dependente)
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
                    
                    return select;
                }
                return 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
