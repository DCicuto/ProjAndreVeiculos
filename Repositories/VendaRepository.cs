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
    public class VendaRepository
    {
        private string StrConn = "Server=127.0.0.1; Database=ProjCARROS; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=True;";
        SqlConnection conn;

        public VendaRepository()
        {
            conn = new SqlConnection(StrConn);
        }

        public void InserirVenda(Venda venda)
        {
            conn.Open();
            string query = "INSERT INTO Table_Venda (Id, IdCarro, DataVenda, ValorVenda, IdCliente, IdFuncionario, IdPagamento) values (@Id, @IdCarro, @DataVenda, @ValorVenda, @IdCliente, @IdFuncionario, @IdPagamento)";
            conn.Execute(query, venda);
            conn.Close();
        }

    }
}