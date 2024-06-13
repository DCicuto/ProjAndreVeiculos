using Dapper;
using Microsoft.Data.SqlClient;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PixRepository
    {
        private string StrConn = "Server=127.0.0.1; Database=ProjCARROS; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=True;";
        SqlConnection conn;

        public PixRepository()
        {
            conn = new SqlConnection(StrConn);
        }

        public void InserirPix(Pix pix)
        {
            conn.Open();
            string query = "INSERT INTO Table_Pix (Id, IdTipo, ChavePix) values (@Id, @IdTipo, @ChavePix)";
            conn.Execute(query, pix);
            conn.Close();
        }
    }
}
    

