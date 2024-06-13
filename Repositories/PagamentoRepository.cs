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
    public class PagamentoRepository
    {
        private string StrConn = "Server=127.0.0.1; Database=ProjCARROS; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=True;";
        SqlConnection conn;

        public PagamentoRepository()
        {
            conn = new SqlConnection(StrConn);
        }

        public void InserirPagamento(Pagamento pagamento)
        {
            conn.Open();
            string query = "INSERT INTO Table_Pagamento (Id, IdCartaoService, IdBoleto, IdPixServico, DataPagamento) values (@Id, @IdCartaoService, @IdBoleto, @IdPixServico, @DataPagamento)";
            conn.Execute(query, pagamento);
            conn.Close();
        }
    }
}
    

