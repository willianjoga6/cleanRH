using Admissao__Digital.Core.Interface.Infra;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace Admissao__Digital.Infra.Infra
{
    public class ConexaoDB : IConexaoDB
    {
        private readonly IConfiguration _config;

        public ConexaoDB(IConfiguration config)
        {
            _config = config;
        }

        public string GetConexao()
        {
            try
            {               
                string _conn = Convert.ToString(_config.GetSection("Data:ConnectionString").Value);

                return _conn;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
