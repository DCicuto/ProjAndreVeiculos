using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CarroRepository
    {
        private string StrConn = "Server=127.0.0.1; Database=ProjCARROS; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=True;";
        SqlConnection conn;

        public CarroRepository()
        {
            conn = new SqlConnection(StrConn);
        }

        public void InserirCarro(Carro carro)
        {
            conn.Open();
            string query = "INSERT INTO Table_Carro (Placa, Nome, AnoModelo, AnoFabricacao, Cor, Vendido) values (@Placa, @Nome, @AnoModelo, @AnoFabricacao, @Cor, @Vendido)";
            conn.Execute(query, carro);
            conn.Close();
        }

    }
}