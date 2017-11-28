using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testsqlserverconnectionstring
{
    class SqlDataAccess
    {
        private readonly string _connectionString;
        private readonly Action<string> _log;

        public SqlDataAccess(string connectionString, Action<string> logFunction)
        {
            _connectionString = connectionString;
            _log = logFunction;
        }

        public async Task<bool> Connect()
        {
            var server = new SqlConnection(_connectionString);

            try
            {
                await server.OpenAsync();

                return true;
            }
            catch (Exception e)
            {
                _log(e.Message);
                return false;
            }
        }
    }
}
