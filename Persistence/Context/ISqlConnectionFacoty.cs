using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context
{
    public interface ISqlConnectionFacoty
    {
        SqlConnection CreateConnection();
    }
}
