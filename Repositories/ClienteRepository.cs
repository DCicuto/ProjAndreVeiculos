using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ClienteRepository
    {
        private string StrConn = "Server=127.0.0.1; Database=ProjCARROS; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=True;";
        SqlConnection conn;

        public ClienteRepository()
        {
            conn = new SqlConnection(StrConn);
        }

        public void InserirCliente(Cliente cliente)
        {
            conn.Open();
            string query = "INSERT INTO Table_Cliente (Renda, Documento) values (@Renda, @Documento)";
            conn.Execute(query, cliente);
            conn.Close();
        }
    }
}
    