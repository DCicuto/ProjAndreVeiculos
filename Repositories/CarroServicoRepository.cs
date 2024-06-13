using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CarroServicoRepository
    {
        private string StrConn = "Server=127.0.0.1; Database=ProjCARROS; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=True;";
        SqlConnection conn;

        public CarroServicoRepository()
        {
            conn = new SqlConnection(StrConn);
        }

        public void InserirCarroServico(CarroServico carroservico)
        {
            conn.Open();
            string query = "INSERT INTO Table_CarroServico (Id, IdCarro, IdServico) values (@Id, @IdCarro, @IdServico)";
            conn.Execute(query, carroservico);
            conn.Close();
        }
    }
}
