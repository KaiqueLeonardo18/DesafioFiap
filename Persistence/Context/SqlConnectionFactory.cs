using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context
{
    public sealed class SqlConnectionFactory : ISqlConnectionFacoty
    {
        private readonly IConfiguration _configuration;

        public SqlConnectionFactory(IConfiguration configuration) 
        {
            _configuration = configuration;
        }
        public SqlConnection CreateConnection()
        {
            return new SqlConnection(_configuration.GetConnectionString("SqLite"));
        }
    }
}
