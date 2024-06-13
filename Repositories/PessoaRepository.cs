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
    public class PessoaRepository
    {
        private string StrConn = "Server=127.0.0.1; Database=ProjCARROS; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=True;";
        SqlConnection conn;

        public PessoaRepository()
        {
            conn = new SqlConnection(StrConn);
        }

        public void InserirPessoa(Pessoa pessoa)
        {
            conn.Open();
            string query = "INSERT INTO Table_Pessoa (Documento, Nome, DataNascimento, IdEndereco, Telefone, Email) values (@Documento, @Nome, @DataNascimento, @IdEndereco, @Telefone, @Email)";
            conn.Execute(query, pessoa);
            conn.Close();
        }

    }
}
    

