using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosPersonalesApp
{
    public class RepositorioBase
    {
        const string consKeyDefaultCnnString = "ConnStringExpress";
        public SqlConnection SqlConn { get; set; }
        protected void OpenConnection()
        {
            String s = ConfigurationManager.ConnectionStrings[consKeyDefaultCnnString].ConnectionString;
            SqlConn = new SqlConnection(s);
            SqlConn.Open();
        }

        protected void CloseConnection()
        {
            SqlConn.Close();
            SqlConn = null;
        }
    }
}
