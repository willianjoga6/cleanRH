
using Admissao__Digital.Core.Entidades;
using Admissao__Digital.Core.Interface.Infra;
using Admissao__Digital.Core.Interface.Services;
using Dapper;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

namespace Admissao__Digital.Infra.Repository
{
    public class InserirContratado : IInserirContratado
    {
        private readonly IConexaoDB _conexaoDB;
        private readonly string _stringConexao; 


        public InserirContratado(IConexaoDB conexaoDB)
        {

            _conexaoDB = conexaoDB;

            _stringConexao = _conexaoDB.GetConexao();
        }

        public long InserirDadosContratado(CriarUsuario modelCriarUsuario)
        {
            try
            {                
                using var _conn = new MySqlConnection(_stringConexao);

                var sql = @"
                            INSERT INTO CONTRATADOS
                            (
                                con_dssnome,
                                con_dtdnascimento,
                                con_rg,
                                con_coscic,
                                con_cdigenero
                            )                            
                            Values
                            (
                                @nome,
                                @dataNascimento,
                                @rg,
                                @cpf,
                                @genero                                
                            ); Select LAST_INSERT_ID()
                ";
                var select = _conn.ExecuteScalar<long>(sql, new 
                {
                    nome = modelCriarUsuario.con_dssnome,
                    dataNascimento = modelCriarUsuario.con_dtdnascimento,
                    rg = modelCriarUsuario.con_rg,
                    cpf = modelCriarUsuario.con_coscic,
                    genero = modelCriarUsuario.con_cdigenero
                });

                return select;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
