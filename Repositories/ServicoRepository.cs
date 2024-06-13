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
    public class ServicoRepository
    {
        private string StrConn = "Server=127.0.0.1; Database=ProjCARROS; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=True;";
        SqlConnection conn;

        public ServicoRepository()
        {
            conn = new SqlConnection(StrConn);
        }

        public void InserirServico(Servico servico)
        {
            conn.Open();
            string query = "INSERT INTO Table_Servico (Id, Descricao) values (@Id, @Descricao)";
            conn.Execute(query, servico);
            conn.Close();
        }
    }
}
    
