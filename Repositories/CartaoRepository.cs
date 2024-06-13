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
    public class CartaoRepository
    {
        private string StrConn = "Server=127.0.0.1; Database=ProjCARROS; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=True;";
        SqlConnection conn;

        public CartaoRepository()
        {
            conn = new SqlConnection(StrConn);
        }

        public void InserirCartao(Cartao cartao)
        {
            conn.Open();
            string query = "INSERT INTO Table_Cartao (NumeroCartao, CodigoSeguranca, DataValidade, NomeCartao) values (@NumeroCartao, @CodigoSeguranca, @DataValidade, @NomeCartao)";
            conn.Execute(query, cartao);
            conn.Close();
        }
    }
}
    

