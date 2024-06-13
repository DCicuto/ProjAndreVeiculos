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
    public class CompraRepository
    {
        private string StrConn = "Server=127.0.0.1; Database=ProjCARROS; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=True;";
        SqlConnection conn;

        public CompraRepository()
        {
            conn = new SqlConnection(StrConn);
        }

        public void InserirCompra(Compra compra)
        {
            conn.Open();
            string query = "INSERT INTO Table_Compra (Id, IdCarro, Preco, DataCompra) values (@Id, @IdCarro, @Preco, @DataCompra)";
            conn.Execute(query, compra);
            conn.Close();
        }

    }
}
    

