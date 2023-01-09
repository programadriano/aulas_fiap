using Microsoft.Extensions.Configuration;
using Npgsql;

namespace Infra
{
    public class IndicadoresDAO
    {
        private IConfiguration _configuracoes;

        public IndicadoresDAO(IConfiguration config)
        {
            _configuracoes = config;
        }

        public bool TesteConexao()
        {
            try
            {
                using (NpgsqlConnection conexao = new NpgsqlConnection(
                _configuracoes.GetConnectionString("BaseIndicadores")))
                {
                    return conexao.GetAll<Indicador>();
                }

                return true;
            }
            catch (Exception)
            {

                return false;
            }


        }
    }
}