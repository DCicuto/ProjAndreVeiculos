﻿using Dapper;
using Microsoft.Data.SqlClient;
using Models;
using System.ComponentModel.DataAnnotations;

namespace Repositories
{
    public class BoletoRepository
    {
        private string StrConn = "Server=127.0.0.1; Database=ProjCARROS; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=True;";
        SqlConnection conn;

        public BoletoRepository()
        {
            conn = new SqlConnection(StrConn);
        }

        public void InserirBoleto(Boleto boleto)
        {
            conn.Open();
            string query = "INSERT INTO Table_Boleto (Id, Numero, DataVencimento) values (@Id, @Numero, @DataVencimento)";
            conn.Execute(query, boleto);
            conn.Close();
        }

    }
}
