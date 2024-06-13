using Dapper;
using Microsoft.Data.SqlClient;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TipoPixRepository
    {
        private string StrConn = "Server=127.0.0.1; Database=ProjCARROS; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=True;";
        SqlConnection conn;

        public TipoPixRepository()
        {
            conn = new SqlConnection(StrConn);
        }

        public void InserirTipoPix(TipoPix tipopix)
        {
            conn.Open();
            string query = "INSERT INTO Table_TipoPix (Id, Nome) values (@Id, @Nome)";
            conn.Execute(query, tipopix);
            conn.Close();
        }
    }
}
    

