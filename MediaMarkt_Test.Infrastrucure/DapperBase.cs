using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaMarkt_Test.Infrastrucure
{
    internal abstract class DapperBase
    {
        #region Injected Properties
        private readonly IConfiguration _configuration = null;
        protected IDbConnection MainDBConnection { get { return new SqlConnection(_configuration.GetConnectionString("MainDBConnection")); } }
        #endregion

        public DapperBase(IConfiguration configuration)
        {
            _configuration = configuration;
        }
    }
}
