using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CargoRepository
    {

        private string StrConn = "Server=127.0.0.1; Database=ProjCARROS; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=True;";
        SqlConnection conn;

        public CargoRepository()
        {
            conn = new SqlConnection(StrConn);
        }

        public void InserirCargo(Cargo cargo)
        {
            conn.Open();
            string query = "INSERT INTO Table_Cargo (Id, Descricao) values (@Id, @Descricao)";
            conn.Execute(query, cargo);
            conn.Close();
        }

    }
}
