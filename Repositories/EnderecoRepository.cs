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
    public class EnderecoRepository
    {
        private string StrConn = "Server=127.0.0.1; Database=ProjCARROS; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=True;";
        SqlConnection conn;

        public EnderecoRepository()
        {
            conn = new SqlConnection(StrConn);
        }

        public void InserirEndereco(Endereco endereco)
        {
            conn.Open();
            string query = "INSERT INTO Table_Endereco (Id, Logradouro, CEP, Bairro, TipoLogradouro, Numero, Uf, Cidade) values (@Id, @Logradouro, @CEP, @Bairro, @TipoLogradouro, @Numero, @Uf, @Cidade)";
            conn.Execute(query, endereco);
            conn.Close();
        }
    }
}
    

